using Client.ClientServerChannel;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Adition
{
    public class ContentHandler
    {
        #region Fields
        static LogHandler log = LogHandler.Instance;
        #endregion

        #region Operations
        public static void StartContent()
        {
            log.MainWindowViewModel.PriceConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "More" }, new Common.Model.Condition() { Name = "Less" }, };
            log.MainWindowViewModel.YearConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "Before" }, new Common.Model.Condition() { Name = "After" }, };
            log.MainWindowViewModel.DiagonalConditions = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "More" }, new Common.Model.Condition() { Name = "Less" }, };
            log.MainWindowViewModel.Logging = new BindingList<ClientLog>();
            log.MainWindowViewModel.TableShops = Channel.Instance.shopProxy.GetShops();
            log.MainWindowViewModel.SelectedShop = null;
            log.MainWindowViewModel.SelectedTelephone = null;
            log.MainWindowViewModel.Shops = Channel.Instance.shopProxy.GetShops();
            log.MainWindowViewModel.Telephones = Channel.Instance.telephoneProxy.GetAllTelephones();
            log.MainWindowViewModel.Condition = new List<Common.Model.Condition>() { new Common.Model.Condition() { Name = "Name" }, new Common.Model.Condition() { Name = "Price" }, new Common.Model.Condition() { Name = "Year" }, new Common.Model.Condition() { Name = "Diagonal" }, };

        }

        public static void Refresh()
        {
            log.MainWindowViewModel.TableShops = Channel.Instance.shopProxy.GetShops();
            log.MainWindowViewModel.Shops = Channel.Instance.shopProxy.GetShops();
            log.MainWindowViewModel.FilterTelephones();
        }
        #endregion
    }
}
