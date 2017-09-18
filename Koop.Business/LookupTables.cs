using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Linq;

namespace Koop.Business
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public enum LookupTableType
    {
        Estimators,
        JobStatus,
        DamageType,
        Vendor,
        Roles,
        Groups
    }

    public class LookupTables
    {
        private IDataAccessAdapter _adapter;
        private Roles _role;
        private EntityCollection _groups;
        private EntityCollection _roles;
        private EntityCollection _estimators;
        private EntityCollection _jobStatus;
        private EntityCollection _damageType;
        private EntityCollection _vendor;

        public event ChangedEventHandler Changed;
        protected virtual void OnChanged(EventArgs e) =>
            Changed?.Invoke(this, e);

        public LookupTables(IDataAccessAdapter adapter, Roles roles)
        {
            _groups = null;
            _roles = null;
            _estimators = null;
            _jobStatus = null;
            _damageType = null;
            _vendor = null;
            _adapter = adapter;
            _role = roles;
        }

        private EntityCollection Fetch(EntityCollection collection, IRelationPredicateBucket predicateBucket = null)
        {
            _adapter.OpenConnection();
            _adapter.FetchEntityCollection(collection, predicateBucket);
            _adapter.CloseConnection();
            return collection;
        }

        public EntityCollection Groups
        {
            get
            {
                if (_groups == null)
                    _groups = Fetch(new EntityCollection(new GroupEntityFactory()));

                return _groups;
            }
        }

        public EntityCollection Roles
        {
            get
            {
                if (_roles == null)
                    _roles = Fetch(new EntityCollection(new RoleEntityFactory()));

                return _roles;
            }
        }

        public EntityCollection Estimators
        {
            get
            {
                if (_estimators == null)
                    _estimators = Fetch(new EntityCollection(new PersonEntityFactory()),
                        new RelationPredicateBucket(
                            PersonFields.RoleId == _role.Estimator |
                            PersonFields.RoleId == _role.VicePresident));

                return _estimators;
            }
        }

        public EntityCollection JobStatus
        {
            get
            {
                if (_jobStatus == null)
                    _jobStatus = Fetch(new EntityCollection(new StatusEntityFactory()));

                return _jobStatus;
            }
        }

        public EntityCollection DamageType
        {
            get
            {
                if (_damageType == null)
                    _damageType = Fetch(new EntityCollection(new DamageEntityFactory()));

                return _damageType;
            }
        }

        public EntityCollection Vendor
        {
            get
            {
                if (_vendor == null)
                    _vendor = Fetch(new EntityCollection(new VendorEntityFactory()));

                return _vendor;
            }
        }

        public EntityCollection GetLookupTable(LookupTableType table)
        {
            EntityCollection col = null;
            switch (table)
            {
                case LookupTableType.Estimators:
                    col = Estimators;
                    break;
                case LookupTableType.JobStatus:
                    col = JobStatus;
                    break;
                case LookupTableType.DamageType:
                    col = DamageType;
                    break;
                case LookupTableType.Vendor:
                    col = Vendor;
                    break;
                case LookupTableType.Roles:
                    col = Roles;
                    break;
                case LookupTableType.Groups:
                    col = Groups;
                    break;
            }

            return col;
        }

        public void Notify()
        {
            OnChanged(EventArgs.Empty);
        }

        public void Refresh()
        {
            _estimators = null;
            _damageType = null;
            _jobStatus = null;
            _vendor = null;
            _groups = null;
            OnChanged(EventArgs.Empty);
        }

        public void Refresh(LookupTableType table)
        {
            switch (table)
            {
                case LookupTableType.Estimators:
                    _estimators = null;
                    break;
                case LookupTableType.JobStatus:
                    _jobStatus = null;
                    break;
                case LookupTableType.DamageType:
                    _damageType = null;
                    break;
                case LookupTableType.Vendor:
                    _vendor = null;
                    break;
                case LookupTableType.Roles:
                    _roles = null;
                    break;
                case LookupTableType.Groups:
                    _groups = null;
                    break;
            }

            OnChanged(EventArgs.Empty);
        }

    }
}
