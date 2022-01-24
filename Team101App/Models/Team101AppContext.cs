using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Team101App.Models
{
    public class Team101AppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Team101AppContext() : base("name=Team101AppContext")
        {
        }

        public System.Data.Entity.DbSet<Team101App.Models.Record> Records { get; set; }
    }
}
