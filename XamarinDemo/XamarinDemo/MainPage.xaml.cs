using System;
using System.Collections.Generic;
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

        public ShopingPageViewModel PageViewModel { get; set; }

        public MainPage()
        {
            PageViewModel = new ShopingPageViewModel();

            InitializeComponent();
            BindingContext = PageViewModel;
        }
    }
}
