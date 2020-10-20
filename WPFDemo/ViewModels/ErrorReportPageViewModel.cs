using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPFDemo.DataModels;
using System.Reflection;
using WPFDemo.Commands;

namespace WPFDemo.ViewModels
{
    public class ErrorReportPageViewModel : INotifyPropertyChanged
    {

        #region private membmers
        
        private IssueType issueType;
        private string id;
        private string user;
        private DateTime date;
        private string title;
        private string description;
        private bool isUrgent;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged = (o, e) => { };
        public string Id
        {
            get => id;
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        public string User
        {
            get => user;
            set
            {
                user = value;
                PropertyChanged(this, new PropertyChangedEventArgs("User"));
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Date"));
            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Title"));
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
        public bool IsUrgent
        {
            get => isUrgent;
            set 
            {
                isUrgent = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsUrgent"));
            }
        }
        public IssueType IssueType
        {
            get => issueType;
            set
            {
                issueType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IssueType"));
            }
        }

        public ICommand ClearCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
    }
}
