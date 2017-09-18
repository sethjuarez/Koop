using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Linq;

namespace Koop.Business
{
    internal class KeyLookupFormatter : IFormatProvider, ICustomFormatter
    {
        private IDataAccessAdapter _adapter;
        private Type _entityType;
        private IEntityField2 _replaceField;

        public KeyLookupFormatter(IDataAccessAdapter adapter, Type entityType, IEntityField2 replaceField)
        {
            this._adapter = adapter;
            this._entityType = entityType;
            this._replaceField = replaceField;
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }

        string ICustomFormatter.Format(string format, object arg, IFormatProvider formatProvider)
        {
            EntityBase2 entityToFetch = (EntityBase2)Activator.CreateInstance(this._entityType, arg);
            _adapter.OpenConnection();
            _adapter.FetchEntity(entityToFetch);
            _adapter.CloseConnection();
            return entityToFetch.Fields[this._replaceField.Name].CurrentValue.ToString();
        }
    }
}
