using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModels;

namespace XamarinDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            Resources.Add("xImg", ImageSource.FromResource("XamarinDemo.images.round_clear_white_24dp.png"));
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button == null) return;

            double Y = button.TranslationY;

#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            button.RotateTo(360, 500);
            button.ScaleTo(0.5, 500);
            await button.TranslateTo(button.X, button.TranslationY - 200, 500);
            button.ScaleTo(1, 500);
            await button.TranslateTo(button.X, Y, 500, Easing.BounceOut);
            button.RotateTo(0, 0);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }
    }
}