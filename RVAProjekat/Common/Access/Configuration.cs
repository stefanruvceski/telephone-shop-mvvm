using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access
{
    class Configuration : DbMigrationsConfiguration<ShopContext>
    {
        #region Constructor
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ShopContext";
        }
        #endregion
    }
}
