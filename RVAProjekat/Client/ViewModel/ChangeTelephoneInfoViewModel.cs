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
    class ChangeTelephoneInfoViewModel
    {
        #region Fields
        LogHandler logHandler;

        public Window Window { get; set; }
        public ShopTelephone CurrentTelephone { get; set; }
        #endregion

        #region Constructor
        public ChangeTelephoneInfoViewModel(Window w, ShopTelephone telephone)
        {
            logHandler = LogHandler.Instance;
            Window = w;
            CurrentTelephone = telephone;
            ChangeThisTelephoneCommand = new ChangeThisTelephoneCommand(this);
        }
        #endregion

        #region Change Telephone
        public IMyCommand ChangeThisTelephoneCommand
        {
            get;
            private set;
        }
        public bool CanChangeTelephone
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(CurrentTelephone.Name) && !String.IsNullOrWhiteSpace(CurrentTelephone.Year.ToString()) && !String.IsNullOrWhiteSpace(CurrentTelephone.Diagonal.ToString()) && !String.IsNullOrWhiteSpace(CurrentTelephone.Price.ToString()) && !String.IsNullOrWhiteSpace(CurrentTelephone.Description) && CurrentTelephone.Diagonal > 0 && CurrentTelephone.Year > 1900 && CurrentTelephone.Year <= DateTime.Now.Year && CurrentTelephone.Price > 0 && !String.IsNullOrWhiteSpace(CurrentTelephone.ShopName))
                    return true;
                else
                    return false;
            }
        }

        public void ExecuteChangeTelephone(object o = null)
        {
            Context context = new Context(CurrentTelephone);
            if (!context.ChackValidation())
                return;
            if (o == null)
            {
                if (CanChangeTelephone)
                {
                    try
                    {
                        logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Change Telephone is clicked.");
                        CommandHandler.Instance.undoCommands[CommandHandler.Instance.undoCommands.Count - 1] = ChangeThisTelephoneCommand;

                        if (!Channel.Instance.telephoneProxy.UpdateTelephone(CurrentTelephone))
                        {
                            if (MessageBox.Show("Telephone is deleted or modified. Do you want to overwrite changes?", "Conflict", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                logHandler.LogManagerLogging(Enums.LOGTYPE.WARN, "Telephone is modified.");
                                Channel.Instance.telephoneProxy.UpdateNewTelephone(CurrentTelephone);
                                ((ShopTelephone)CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1]).LastModified = Channel.Instance.telephoneProxy.GetTelephone(CurrentTelephone.Name).LastModified;

                            }

                        }
                        else
                        {
                            ((ShopTelephone)CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1]).LastModified = Channel.Instance.telephoneProxy.GetTelephone(CurrentTelephone.Name).LastModified;

                        }
                        Window.Close();

                    }
                    catch
                    {
                        logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                        MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Fields can not be empty of negative! Please, fill the content.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                CurrentTelephone = (ShopTelephone)o;
                CommandHandler.Instance.redoObjects[CommandHandler.Instance.redoObjects.Count - 1] = Channel.Instance.telephoneProxy.GetTelephone(((ShopTelephone)o).Name);
                try
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Change Telephone is clicked.");

                    if (!Channel.Instance.telephoneProxy.UpdateTelephone(CurrentTelephone))
                    {
                        if (MessageBox.Show("Telephone is deleted or modified. Do you want to overwrite changes?", "Conflict", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            logHandler.LogManagerLogging(Enums.LOGTYPE.WARN, "Telephone is modified.");
                            Channel.Instance.telephoneProxy.UpdateNewTelephone(CurrentTelephone);



                        }
                    }
                    ((ShopTelephone)CommandHandler.Instance.redoObjects[CommandHandler.Instance.redoObjects.Count - 1]).LastModified = Channel.Instance.telephoneProxy.GetTelephone(CurrentTelephone.Name).LastModified;
                    Window.Close();

                }
                catch
                {
                    logHandler.LogManagerLogging(Enums.LOGTYPE.FATAL, "Connection failed");
                    MessageBox.Show("Connection failed", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            ContentHandler.Refresh();
        }

        public void UnexecuteChangeTelephone(object o = null)
        {
            CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1] = Channel.Instance.telephoneProxy.GetTelephone(((ShopTelephone)o).Name);

            if (o != null)
                CurrentTelephone = (ShopTelephone)o;
            try
            {
                logHandler.LogManagerLogging(Enums.LOGTYPE.INFO, "Change Telephone is clicked.");

                if (!Channel.Instance.telephoneProxy.UpdateTelephone(CurrentTelephone))
                {
                    if (MessageBox.Show("Telephone is deleted or modified. Do you want to overwrite changes?", "Conflict", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        logHandler.LogManagerLogging(Enums.LOGTYPE.WARN, "Telephone is modified.");
                        Channel.Instance.telephoneProxy.UpdateNewTelephone(CurrentTelephone);
                    }
                }
                ((ShopTelephone)CommandHandler.Instance.undoObjects[CommandHandler.Instance.undoObjects.Count - 1]).LastModified = Channel.Instance.telephoneProxy.GetTelephone(CurrentTelephone.Name).LastModified;
                Window.Close();

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
