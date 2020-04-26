using Common.Access;
using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class DBManager : IDBManagar
    {
        #region Fields
        static DBManager instance;
        
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                    return new DBManager();
                else
                    return instance;
            }
        }
        #endregion

        #region Operations

        #region Telephone
        public bool AddTelephone(ShopTelephone telephone)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    telephone.LastModified = DateTime.Now;
                    dbContext.Telephones.Add(telephone);
                    dbContext.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool DeleteTelephone(ShopTelephone telephone)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    dbContext.Telephones.Attach(telephone);
                    dbContext.Telephones.Remove(telephone);
                    dbContext.SaveChanges();

                    return true;

                }
                catch
                {

                    return false;
                }
            }
        }

        public bool UpdateTelephone(ShopTelephone telephone)
        {
            using (var dbContext = new ShopContext())
            {
                var oldTelephone = dbContext.Telephones.Find(telephone.Id);
                if (oldTelephone == null)
                {

                    return false;
                }
                else if (oldTelephone.LastModified != telephone.LastModified)
                {

                    return false;
                }
                else
                {
                    oldTelephone.Name = telephone.Name;
                    oldTelephone.Year = telephone.Year;
                    oldTelephone.Price = telephone.Price;
                    oldTelephone.Description = telephone.Description;
                    oldTelephone.Diagonal = telephone.Diagonal;
                    oldTelephone.LastModified = DateTime.Now;
                    dbContext.SaveChanges();
                    return true;
                }
            }
        }

        public bool UpdateNewTelephone(ShopTelephone telephone)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    var oldTelephone = dbContext.Telephones.Find(telephone.Id);
                    if (oldTelephone != null)
                    {
                        dbContext.Telephones.Remove(oldTelephone);
                        dbContext.SaveChanges();
                        telephone.LastModified = DateTime.Now;
                        dbContext.Telephones.Add(telephone);
                        dbContext.SaveChanges();

                        return true;
                    }
                    else
                    {
                        telephone.LastModified = DateTime.Now;
                        dbContext.Telephones.Add(telephone);

                        dbContext.SaveChanges();
                        return false;
                    }
                }
                catch
                {
                    
                    return false;
                }
            }
        }

        public BindingList<ShopTelephone> GetAllTelephones()
        {
            using (var dbContext = new ShopContext())
            {
                return new BindingList<ShopTelephone>(dbContext.Telephones.ToList());
            }
        }

        public ShopTelephone GetTelephone(String telephone)
        {
            return GetAllTelephones().ToList().Find(t => t.Name.Equals(telephone));
        }

        public BindingList<ShopTelephone> GetTelephones(String shop)
        {
            using (var dbContext = new ShopContext())
            {
                List<ShopTelephone> telephones = dbContext.Telephones.ToList().FindAll(t => t.ShopName.Equals(shop));
                return new BindingList<ShopTelephone>(telephones.OrderBy(x => x.Name).ToList());
            }
        }

        public BindingList<ShopTelephone> GetTelephonesByCondition(String name, String condition, String content)
        {
            switch (name)
            {
                case "Name":
                    return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Name.ToLower().Contains(content)));
                case "Price":
                    {
                        if (condition.ToLower().Equals("more"))
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Price >= double.Parse(content)));
                        }
                        else
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Price <= double.Parse(content)));
                        }

                    }

                case "Year":
                    {
                        if (condition.ToLower().Equals("after"))
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Year >= int.Parse(content)));
                        }
                        else
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Year <= int.Parse(content)));
                        }

                    }
                case "Diagonal":
                    {
                        if (condition.ToLower().Equals("more"))
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Diagonal >= double.Parse(content)));
                        }
                        else
                        {
                            return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.Diagonal <= double.Parse(content)));
                        }

                    }
                case "Shop":
                    return new BindingList<ShopTelephone>(GetAllTelephones().ToList().FindAll(t => t.ShopName.Equals(content)));
                default:
                    return new BindingList<ShopTelephone>();
            }
        }
        #endregion

        #region Shop
        public bool AddShop(Shop shop)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    dbContext.Shops.Add(shop);
                    dbContext.SaveChanges();
                    
                    return true;
                }
                catch
                {
                    
                    return false;
                }
            }
        }

        public bool DeleteShop(Shop shop)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    dbContext.Shops.Attach(shop);
                    dbContext.Shops.Remove(shop);
                    dbContext.SaveChanges();
                   
                    return true;
                }
                catch
                {
                    
                    return false;
                }

            }
        }

        public List<Shop> GetShops()
        {
            using (var dbContext = new ShopContext())
            {
                List<Shop> shops = dbContext.Shops.ToList();
                shops = shops.OrderBy(x => x.Id).ToList();
               
                return shops;
            }
        }

        public Shop GetShop(String shopName)
        {
            return GetShops().Find(s => s.Name.Equals(shopName));
        }

        public bool UpdateShop(Shop shop)
        {
            using (var dbContext1 = new ShopContext())
            {
                var oldShop = dbContext1.Shops.FirstOrDefault(m => m.Id == shop.Id);

                if (oldShop != null)
                {
                    var lists = dbContext1.Telephones.Where(f => f.ShopName.Equals(oldShop.Name)).ToList();
                    lists.ForEach(a => a.ShopName = shop.Name);
                    dbContext1.SaveChanges();
                }
            }
            using (var dbContext = new ShopContext())
            {
                try
                {
                    var oldShop = dbContext.Shops.FirstOrDefault(m => m.Id == shop.Id);
                    if (oldShop != null)
                    {
                        dbContext.Shops.Remove(oldShop);
                        dbContext.SaveChanges();
                        dbContext.Shops.Add(shop);
                        dbContext.SaveChanges();
                        
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                catch
                {
                    
                    return false;
                }
            }
        }

        #endregion

        #region User
        public bool Add(User user)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                    
                    return true;
                }
                catch
                {
                    
                    return false;
                }
            }
        }

        public User Get(String userName)
        {
            using (var dbContext = new ShopContext())
            {
                return dbContext.Users.FirstOrDefault(m => m.Username == userName);
            }
        }

        public bool Update(User user)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    var oldUser = dbContext.Users.Find(user.Username);
                    if (oldUser != null)
                    {
                        dbContext.Users.Remove(oldUser);
                        dbContext.SaveChanges();
                        dbContext.Users.Add(user);
                        dbContext.SaveChanges();
                       
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                catch
                {
                    
                    return false;
                }
            }
        }

        public bool Remove(User user)
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    var oldUser = dbContext.Users.Find(user.Name);
                    if (oldUser != null)
                    {
                        dbContext.Users.Remove(oldUser);
                        dbContext.SaveChanges();
                        
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
                catch
                {
                   
                    return false;
                }
            }
        }

        public bool GetAll()
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    
                    if (dbContext.Users.Count() == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }

        }

        #endregion

        #endregion
    }
}
