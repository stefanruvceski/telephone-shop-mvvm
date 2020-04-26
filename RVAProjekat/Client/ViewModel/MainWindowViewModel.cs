using Client.Adition;
using Client.ClientServerChannel;
using Client.Commands;
using Client.View;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static Common.Model.Enums;

namespace Client.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        #region Fields
        LogHandler logHandler { get; set; }

        public Window Window { get; set; }
        public User User { get; set; }
        public Shop SelectedShop { get; set; }

        public Shop SelectedShopTable { get; set; }
        public ShopTelephone SelectedTelephone { get; set; }

        #region PriceContent
        public Common.Model.Condition SelectedPriceCondition { get; set; }
        private String priceContent;
        public String PriceContent
        {
            get
            {
                return priceContent;
            }
            set
            {
                priceContent = value;
                OnPropertyChanged("PriceContent");
            }
        }
        private List<Common.Model.Condition> priceconditions { get; set; }
        public List<Common.Model.Condition> PriceConditions
        {
            get
            {
                return priceconditions;
            }
            set
            {
                priceconditions = value;
                OnPropertyChanged("PriceConditions");
            }
        }
        #endregion

        #region YearContent
        public Common.Model.Condition SelectedYearCondition { get; set; }
        private String yearContent;
        public String YearContent
        {
            get
            {
                return yearContent;
            }
            set
            {
                yearContent = value;
                OnPropertyChanged("YearContent");
            }
        }
        private List<Common.Model.Condition> yearconditions { get; set; }
        public List<Common.Model.Condition> YearConditions
        {
            get
            {
                return yearconditions;
            }
            set
            {
                yearconditions = value;
                OnPropertyChanged("YearConditions");
            }
        }
        #endregion

        #region DiagonalContent
        public Common.Model.Condition SelectedDiagonalCondition { get; set; }
        private String diagonalContent;
        public String DiagonalContent
        {
            get
            {
                return diagonalContent;
            }
            set
            {
                diagonalContent = value;
                OnPropertyChanged("DiagonalContent");
            }
        }
        private List<Common.Model.Condition> diagonalconditions { get; set; }
        public List<Common.Model.Condition> DiagonalConditions
        {
            get
            {
                return diagonalconditions;
            }
            set
            {
                diagonalconditions = value;
                OnPropertyChanged("DiagonalConditions");
            }
        }
        #endregion

        #region NameContent
        private String nameContent;

        public String NameContent
        {
            get
            {
                return nameContent;
            }
            set
            {
                nameContent = value;
                OnPropertyChanged("NameContent");
            }
        }

        #endregion

        #endregion

        #region Lists
        private BindingList<ShopTelephone> telephones { get; set; }
        private BindingList<ClientLog> logging { get; set; }
        private List<Shop> shops { get; set; }
        private List<Shop> tableShops { get; set; }
        private List<Common.Model.Condition> condition { get; set; }
        public BindingList<ShopTelephone> Telephones
        {
            get
            {
                return telephones;
            }
            set
            {
                telephones = value;
                OnPropertyChanged("Telephones");
            }
        }
        public BindingList<ClientLog> Logging
        {
            get
            {
                return logging;
            }
            set
            {
                logging = value;
                OnPropertyChanged("Logging");
            }
        }

        public List<Shop> Shops
        {
            get
            {
                return shops;
            }
            set
            {
                shops = value;
                OnPropertyChanged("Shops");
            }
        }
        public List<Shop> TableShops
        {
            get
            {
                return tableShops;
            }
            set
            {
                tableShops = value;
                OnPropertyChanged("TableShops");
            }
        }

        public List<Common.Model.Condition> Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
                OnPropertyChanged("Condition");
            }
        }
        #endregion

        #region Content Dependency
        public String UsernameContent
        {
            get
            {
                return User.Username;
            }
        }

        public String ButtonContent
        {
            get
            {
                if (User.Type == TYPE.ADMIN)
                    return "Add User";
                else
                    return "Mobile";
            }
        }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {

            #region starting view content
            logHandler = LogHandler.Instance;
            logHandler.MainWindowViewModel = this;
            ContentHandler.StartContent();
            Refresh();
            #endregion

            #region Commands
            AddUserCommand = new AddUserCommand(this);
            ViewProfilInfoCommand = new ViewProfilInfoCommand(this);
            AddTelephoneCommand = new AddTelephoneCommand(this);
            AddShopCommand = new AddShopCommand(this);
            ChangeTelephoneCommand = new ChangeTelephoneInfoCommand(this);
            DeleteTelephoneCommand = new DeleteTelephoneCommand(this);
            DuplicateTelephoneCommand = new DuplicateTelephoneCommand(this);
            ChangeShopCommand = new ChangeShopInfoCommand(this);
            DeleteShopCommand = new DeleteShopCommand(this);
            LogOutCommand = new LogOutCommand(this);
            BuyTelephoneCommand = new BuyTelephoneCommand(this);
            ClearCommand = new ClearCommand(this);
            UndoCommand = new UndoCommand(this);
            RedoCommand = new RedoCommand(this);
            FilterCommand = new FilterCommand(this);
            RefreshCommand = new RefreshCommand(this);
            #endregion

            
        }
        #endregion

        #region User
        #region LogOut

        public ICommand LogOutCommand
        {
            get;
            private set;
        }

        public void LogOut()
        {
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Log in again is opened.");
            new LogInVIew().Show();
            Window.Close();
        }

        #endregion

        #region AddNew user
        public ICommand AddUserCommand
        {
            get;
            private set;
        }

        public bool TypeOfUser
        {
            get
            {
                if (User.Type == TYPE.ADMIN)
                    return true;
                return false;
            }

        }

        public void AddNewUser()
        {
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Add new User is opened.");
            Window w = new AddUserView();
            w.DataContext = new AddUserViewModel() { Window = w };
            w.ShowDialog();
        }

        #endregion

        #region ViewProfile
        public ICommand ViewProfilInfoCommand
        {
            get;
            private set;
        }

        public void ViewProfile()
        {
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for View and Change User information is opened.");
            Window w = new ProfilInformationView(User);
            w.DataContext = new ProfilInformationViewModel(User, w);
            w.ShowDialog();

        }
        #endregion

        #endregion
        
        #region Telephone
        #region Add Telephone

        public ICommand AddTelephoneCommand
        {
            get;
            private set;
        }

        public void ExecuteAddTelephone(object o = null)
        {

            logHandler.LogManagerLogging(LOGTYPE.INFO, "Add Telephone is clicked.");
            Window w = new AddNewTelephoneView();
            w.DataContext = new AddNewTelephoneViewModel() { Window = w, CurrentUser = User };
            w.ShowDialog();
            try
            {
                FilterTelephones();

            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        #endregion

        #region Change Telephone
        public ICommand ChangeTelephoneCommand
        {
            get;
            private set;
        }

        public void ChangeTelephone()
        {
            CommandHandler.Instance.AddAndExecute(null, SelectedTelephone.Clone());
            

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Change Telephone is opened.");
            Window w = new ChangeTelephoneInfoView(SelectedTelephone);
            w.DataContext = new ChangeTelephoneInfoViewModel(w, SelectedTelephone);
            w.ShowDialog();

        }

        public bool CanManageTelephone
        {
            get
            {
                if (SelectedTelephone != null)
                    return true;
                return false;
            }
        }
        #endregion

        #region Delete Telephone

        public IMyCommand DeleteTelephoneCommand
        {
            get;
            private set;
        }
        public void ExecuteDeleteTelephone(object o = null)
        {
            
            if (o != null)
                SelectedTelephone = (ShopTelephone)o;

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Delete Telephone is opened.");
            if (o == null)
            {
                if (MessageBox.Show("Are you sure you want to delete selected telephone?", "Are you sure?", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        if (!Channel.Instance.telephoneProxy.DeleteTelephone(SelectedTelephone))
                        {
                            MessageBox.Show("already deleted");
                        }
                        else
                        {
                            if (o == null)
                                CommandHandler.Instance.AddAndExecute(DeleteTelephoneCommand, SelectedTelephone);
                        }

                    }
                    catch
                    {
                        logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                        MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                try
                {
                    if (!Channel.Instance.telephoneProxy.DeleteTelephone(SelectedTelephone))
                    {
                        MessageBox.Show("already deleted");
                    }
                    else
                    {
                        if (o == null)
                            CommandHandler.Instance.AddAndExecute(DeleteTelephoneCommand, SelectedTelephone);
                    }

                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                    MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            FilterTelephones();
        }
        public void UnexecuteDeleteTelephone(object o = null)
        {
            
            if (o != null)
                SelectedTelephone = (ShopTelephone)o;
            try
            {
                SelectedTelephone.UserName = User.Username;
                if (!Channel.Instance.telephoneProxy.AddTelephone(SelectedTelephone))
                    MessageBox.Show("Telephone already exists");
                else
                    CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1] = Channel.Instance.telephoneProxy.GetTelephone(SelectedTelephone.Name);
            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            FilterTelephones();
        }
        #endregion

        #region Buy Telephone

        public IMyCommand BuyTelephoneCommand
        {
            get;
            private set;
        }
        public void ExecuteBuyTelephone(object o = null)
        {
            
            if (o != null)
                SelectedTelephone = (ShopTelephone)o;

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Buy Telephone is opened.");
            if (o == null)
            {
                if (MessageBox.Show("Are you sure you want to Buy selected telephone?", "Are you sure?", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        if (!Channel.Instance.telephoneProxy.DeleteTelephone(SelectedTelephone))
                        {
                            MessageBox.Show("already Bought");
                        }
                        else
                        {
                            if (o == null)
                                CommandHandler.Instance.AddAndExecute(BuyTelephoneCommand, SelectedTelephone);
                        }

                    }
                    catch
                    {
                        logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                        MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                try
                {
                    if (!Channel.Instance.telephoneProxy.DeleteTelephone(SelectedTelephone))
                    {
                        MessageBox.Show("already bought");
                    }
                    else
                    {
                        if (o == null)
                            CommandHandler.Instance.AddAndExecute(BuyTelephoneCommand, SelectedTelephone);
                    }

                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                    MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            FilterTelephones();
        }
        public void UnexecuteBuyTelephone(object o = null)
        {
            
            if (o != null)
                SelectedTelephone = (ShopTelephone)o;
            try
            {
                SelectedTelephone.UserName = User.Username;
                if (!Channel.Instance.telephoneProxy.AddTelephone(SelectedTelephone))
                    MessageBox.Show("Telephone already exists");
                else
                    CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1] = Channel.Instance.telephoneProxy.GetTelephone(SelectedTelephone.Name);
            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            FilterTelephones();
        }
        #endregion

        #region Duplicate Telephone
        public IMyCommand DuplicateTelephoneCommand
        {
            get;
            private set;
        }

        public void ExecuteDuplicateTelephone(object o = null)
        {
            
            if (o != null)
                SelectedTelephone = (ShopTelephone)o;

            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Duplicate Telephone is opened.");
            try
            {
                ShopTelephone clone = (ShopTelephone)SelectedTelephone.Clone(); // Prototype pattern

                if (!Channel.Instance.telephoneProxy.AddTelephone(clone))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    if (o == null)
                    {
                        CommandHandler.Instance.AddAndExecute(DuplicateTelephoneCommand, SelectedTelephone);
                    }
                }

            }
            catch
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            FilterTelephones();
        }

        public void UnexecuteDuplicateTelephone(object o = null)
        {
            ExecuteDeleteTelephone(o);
        }

        #endregion

        #region Filter
        public ICommand FilterCommand
        {
            get;
            private set;
        }

        public void FilterTelephones()
        {
            BindingList<ShopTelephone> priceTelephones = null;
            BindingList<ShopTelephone> yearTelephones = null;
            BindingList<ShopTelephone> diagonalTelephones = null;
            BindingList<ShopTelephone> nameTelephones = null;
            BindingList<ShopTelephone> shopTelephones = null;

            if (SelectedPriceCondition != null && !String.IsNullOrWhiteSpace(priceContent) && Regex.IsMatch(priceContent, @"^\d+$"))
                priceTelephones = Channel.Instance.telephoneProxy.GetTelephonesByCondition("Price", SelectedPriceCondition.Name, priceContent);
            else
                priceTelephones = Channel.Instance.telephoneProxy.GetAllTelephones();

            if (SelectedYearCondition != null && !String.IsNullOrWhiteSpace(yearContent) && Regex.IsMatch(yearContent, @"^\d+$"))
                yearTelephones = Channel.Instance.telephoneProxy.GetTelephonesByCondition("Year", SelectedYearCondition.Name, yearContent);
            else
                yearTelephones = Channel.Instance.telephoneProxy.GetAllTelephones();

            if (SelectedDiagonalCondition != null && !String.IsNullOrWhiteSpace(diagonalContent) && Regex.IsMatch(diagonalContent, @"^\d+$"))
                diagonalTelephones = Channel.Instance.telephoneProxy.GetTelephonesByCondition("Diagonal", SelectedDiagonalCondition.Name, diagonalContent);
            else
                diagonalTelephones = Channel.Instance.telephoneProxy.GetAllTelephones();

            if (!String.IsNullOrWhiteSpace(NameContent))
                nameTelephones = Channel.Instance.telephoneProxy.GetTelephonesByCondition("Name", "", NameContent);
            else
                nameTelephones = Channel.Instance.telephoneProxy.GetAllTelephones();

            if (SelectedShop != null)
                shopTelephones = Channel.Instance.telephoneProxy.GetTelephonesByCondition("Shop", "", SelectedShop.Name);
            else
                shopTelephones = Channel.Instance.telephoneProxy.GetAllTelephones();

            BindingList<ShopTelephone> ret = new BindingList<ShopTelephone>();
            priceTelephones.ToList().ForEach(p => {
                if (ret.Where(y => y.Id == p.Id).Count() == 0 && yearTelephones.Where(y => y.Id == p.Id).Count() != 0 && diagonalTelephones.Where(y => y.Id == p.Id).Count() != 0 && nameTelephones.Where(y => y.Id == p.Id).Count() != 0 && shopTelephones.Where(y => y.Id == p.Id).Count() != 0)
                    ret.Add(p);
            });

            yearTelephones.ToList().ForEach(p => {
                if (ret.Where(y => y.Id == p.Id).Count() == 0 && priceTelephones.Where(y => y.Id == p.Id).Count() != 0 && diagonalTelephones.Where(y => y.Id == p.Id).Count() != 0 && nameTelephones.Where(y => y.Id == p.Id).Count() != 0 && shopTelephones.Where(y => y.Id == p.Id).Count() != 0)
                    ret.Add(p);
            });

            diagonalTelephones.ToList().ForEach(p => {
                if (ret.Where(y => y.Id == p.Id).Count() == 0 && yearTelephones.Where(y => y.Id == p.Id).Count() != 0 && priceTelephones.Where(y => y.Id == p.Id).Count() != 0 && nameTelephones.Where(y => y.Id == p.Id).Count() != 0 && shopTelephones.Where(y => y.Id == p.Id).Count() != 0)
                    ret.Add(p);
            });

            nameTelephones.ToList().ForEach(p => {
                if (ret.Where(y => y.Id == p.Id).Count() == 0 && yearTelephones.Where(y => y.Id == p.Id).Count() != 0 && priceTelephones.Where(y => y.Id == p.Id).Count() != 0 && diagonalTelephones.Where(y => y.Id == p.Id).Count() != 0 && shopTelephones.Where(y => y.Id == p.Id).Count() != 0)
                    ret.Add(p);
            });

            shopTelephones.ToList().ForEach(p => {
                if (ret.Where(y => y.Id == p.Id).Count() == 0 && yearTelephones.Where(y => y.Id == p.Id).Count() != 0 && priceTelephones.Where(y => y.Id == p.Id).Count() != 0 && nameTelephones.Where(y => y.Id == p.Id).Count() != 0 && diagonalTelephones.Where(y => y.Id == p.Id).Count() != 0)
                    ret.Add(p);
            });

            Telephones = ret;

        }
        #endregion

        #region Clear Conditions

        public ICommand ClearCommand
        {
            get;
            private set;
        }
        public void ClearConditions()
        {
            SelectedShop = null;
            NameContent = null;
            PriceContent = null;
            SelectedPriceCondition = null;
            YearContent = null;
            SelectedYearCondition = null;
            DiagonalContent = null;
            SelectedDiagonalCondition = null;
            SelectedTelephone = null;
            Shops = Channel.Instance.shopProxy.GetShops();
            Telephones = Channel.Instance.telephoneProxy.GetAllTelephones();
            PriceConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "More" }, new Common.Model.Condition() { Name = "Less" }, };
            YearConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "Before" }, new Common.Model.Condition() { Name = "After" }, };
            DiagonalConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "More" }, new Common.Model.Condition() { Name = "Less" }, };
            Condition = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "Name" }, new Common.Model.Condition() { Name = "Price" }, new Common.Model.Condition() { Name = "Year" }, new Common.Model.Condition() { Name = "Diagonal" }, };
        }

        #endregion

        #region Refresh
        public ICommand RefreshCommand
        {
            get;
            private set;
        }
        public void Refresh()
        {
            FilterTelephones();
            TableShops = Channel.Instance.shopProxy.GetShops();
        }

        #endregion

        #endregion

        #region Shop
        #region Add Shop

        public ICommand AddShopCommand
        {
            get;
            private set;
        }

        public void AddShop()
        {
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Add Shop is opened.");
            Window w = new AddNewShopView();
            w.DataContext = new AddNewShopViewModel() { Window = w, CurrentUser = User };
            w.ShowDialog();
           

        }

        #endregion

        #region Change Shop

        public ICommand ChangeShopCommand
        {
            get;
            private set;
        }

        public bool CanManageShop
        {
            get
            {
                if (SelectedShopTable != null)
                    return true;
                return false;
            }
        }

        public void ChangeShop()
        {
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Change Shop is opened.");
            Window w = new ChangeShopInfoVIew(SelectedShopTable);
            w.DataContext = new ChangeShopInfoViewModel(w, SelectedShopTable);
            w.ShowDialog();
            //Telephones = Channel.Instance.telephoneProxy.GetAllTelephones();
        }

        #endregion

        #region Delete Shop with all telephones in it

        public ICommand DeleteShopCommand
        {
            get;
            private set;
        }

        public void DeleteShopWithTelephones()
        {
            
            logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Dialog for Delete Shop is opened.");
            if (MessageBox.Show("Are you sure you want to delete shop \"" + SelectedShopTable.Name + "\"?", "Are you sure?", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                
                try
                {
                    Telephones = Channel.Instance.telephoneProxy.GetTelephones(SelectedShopTable.Name);
                    foreach (var t in Telephones)
                    {
                        try
                        {
                            Channel.Instance.telephoneProxy.DeleteTelephone(t);
                        }
                        catch
                        {
                            logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                            MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    Channel.Instance.shopProxy.DeleteShop(SelectedShopTable);
                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                    MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                TableShops = Channel.Instance.shopProxy.GetShops();
                Shops = Channel.Instance.shopProxy.GetShops();
                FilterTelephones();
            }
        }

        #endregion
        #endregion

        #region Undo/Redo

        #region Undo

        public ICommand UndoCommand
        {
            get;
            private set;
        }

        public bool CanUndo
        {
            get
            {
                if (CommandHandler.Instance.undoCommands.Count != 0)
                    return true;
                else
                    return false;
            }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                CommandHandler.Instance.Undo();
            }
        }
        #endregion

        #region Redo

        public ICommand RedoCommand
        {
            get;
            private set;
        }

        public bool CanRedo
        {
            get
            {
                if (CommandHandler.Instance.redoCommands.Count != 0)
                    return true;
                else
                    return false;
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                CommandHandler.Instance.Redo();
            }
        }

        #endregion

        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        
    }
}
