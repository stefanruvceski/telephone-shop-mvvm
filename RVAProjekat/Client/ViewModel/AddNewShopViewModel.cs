using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Client.ViewModel
{
    class AddNewShopViewModel
    {
        #region Fields
        LogHandler logHandler;

        public Window Window { get; set; }
        public Shop NewShop { get; set; }
        public User CurrentUser { get; set; }
        #endregion

        #region Constructor
        public AddNewShopViewModel()
        {
            logHandler = LogHandler.Instance;
            NewShop = new Shop();
            AddThisShopCommand = new AddThisShopCommand(this);
        }
        #endregion

        #region Add Shop
        public ICommand AddThisShopCommand
        {
            get;
            private set;
        }

        public bool CanAddShop
        {
            get
            {
                return !String.IsNullOrWhiteSpace(NewShop.Name) && !String.IsNullOrWhiteSpace(NewShop.Address) && !String.IsNullOrWhiteSpace(NewShop.PhoneNumber);
            }
        }

        public void AddShop()
        {
            Context context = new Context(NewShop);
            if (!context.ChackValidation())
                return;
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, CurrentUser.Name + " has clicked add Shop.");
            try
            {
                if (Channel.Instance.shopProxy.AddShop(NewShop))
                {
                    Window.Close();
                }
                else
                    MessageBox.Show("Shop already exists");
            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            ContentHandler.Refresh();
        }
        #endregion
    }
}
