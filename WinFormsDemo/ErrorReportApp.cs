using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class ErrorReportApp : Form
    {
        public ErrorReportApp()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            ErrorIdTextBox.Text = Guid.NewGuid().ToString();
            
            UserTextBox.Text = "";
            RegistrationDatePicker.Value = DateTime.Now;
            
            TitleTextBox.Text = "";

            BugRadioButton.Checked = true;
            DocumentationIssueRadioButton.Checked = false;
            PerformanceIssueRadioButton.Checked = false;
            NoticeIssueRadioButton.Checked = false;

            DescriptionTextBox.Text = "";

            UrgentCheckBox.Checked = false;

            UserTextBox.BackColor = Color.White;
            TitleTextBox.BackColor = Color.White;
            DescriptionTextBox.BackColor = Color.White;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure you want to clear?", "Notice", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
                Clear();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                UserTextBox.Focus();
                UserTextBox.BackColor = Color.LightPink;
                return;
            }

            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                TitleTextBox.Focus();
                TitleTextBox.BackColor = Color.LightPink;
                return;
            }

            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            {
                DescriptionTextBox.Focus();
                DescriptionTextBox.BackColor = Color.LightPink;
                return;
            }

            ReportData rd = new ReportData
            {
                Id = ErrorIdTextBox.Text,
                User = UserTextBox.Text,
                DateTime = RegistrationDatePicker.Value,
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                Urgent = UrgentCheckBox.Checked,
                Type = BugRadioButton.Checked ? ReportType.BUG :
                    DocumentationIssueRadioButton.Checked ? ReportType.DOCUMENTATION :
                        PerformanceIssueRadioButton.Checked ? ReportType.PERFORMANCE : ReportType.NOTICE
            };

            Clear();

            DescriptionTextBox.Text = System.Text.Json.JsonSerializer.Serialize<ReportData>(rd);
        }
    }
}
