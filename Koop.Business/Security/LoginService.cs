using Koop.Data.EntityClasses;
using Koop.Data.FactoryClasses;
using Koop.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Koop.Business.Security
{
    public class LoginService
    {
        private readonly IDataAccessAdapter _adapter;

        public LoginService(IDataAccessAdapter adapter)
        {
            _adapter = adapter;
        }

        public ClaimsIdentity Authenticate(string username, string password)
        {
            password = HashPassword(password);

            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket();
            filterBucket.PredicateExpression.Add(PersonFields.Username == username);
            filterBucket.PredicateExpression.AddWithAnd(PersonFields.Password == password);

            _adapter.OpenConnection();
            _adapter.FetchEntityCollection(collectionToFill, filterBucket);
            _adapter.CloseConnection();


            if (collectionToFill.Items.Count != 1)
            {
                return new ClaimsIdentity("KoopAuthorization");
            }
            else
            {
                var person = collectionToFill[0];
                return new ClaimsIdentity(new List<Claim>
                {
                    new Claim("name", $"{person.FirstName} {person.LastName}"),
                    new Claim("username", person.Username),
                    new Claim("id", person.PersonId.ToString())
                }, "KoopAuthorization");

            }
        }

        public string HashPassword(string password)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        }

        public bool IsUsernameAvailable(string username)
        {
            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket(PersonFields.Username == username);
            _adapter.OpenConnection();
            _adapter.FetchEntityCollection(collectionToFill, filterBucket);
            _adapter.CloseConnection();
            return !(collectionToFill.Items.Count != 0);

        }

        public int UsernameBelongsTo(string username)
        {
            EntityCollection<PersonEntity> collectionToFill = new EntityCollection<PersonEntity>(new PersonEntityFactory());
            IRelationPredicateBucket filterBucket = new RelationPredicateBucket(PersonFields.Username == username);
            _adapter.OpenConnection();
            _adapter.FetchEntityCollection(collectionToFill, filterBucket);
            _adapter.CloseConnection();
            return collectionToFill.Items.Count <= 0 ? 0 : collectionToFill[0].PersonId;
        }
    }
}
