using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPFDemo.DataModels
{
    public enum IssueType
    {
        BUG,
        DOCUMENTATION,
        PERFORMANCE,
        NOTICE
    }

    public class ErrorReportDataModel
    {
        public string Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public IssueType IssueType { get; set; }
    }
}
