using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFDemo.Commands;
using WPFDemo.DataModels;
using WPFDemo.ViewModels;

namespace WPFDemo.Pages
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        ErrorReportPageViewModel data = new ErrorReportPageViewModel();

        public ReportPage()
        {
            InitializeComponent();

            DataContext = data;

            data.ClearCommand = new RelayCommand(Clear);
            data.SubmitCommand = new RelayCommand(Submit);
            Clear();
        }


        private void Clear(object obj = null)
        {
            data.Id = Guid.NewGuid().ToString();
            data.User = "";
            data.Date = DateTime.Now;
            data.Title = "";
            data.Description = "";
            data.IsUrgent = false;
            data.IssueType = DataModels.IssueType.BUG;
        }

        private void Submit(object obj = null)
        {
            GetParent<MainWindow>(this).DataPage.AddListItem(
                new ErrorReportDataModel{
                    Id = data.Id,
                    User = data.User,
                    Date = data.Date,
                    Title = data.Title,
                    Description = data.Description,
                    IsUrgent = data.IsUrgent,
                    IssueType = data.IssueType
                }) ;

            Clear();            
        }

        private T GetParent<T>(DependencyObject obj)
           where T: DependencyObject
        {
            if (obj == null) return null;
            
            obj = VisualTreeHelper.GetParent(obj);

            if (obj is T t) return t;
           
            return GetParent<T>(obj); 
        }

        
    }
}
