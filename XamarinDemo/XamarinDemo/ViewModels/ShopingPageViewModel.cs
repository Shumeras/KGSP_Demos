using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XamarinDemo.ViewModels
{
    public class ShopingPageViewModel : INotifyPropertyChanged
    {
        #region Private members
        private string searchText = "";
        private ObservableCollection<ShopItemViewModel> shopItems = new ObservableCollection<ShopItemViewModel> {
            new ShopItemViewModel{
                Id=Guid.NewGuid().ToString(),
                Name="Cheese",
                Price=10.0f,
                ImgDir="XamarinDemo.images.cheese.png",
                Description="Cheesy",
                SelectedCount = 0
            },
            new ShopItemViewModel{
                Id=Guid.NewGuid().ToString(),
                Name="Crackers",
                Price=5.0f,
                ImgDir="XamarinDemo.images.crackers.jpg",
                Description="Crunchy",
                SelectedCount = 0
            },
            new ShopItemViewModel{
                Id=Guid.NewGuid().ToString(),
                Name="Cup Of Tea",
                Price=2.0f,
                ImgDir="XamarinDemo.images.cup_of_tea.jpeg",
                Description="Steamy",
                SelectedCount = 0
            },
            new ShopItemViewModel{
                Id=Guid.NewGuid().ToString(),
                Name="Grapes",
                Price=20.0f,
                ImgDir="XamarinDemo.images.grapes.png",
                Description="Fancy",
                SelectedCount = 0
            }
        };
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;

        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SearchText"));
                PropertyChanged(this, new PropertyChangedEventArgs("ShopItems"));
            }
        }

        public ObservableCollection<ShopItemViewModel> ShopItems
        {
            get => new ObservableCollection<ShopItemViewModel> (shopItems.Where((si) => si.Name.ToUpper().Contains(searchText.ToUpper())));
        }           
    }
}
