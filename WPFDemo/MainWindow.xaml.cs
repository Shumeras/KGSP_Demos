using System.Windows;
using WPFDemo.ViewModels;
using WPFDemo.Converters;
using System;
using WPFDemo.Commands;
using System.Windows.Navigation;
using System.Windows.Controls;
using WPFDemo.Pages;
using System.ComponentModel;
using System.Windows.Media.Animation;
using System.Threading;
using System.Threading.Tasks;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (o, args) => { };

        public ReportPage ReportPage { get;} = new ReportPage();
        public DataPage DataPage { get; } = new DataPage();

        public Page CurrentPage { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            CurrentPage = ReportPage;
            DataContext = this;
        }


        private void ReportPageButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentPage = ReportPage;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentPage"));
        }

        private void DataPageButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentPage = DataPage;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentPage"));
        }
    }
}
