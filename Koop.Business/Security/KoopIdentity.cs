﻿using Koop.Data.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Koop.Business.Security
{
    public class KoopIdentity : ClaimsIdentity
    {
        internal KoopIdentity(PersonEntity person)
        {
            
        }
    }
}
