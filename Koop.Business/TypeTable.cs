using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koop.Business
{
    public abstract class TypeTable
    {
        private IDataAccessAdapter _adapter;
        private LookupTables _lookup;
        public TypeTable(IDataAccessAdapter adapter, LookupTables lookup)
        {
            _adapter = adapter;
            _lookup = lookup;
        }

        internal virtual int AddType(EntityBase2 entity, string name, LookupTableType type)
        {
            entity.SetNewFieldValue("Name", name);
            entity.SetNewFieldValue("Active", true);
            IDataAccessAdapter adapter = _adapter;
            adapter.OpenConnection();
            adapter.SaveEntity(entity, true);
            adapter.CloseConnection();
            _lookup.Refresh();
            return (int)(entity.Fields.PrimaryKeyFields[0].CurrentValue);
        }

        internal virtual int FindMatch(EntityField2 keyField, EntityField2 matchField, object value, LookupTableType type)
        {
            EntityCollection data = _lookup.GetLookupTable(type);
            List<int> matches = data.FindMatches(new FieldCompareValuePredicate(matchField, null, ComparisonOperator.Equal, value));
            int result;
            result = matches.Count <= 0 ? -1 : (int)(data[matches[0]].Fields[keyField.Name].CurrentValue);
            return result;
        }
    }
}
