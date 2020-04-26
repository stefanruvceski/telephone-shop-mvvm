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
    class ChangeShopInfoViewModel
    {
        #region Fields
        public Window Window { get; set; }
        public Shop CurrentShop { get; set; }

        LogHandler logHandler;

        #endregion

        #region Constructor
        public ChangeShopInfoViewModel(Window w, Shop shop)
        {
            logHandler = LogHandler.Instance;
            Window = w;
            CurrentShop = shop;
            ChangeThisShopCommand = new ChangeThisShopInfoCommand(this);
        }
        #endregion

        #region Change Shop
        public ICommand ChangeThisShopCommand
        {
            get;
            private set;
        }
        public bool CanChange
        {
            get
            {
                if (String.IsNullOrWhiteSpace(CurrentShop.Name)  && String.IsNullOrWhiteSpace(CurrentShop.Address) && String.IsNullOrWhiteSpace(CurrentShop.PhoneNumber))
                    return false;
                return true;
            }
        }

        public void ChangeShop()
        {
            if (CanChange)
            {
                try
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Change Shop is clicked.");
                    if (Channel.Instance.shopProxy.UpdateShop(CurrentShop))
                    {
                        Window.Close();
                    }
                    else
                    {
                        MessageBox.Show("Name is already exists!");
                    }
                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty! Please, fill them.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            ContentHandler.Refresh();
        }
        #endregion
    }
}
