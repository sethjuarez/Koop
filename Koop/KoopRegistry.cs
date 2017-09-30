using Koop.Business;
using Koop.Data.DatabaseSpecific;
using SD.LLBLGen.Pro.ORMSupportClasses;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Koop
{
    public class KoopRegistry : Registry
    {
        public KoopRegistry()
        {
            For<IDataAccessAdapter>()
                .Use(new DataAccessAdapter(@"data source=.\SQLEXPRESS;initial catalog=Job;integrated security=SSPI;persist security info=False;packet size=4096"));
        }
    }
}
