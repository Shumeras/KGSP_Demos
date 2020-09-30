using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsDemo
{
    enum ReportType
    {
        BUG,
        DOCUMENTATION,
        PERFORMANCE,
        NOTICE
    }


    struct ReportData
    {
        public string Id { get; set; }
        public string User { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public ReportType Type { get; set; }
        public string Description { get; set; }
        public bool Urgent { get; set; }
    }
}
