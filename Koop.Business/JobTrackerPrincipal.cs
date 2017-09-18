using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Linq;
using System.Security.Principal;
using System.Web.Security;

namespace Koop.Business
{
    public class JobTrackerPrincipal : IPrincipal
    {
        //private static JobTrackerPrincipal _current;
        private JobTrackerIdentity _identity;
        private RoleEntity _role;
        private IDataAccessAdapter _adapter;
        private Roles _roles;
        private JobTrackerRoles _roleType;

        //public static JobTrackerPrincipal Current
        //{
        //    get
        //    {
        //        if (JobTrackerPrincipal._current == null)
        //        {
        //            JobTrackerPrincipal._current = new JobTrackerPrincipal();
        //        }

        //        return JobTrackerPrincipal._current;
        //    }
        //}

        public IIdentity Identity
        {
            get
            {
                return this._identity;
            }
        }

        public int PersonId
        {
            get
            {
                int result;
                result = this._identity.User == null ? -1 : this._identity.User.PersonId;
                return result;
            }
        }

        public JobTrackerRoles Role
        {
            get
            {
                bool flag = this._roleType != JobTrackerRoles.Unidentified;
                if (!flag)
                {
                    flag = this._identity.User != null;
                    if (flag)
                    {
                        flag = this._identity.User.RoleId != _roles.Admin;
                        if (flag)
                        {
                            flag = this._identity.User.RoleId != _roles.Estimator;
                            if (flag)
                            {
                                flag = this._identity.User.RoleId != _roles.VicePresident;
                                if (flag)
                                {
                                    this._roleType = JobTrackerRoles.Unidentified;
                                }
                                else
                                {
                                    this._roleType = JobTrackerRoles.VicePresident;
                                }
                            }
                            else
                            {
                                this._roleType = JobTrackerRoles.Estimator;
                            }
                        }
                        else
                        {
                            this._roleType = JobTrackerRoles.Admin;
                        }
                    }
                    else
                    {
                        this._roleType = JobTrackerRoles.Unidentified;
                    }
                }

                return this._roleType;
            }
        }

        private JobTrackerPrincipal(IDataAccessAdapter adapter, Roles roles)
        {
            _identity = null;
            _role = null;
            _adapter = null;
            _roleType = JobTrackerRoles.Unidentified;
            _adapter = adapter;
            _roles = roles;
            _identity = new JobTrackerIdentity(_adapter, null, false);
        }

        public bool Login(string username, string password)
        {
            bool authenticated = false;

            password = HashPassword(password);

            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket();
            filterBucket.PredicateExpression.Add(PersonFields.Username == username);
            filterBucket.PredicateExpression.AddWithAnd(PersonFields.Password == password);
            this._adapter.OpenConnection();
            this._adapter.FetchEntityCollection(collectionToFill, filterBucket);
            this._adapter.CloseConnection();
            if (collectionToFill.Items.Count != 1)
            {
                this._identity = new JobTrackerIdentity(_adapter, null, false);
                authenticated = false;
            }
            else
            {
                this._identity = new JobTrackerIdentity(_adapter, collectionToFill[0], true);
                authenticated = true;
            }

            return authenticated;
        }

        public string HashPassword(string password)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        }

        public bool IsUsernameAvailable(string username)
        {
            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket(PersonFields.Username == username);
            this._adapter.OpenConnection();
            this._adapter.FetchEntityCollection(collectionToFill, filterBucket);
            this._adapter.CloseConnection();
            bool result;
            result = !(collectionToFill.Items.Count != 0);
            return result;
        }

        public int UsernameBelongsTo(string username)
        {
            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket(PersonFields.Username == username);
            this._adapter.OpenConnection();
            this._adapter.FetchEntityCollection(collectionToFill, filterBucket);
            this._adapter.CloseConnection();
            int result;
            result = collectionToFill.Items.Count <= 0 ? 0 : collectionToFill[0].PersonId;
            return result;
        }

        public bool IsInRole(string role)
        {
            if (this._role == null)
            {
                this._adapter.OpenConnection();
                this._role = (RoleEntity)this._adapter.FetchNewEntity(new RoleEntityFactory(), this._identity.User.GetRelationInfoRole());
                this._adapter.CloseConnection();
            }

            return this._role.Name == role;
        }

        //static JobTrackerPrincipal()
        //{
        //    JobTrackerPrincipal._current = null;
        //}
    }
}
