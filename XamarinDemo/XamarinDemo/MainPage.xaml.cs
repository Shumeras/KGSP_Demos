using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModels;

namespace XamarinDemo
{

    public partial class MainPage : TabbedPage
    {
        public ShopingPageViewModel ShopingPageViewModel { get; set; }
        public CartPageViewModel CartPageViewModel { get; set; }

        public MainPage()
        {
            ShopingPageViewModel = new ShopingPageViewModel();
            CartPageViewModel = new CartPageViewModel();

            foreach (var si in ShopingPageViewModel.ShopItems)
                si.PropertyChanged += UpdateCart;
            
            InitializeComponent();
            BindingContext = this;
        }

        private void UpdateCart(object obj, PropertyChangedEventArgs args)
        {
            var target = (ShopItemViewModel)obj;

            if(CartPageViewModel.CartItems.Contains(target))
            {
                if (target.SelectedCount == 0)
                {
                    CartPageViewModel.CartItems.Remove(target);
                    CartPageViewModel.BuyCommand.ChangeCanExecute();
                    CartPageViewModel.ClearCommand.ChangeCanExecute();
                }
            }
            else
            {
                if (target.SelectedCount > 0)
                {
                    CartPageViewModel.CartItems.Add(target);
                    CartPageViewModel.BuyCommand.ChangeCanExecute();
                    CartPageViewModel.ClearCommand.ChangeCanExecute();
                }
            }

        }
    }
}
