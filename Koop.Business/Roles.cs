using Koop.Data.EntityClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;

namespace Koop.Business
{
    public class Roles : TypeTable
    {
        private int _admin;
        private int _estimator;
        private int _vicePresident;
        public Roles(IDataAccessAdapter adapter, LookupTables lookup)
            : base(adapter, lookup)
        {
            _admin = -1;
            _estimator = -1;
            _vicePresident = -1;
        }

        public int Admin
        {
            get
            {
                if (_admin < 1)
                    _admin = GetOrAddRole("Admin");
                return _admin;
            }
        }

        public int Estimator
        {
            get
            {
                if (_estimator < 1)
                    _estimator = GetOrAddRole("Estimator");
                return _estimator;
            }
        }

        public int VicePresident
        {
            get
            {
                if (_vicePresident < 1)
                    _vicePresident = GetOrAddRole("VicePresident");
                return _vicePresident;
            }
        }

        private int GetOrAddRole(string rolename)
        {
            var id = base.FindMatch(RoleFields.RoleId, RoleFields.Name, rolename, LookupTableType.Roles);
            if (id == -1)
                id = AddType(new RoleEntity(), rolename, LookupTableType.Roles);
            return id;
        }
    }
}
