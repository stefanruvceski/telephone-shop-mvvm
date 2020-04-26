using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Client.ViewModel
{
    class AddNewTelephoneViewModel
    {
        #region Fields
        ObservableCollection<Shop> shops;
        LogHandler logHandler;

        public ShopTelephone NewTelephone { get; set; }
        public User CurrentUser { get; set; }
        public Window Window { get; set; }
        public ObservableCollection<Shop> Shops { get => shops; set => shops = value; }
        #endregion

        #region Constructor
        public AddNewTelephoneViewModel()
        {
            logHandler = LogHandler.Instance;
            Shops = new ObservableCollection<Shop>(Channel.Instance.shopProxy.GetShops());
            NewTelephone = new ShopTelephone();
            AddThisTelephoneCommand = new AddThisTelephoneCommand(this);
        }
        #endregion

        #region Add Telephone
        public IMyCommand AddThisTelephoneCommand
        {
            get;
            private set;
        }

        public bool CanAddTelephone
        {
            get 
            {
                if( !String.IsNullOrWhiteSpace(NewTelephone.Name) && !String.IsNullOrWhiteSpace(NewTelephone.Year.ToString()) && !String.IsNullOrWhiteSpace(NewTelephone.Diagonal.ToString()) && !String.IsNullOrWhiteSpace(NewTelephone.Price.ToString()) && !String.IsNullOrWhiteSpace(NewTelephone.Description) && NewTelephone.Diagonal > 0 && NewTelephone.Year > 1900 && NewTelephone.Year <= DateTime.Now.Year && NewTelephone.Price > 0 && !String.IsNullOrWhiteSpace(NewTelephone.ShopName))
                    return true;
                else
                    return false;
            }
        }

        public void ExecuteAddTelephone(object o = null)
        {
            if (o != null)
                NewTelephone = (ShopTelephone)o;
       

            Context context = new Context(NewTelephone);
            if (!context.ChackValidation())
                return;

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, CurrentUser.Name + " has clicked add Telephone.");

            try
            {
                if (Channel.Instance.shopProxy.GetShops().FindAll(x => x.Name == NewTelephone.ShopName).Count == 0)
                {
                    MessageBox.Show("This shop is deleted pleas choose other.");
                    Shops = new ObservableCollection<Shop>(Channel.Instance.shopProxy.GetShops());
                    return;
                }
                NewTelephone.UserName = CurrentUser.Username;
                if (Channel.Instance.telephoneProxy.AddTelephone(NewTelephone))
                {
                    if (o == null)
                        CommandHandler.Instance.AddAndExecute(AddThisTelephoneCommand, Channel.Instance.telephoneProxy.GetTelephone(NewTelephone.Name));

                    Window.Close();
                }
                else
                    MessageBox.Show("Telephone already exists");

            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            ContentHandler.Refresh();
        }

        public void UnxecuteAddTelephone(object o = null)
        {
            if (o != null)
                NewTelephone = (ShopTelephone)o;

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Delete Telephone is opened.");
            try
            {
                if (!Channel.Instance.telephoneProxy.DeleteTelephone(NewTelephone))
                {
                    MessageBox.Show("already deleted");
                }

            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        #endregion
    }
}
