using Common.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access
{
    public class ShopContext : DbContext
    {
        #region Fields
        public DbSet<User> Users { get; set; }          //User Table
        public DbSet<Shop> Shops { get; set; }          //Shops Table
        public DbSet<ShopTelephone> Telephones { get; set; }   //Telephones Table
        #endregion

        #region Constructor
        public ShopContext() : base("ShopConnection"){}
        #endregion
    }
}
