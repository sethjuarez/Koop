using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.Business
{
    public class DataLookupFormatter : IFormatProvider, ICustomFormatter
    {
        private EntityCollection _collection;
        private IEntityField2 _keyField;
        private IEntityField2 _replaceField;
        private string _nullString;

        public DataLookupFormatter(LookupTableType table, IEntityField2 keyField, IEntityField2 replaceField)
        {
            _nullString = string.Empty;
            _collection = GetCollection(table);
            _keyField = keyField;
            _replaceField = replaceField;
        }

        public DataLookupFormatter(LookupTableType table, IEntityField2 keyField, IEntityField2 replaceField, string nullString)
        {
            _nullString = string.Empty;
            _collection = GetCollection(table);
            _keyField = keyField;
            _replaceField = replaceField;
            _nullString = nullString;
        }

        private static EntityCollection GetCollection(LookupTableType table)
        {
            //LookupTables.Instance.getLookupTable(table);
            return new EntityCollection();
        }

        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            IPredicate filter = new FieldCompareValuePredicate(_keyField, null, ComparisonOperator.Equal, arg);
            IList<int> matches = _collection.FindMatches(filter);
            string outString = string.Empty;
            bool flag = matches.Count <= 0;
            if (!flag)
            {
                int index = matches[0];
                flag = index <= -1;
                if (flag)
                {
                    flag = _nullString == string.Empty;
                    outString = flag ? "Not Available" : _nullString;
                }
                else
                {
                    outString = _collection.Items[index].Fields[_replaceField.Name].CurrentValue.ToString();
                }
            }

            return outString;
        }

        public string Format(object arg)
        {
            IPredicate filter = new FieldCompareValuePredicate(_keyField, null, ComparisonOperator.Equal, arg);
            IList<int> matches = _collection.FindMatches(filter);
            string outString = string.Empty;
            bool flag = matches.Count <= 0;
            if (!flag)
            {
                int index = matches[0];
                flag = index <= -1;
                if (flag)
                {
                    flag = _nullString == string.Empty;
                    outString = flag ? "Not Available" : _nullString;
                }
                else
                {
                    outString = _collection.Items[index].Fields[_replaceField.Name].CurrentValue.ToString();
                }
            }

            return outString;
        }

        public static string Format(LookupTableType table, IEntityField2 keyField, IEntityField2 replaceField, object arg)
        {
            EntityCollection _collection = GetCollection(table);
            IPredicate filter = new FieldCompareValuePredicate(keyField, null, ComparisonOperator.Equal, arg);
            IList<int> matches = _collection.FindMatches(filter);
            string outString = string.Empty;
            bool flag = matches.Count <= 0;
            if (!flag)
            {
                int index = matches[0];
                flag = index <= -1;
                if (flag)
                {
                    outString = "";
                }
                else
                {
                    outString = _collection.Items[index].Fields[replaceField.Name].CurrentValue.ToString();
                }
            }

            return outString;
        }

        public static string Format(LookupTableType table, IEntityField2 keyField, IEntityField2 replaceField, object arg, string nullString)
        {
            EntityCollection _collection = GetCollection(table);
            IPredicate filter = new FieldCompareValuePredicate(keyField, null, ComparisonOperator.Equal, arg);
            IList<int> matches = _collection.FindMatches(filter);
            string outString = string.Empty;
            bool flag = matches.Count <= 0;
            if (flag)
            {
                outString = nullString;
            }
            else
            {
                int index = matches[0];
                flag = index <= -1;
                if (flag)
                {
                    outString = nullString;
                }
                else
                {
                    outString = _collection.Items[index].Fields[replaceField.Name].CurrentValue.ToString();
                }
            }

            return outString;
        }

        public static string Format(LookupTableType table, IEntityField2 keyField, IList<IEntityField2> replaceField, object arg, string delim, string nullString)
        {
            EntityCollection _collection = GetCollection(table);
            IPredicate filter = new FieldCompareValuePredicate(keyField, null, ComparisonOperator.Equal, arg);
            IList<int> matches = _collection.FindMatches(filter);
            string str0 = string.Empty;
            bool flag = matches.Count <= 0;
            if (!flag)
            {
                int index = matches[0];
                flag = index <= -1;
                if (flag)
                {
                    str0 = nullString;
                }
                else
                {
                    str0 = "";
                    IEnumerator<IEntityField2> enumerator = replaceField.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            str0 = string.Concat(str0, _collection.Items[index].Fields[enumerator.Current.Name].CurrentValue.ToString(), delim);
                        }
                    }
                    finally
                    {
                        flag = enumerator == null;
                        if (!flag)
                        {
                            enumerator.Dispose();
                        }
                    }
                }
            }

            return str0;
        }
    }
}
