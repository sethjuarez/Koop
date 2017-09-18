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
    public class JobTrackerIdentity : IIdentity
    {
        private PersonEntity _user;
        private bool _isAuthenticated;
        private IDataAccessAdapter _adapter;
        private RoleEntity _role;

        public PersonEntity User
        {
            get
            {
                return this._user;
            }
        }

        public string Username
        {
            get
            {
                string result;
                result = this._user == null ? string.Empty : this._user.Username;
                return result;
            }
        }

        public string AuthenticationType
        {
            get
            {
                return "InsideTrackSecurityPolicy";
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return this._isAuthenticated;
            }
        }

        public string Name
        {
            get
            {
                string result;
                result = _user != null ? _user.Username : string.Empty;
                return result;
            }
        }

        public string FullName
        {
            get
            {
                string result;
                result = _user != null ? _user.FirstName + " " + _user.LastName : string.Empty;
                return result;
            }
        }

        public JobTrackerIdentity(IDataAccessAdapter adapter)
        {
            this._user = null;
            this._isAuthenticated = false;
            this._adapter = null;
            this._role = null;
            this._adapter = adapter;
            this._user = null;
            this._isAuthenticated = false;
        }

        internal JobTrackerIdentity(IDataAccessAdapter adapter, PersonEntity user, bool isAuthenticated)
        {
            this._user = null;
            this._isAuthenticated = false;
            this._adapter = null;
            this._role = null;
            this._adapter = adapter;
            this._user = user;
            this._isAuthenticated = isAuthenticated;
        }

        internal bool IsInRole(string role)
        {
            if (this._role == null)
            {
                this._role = this._user.Role;
                this._adapter.OpenConnection();
                this._adapter.FetchEntity(this._role);
                this._adapter.CloseConnection();
            }

            return this._role.Name == role;
        }
    }
}
