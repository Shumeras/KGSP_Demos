using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinDemo.ViewModels
{
    public class CartPageViewModel
    {
        #region private

        private Command clearCommand;
        private Command buyCommand;


        #endregion

        public bool CanCommand => CartItems.Count > 0;

        public ObservableCollection<ShopItemViewModel> CartItems { get; set; } = new ObservableCollection<ShopItemViewModel>();

        public Command ClearCommand
        {
            get
            {
                if (clearCommand == null)
                    clearCommand = new Command(
                        (param) =>
                        {
                            foreach (var item in CartItems.ToArray())
                                item.SelectedCount = 0;
                        },
                        (param) => CanCommand
                    ) ;


                return clearCommand;
            }
        }
        public Command BuyCommand
        {
            get
            {
                if (buyCommand == null)
                    buyCommand = new Command(
                        (param) =>
                        {
                            //Pass the item list to Model;

                            ClearCommand.Execute(param);
                        },
                        (param) => CanCommand
                    );


                return buyCommand;
            }

        }
    }
}
