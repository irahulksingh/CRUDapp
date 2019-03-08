using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace crudApp.DataAccessLayer
{
    public class User : DbContext
    {
        public System.Data.Entity.DbSet<crudApp.Models.UserRegistration> UserRegistrations { get; set; }
    }
}