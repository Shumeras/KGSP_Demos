using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using WPFDemo.DataModels;

namespace WPFDemo.Pages
{
    /// <summary>
    /// Interaction logic for DataPage.xaml
    /// </summary>
    public partial class DataPage : Page, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = (o, args) => { };
        
        public ObservableCollection<ErrorReportDataModel> DataList { get; private set; } = new ObservableCollection<ErrorReportDataModel>();

        public DataPage()
        {
            DataList.Add(
                new ErrorReportDataModel
                {
                    Title = "This is some long title name",
                    User = "John Smith",
                    Date = DateTime.Now
                });

            DataContext = this;
            InitializeComponent();
        }

        public void AddListItem(ErrorReportDataModel erdm)
        {
            DataList.Add(erdm);
            PropertyChanged(this, new PropertyChangedEventArgs("DataList"));
        }

    }
}
