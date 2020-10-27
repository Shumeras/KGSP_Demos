using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinDemo.ViewModels
{
    public class ShopItemViewModel : INotifyPropertyChanged
    {
        #region private fields

        private string id;
        private string name;
        private string description;
        private float price;
        private string imgDir;
        private int selectedCount;
        private Command clearCommand;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged = (o, args) => { };

        public string Id
        {
            get => id;
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Description"));
            }
        }
        public float Price
        {
            get => price;
            set
            {
                price = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }
        public string ImgDir
        {
            get => imgDir;
            set
            {
                imgDir = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ImgDir"));
            }
        }
        public int SelectedCount
        {
            get => selectedCount;
            set
            {
                selectedCount = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedCount"));
            }
        }

        public Command ClearCommand 
        { 
            get
            {
                if (clearCommand == null)
                    clearCommand = new Command(
                        (param) => SelectedCount = 0,
                        (param) => SelectedCount > 0
                    );

                return clearCommand;
            }
                    
        }

    }
}
