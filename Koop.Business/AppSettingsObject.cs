using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Koop.Business
{
    [XmlRoot(ElementName = "AppSettingsObject", DataType = "string", IsNullable = true)]
    public class AppSettingsObject
    {
        private static AppSettingsObject _default;
        private IDataAccessAdapter _adapter;
        private SettingEntity _appSettings;
        private int _estimatorId;
        [XmlElement("OverheadItems", typeof(OverheadCollection))]
        private OverheadCollection _overhead;

        //public static AppSettingsObject Default
        //{
        //    get
        //    {
        //        if (AppSettingsObject._default == null)
        //        {
        //            AppSettingsObject._default = new AppSettingsObject();
        //        }

        //        return AppSettingsObject._default;
        //    }
        //}

        [ReadOnly(false), XmlElement("EstimatorId", typeof(int)), Category("Application Settings"), Description("This ID defines the Estimator Role")]
        public virtual int EstimatorId
        {
            get
            {
                return this._estimatorId;
            }

            set
            {
                this._estimatorId = value;
            }
        }

        [Category("Application Settings"), Description("System Overhead Rates"), ReadOnly(false)]
        public virtual OverheadCollection Overhead
        {
            get
            {
                return this._overhead;
            }

            set
            {
                this._overhead = value;
            }
        }

        private AppSettingsObject(IDataAccessAdapter adapter)
        {
            _adapter = adapter;
            _appSettings = null;
            _overhead = new OverheadCollection();
            Load();
        }

        public void Load()
        {
            bool flag = this._adapter != null;

            EntityCollection<SettingEntity> collectionToFill = new EntityCollection<SettingEntity>(new SettingEntityFactory());
            this._adapter.OpenConnection();
            this._adapter.FetchEntityCollection(collectionToFill, null);
            this._adapter.CloseConnection();
            flag = collectionToFill.Items.Count != 0;
            if (flag)
            {
                this._appSettings = collectionToFill[0];
                try
                {
                    this.DeserializeSettings();
                }
                catch
                {
                }
            }
            else
            {
                this._appSettings = new SettingEntity();
                this.LoadEmpty();
            }

            flag = collectionToFill.Items.Count <= 1;
            if (!flag)
            {
                this._adapter.OpenConnection();
                for (int i = 1; i < collectionToFill.Items.Count; i++)
                {
                    this._adapter.DeleteEntity(collectionToFill[i]);
                }

                this._adapter.CloseConnection();
            }

            this.Overhead.SortByRate();
        }

        public void Save()
        {
            this.SerializeSettings();
        }

        private void LoadEmpty()
        {
            this.EstimatorId = -1;
            this.Overhead = new OverheadCollection();
            this.Save();
        }

        private void SerializeSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppSettingsObject));
            StringBuilder formatProvider = new StringBuilder();
            TextWriter w = new StringWriter(formatProvider);
            XmlWriter textWriter = new XmlTextWriter(w);
            serializer.Serialize(textWriter, AppSettingsObject._default);
            textWriter.Close();
            w.Close();
            formatProvider.Replace(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
            formatProvider.Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "");
            formatProvider.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "<?xml version=\"1.0\"?>");
            if (this._appSettings.IsNew)
            {
                this._appSettings.DbVersion = new decimal(10, 0, 0, false, 1);
            }

            this._appSettings.Xml = formatProvider.ToString();
            this._adapter.OpenConnection();
            this._adapter.SaveEntity(this._appSettings);
            this._adapter.CloseConnection();
        }

        //private void LoadDefault()
        //{
        //    AppSettingsObject._default = new AppSettingsObject();
        //    AppSettingsObject._default.EstimatorId = this.EstimatorId;
        //    AppSettingsObject._default.Overhead = this.Overhead.Clone();
        //}

        private void DeserializeSettings()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(this._appSettings.Xml);
            bool flag = (doc.GetElementsByTagName("EstimatorId").Count) <= 0;
            if (!flag)
            {
                this._estimatorId = int.Parse(doc.GetElementsByTagName("EstimatorId").Item(0).InnerText);
            }

            this._overhead = new OverheadCollection();
            flag = (doc.GetElementsByTagName("Overhead").Count) <= 0;
            if (!flag)
            {
                XmlNode ratesNode = doc.GetElementsByTagName("Overhead").Item(0);
                flag = !ratesNode.HasChildNodes;
                if (!flag)
                {
                    var enumerator = ratesNode.ChildNodes.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            XmlNode node = (XmlNode)enumerator.Current;
                            decimal range = decimal.Parse(node.ChildNodes.Item(0).InnerText);
                            decimal percent = decimal.Parse(node.ChildNodes.Item(1).InnerText);
                            this._overhead.Add(new Overhead(range, percent));
                        }
                    }
                    finally
                    {
                        IDisposable disposable = enumerator as IDisposable;
                        flag = disposable == null;
                        if (!flag)
                        {
                            disposable.Dispose();
                        }
                    }
                }
            }
        }

        static AppSettingsObject()
        {
            AppSettingsObject._default = null;
        }
    }
}
