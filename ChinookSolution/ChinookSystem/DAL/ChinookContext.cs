﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{

    internal class ChinookContext : DbContext
    {
        public ChinookContext() : base("ChinookDB")
        { }
    }
}
