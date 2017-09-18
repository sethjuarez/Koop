using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Linq;

namespace Koop.Business
{
    public class Group : TypeTable
    {
        private int _none;

        public int None
        {
            get
            {
                if (_none < 1)
                    _none = GetOrAddGroup("None");

                return _none;
            }
        }

        private int GetOrAddGroup(string groupname)
        {
            var id = base.FindMatch(GroupFields.GroupId, GroupFields.Name, groupname, LookupTableType.Groups);
            if (id == -1)
                id = AddType(new GroupEntity(), groupname, LookupTableType.Groups);
            return id;
        }

        public Group(IDataAccessAdapter adapter, LookupTables lookup)
            : base(adapter, lookup) => _none = -1;

    }
}
