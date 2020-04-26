using Common.Model;
using Common.ServerContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class InitialData
    {
        public InitialData()
        {
            CheckAndFillData();
        }

        private void CheckAndFillData()
        {
            IUserServerExtension userServer = new UserServer();
            if (userServer.CheckExisting())
            {
                userServer.Add(new User { Name = "Admin", Username = "Admin", LastName = "Admin", Password = "Admin" });
                userServer.Add(new User { Name = "Stefan", Username = "stefanr", LastName = "Ruvceski", Password = "stefanrrr" });
                userServer.Add(new User { Name = "Teodora", Username = "teodorar", LastName = "Ruvceski", Password = "teodorarrr" });
            }

            ITelephoneServerExtension telephoneServer = new TelephoneServer();
            if (telephoneServer.CheckExisting())
            {
                telephoneServer.AddTelephone(new ShopTelephone() {Name = "IphoneX",Price = 800,Year= 2017,ShopName="MobilniSvet",Diagonal=5,Description= "",UserName="teodorar" });
                telephoneServer.AddTelephone(new ShopTelephone() { Name = "SamsungS9", Price = 900, Year = 2018, ShopName = "MobilniSvet", Diagonal = 6, Description = "" ,UserName="stefanr"});
                telephoneServer.AddTelephone(new ShopTelephone() { Name = "GooglePixel2", Price = 700, Year = 2017, ShopName = "MobShop", Diagonal = 5,UserName = "Admin", Description = "" });
            }

            IShopServerExtension shopServer= new ShopServer();
            if (shopServer.CheckExisting())
            {
                shopServer.AddShop( new Shop() { Name= "MobilniSvet",Address= "Bulevar Cara Lazara 22",PhoneNumber= "06586912534"});
                shopServer.AddShop(new Shop() { Name = "MobShop", Address = "Lasla Gala 17", PhoneNumber = "0637502913" });
                shopServer.AddShop(new Shop() { Name = "ProdajaTelefona", Address = "Modene 7", PhoneNumber = "0642968504" });
            }
        }
    }
}
