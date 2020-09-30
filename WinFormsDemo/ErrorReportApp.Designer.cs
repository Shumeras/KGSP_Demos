namespace WinFormsDemo
{
    partial class ErrorReportApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorIdLabel = new System.Windows.Forms.Label();
            this.ErrorIdTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RegistrationDateLabel = new System.Windows.Forms.Label();
            this.IssueTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.IssueTable = new System.Windows.Forms.TableLayoutPanel();
            this.BugRadioButton = new System.Windows.Forms.RadioButton();
            this.DocumentationIssueRadioButton = new System.Windows.Forms.RadioButton();
            this.PerformanceIssueRadioButton = new System.Windows.Forms.RadioButton();
            this.NoticeIssueRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UrgentCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.IssueTypeGroupBox.SuspendLayout();
            this.IssueTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIdLabel
            // 
            this.ErrorIdLabel.AutoSize = true;
            this.ErrorIdLabel.Location = new System.Drawing.Point(9, 13);
            this.ErrorIdLabel.Name = "ErrorIdLabel";
            this.ErrorIdLabel.Size = new System.Drawing.Size(45, 15);
            this.ErrorIdLabel.TabIndex = 0;
            this.ErrorIdLabel.Text = "Error Id";
            // 
            // ErrorIdTextBox
            // 
            this.ErrorIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorIdTextBox.Location = new System.Drawing.Point(13, 32);
            this.ErrorIdTextBox.Name = "ErrorIdTextBox";
            this.ErrorIdTextBox.ReadOnly = true;
            this.ErrorIdTextBox.Size = new System.Drawing.Size(397, 23);
            this.ErrorIdTextBox.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(9, 67);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(60, 15);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Username";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(12, 85);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.PlaceholderText = "User registering issue";
            this.UserTextBox.Size = new System.Drawing.Size(179, 23);
            this.UserTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 125);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(29, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 144);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PlaceholderText = "Give a title to your issue";
            this.TitleTextBox.Size = new System.Drawing.Size(397, 23);
            this.TitleTextBox.TabIndex = 1;
            // 
            // RegistrationDatePicker
            // 
            this.RegistrationDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationDatePicker.Location = new System.Drawing.Point(209, 85);
            this.RegistrationDatePicker.Name = "RegistrationDatePicker";
            this.RegistrationDatePicker.Size = new System.Drawing.Size(200, 23);
            this.RegistrationDatePicker.TabIndex = 2;
            // 
            // RegistrationDateLabel
            // 
            this.RegistrationDateLabel.AutoSize = true;
            this.RegistrationDateLabel.Location = new System.Drawing.Point(206, 67);
            this.RegistrationDateLabel.Name = "RegistrationDateLabel";
            this.RegistrationDateLabel.Size = new System.Drawing.Size(96, 15);
            this.RegistrationDateLabel.TabIndex = 0;
            this.RegistrationDateLabel.Text = "Registration date";
            // 
            // IssueTypeGroupBox
            // 
            this.IssueTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueTypeGroupBox.Controls.Add(this.IssueTable);
            this.IssueTypeGroupBox.Location = new System.Drawing.Point(9, 174);
            this.IssueTypeGroupBox.Name = "IssueTypeGroupBox";
            this.IssueTypeGroupBox.Size = new System.Drawing.Size(400, 57);
            this.IssueTypeGroupBox.TabIndex = 3;
            this.IssueTypeGroupBox.TabStop = false;
            this.IssueTypeGroupBox.Text = "Type of issue";
            // 
            // IssueTable
            // 
            this.IssueTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueTable.ColumnCount = 4;
            this.IssueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IssueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IssueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IssueTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IssueTable.Controls.Add(this.BugRadioButton, 0, 0);
            this.IssueTable.Controls.Add(this.DocumentationIssueRadioButton, 1, 0);
            this.IssueTable.Controls.Add(this.PerformanceIssueRadioButton, 2, 0);
            this.IssueTable.Controls.Add(this.NoticeIssueRadioButton, 3, 0);
            this.IssueTable.Location = new System.Drawing.Point(3, 22);
            this.IssueTable.Name = "IssueTable";
            this.IssueTable.RowCount = 1;
            this.IssueTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IssueTable.Size = new System.Drawing.Size(390, 26);
            this.IssueTable.TabIndex = 0;
            // 
            // BugRadioButton
            // 
            this.BugRadioButton.AutoSize = true;
            this.BugRadioButton.Location = new System.Drawing.Point(3, 3);
            this.BugRadioButton.Name = "BugRadioButton";
            this.BugRadioButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BugRadioButton.Size = new System.Drawing.Size(61, 19);
            this.BugRadioButton.TabIndex = 0;
            this.BugRadioButton.TabStop = true;
            this.BugRadioButton.Text = "Bug";
            this.BugRadioButton.UseVisualStyleBackColor = true;
            // 
            // DocumentationIssueRadioButton
            // 
            this.DocumentationIssueRadioButton.AutoSize = true;
            this.DocumentationIssueRadioButton.Location = new System.Drawing.Point(70, 3);
            this.DocumentationIssueRadioButton.Name = "DocumentationIssueRadioButton";
            this.DocumentationIssueRadioButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.DocumentationIssueRadioButton.Size = new System.Drawing.Size(123, 19);
            this.DocumentationIssueRadioButton.TabIndex = 1;
            this.DocumentationIssueRadioButton.TabStop = true;
            this.DocumentationIssueRadioButton.Text = "Documentation";
            this.DocumentationIssueRadioButton.UseVisualStyleBackColor = true;
            // 
            // PerformanceIssueRadioButton
            // 
            this.PerformanceIssueRadioButton.AutoSize = true;
            this.PerformanceIssueRadioButton.Location = new System.Drawing.Point(199, 3);
            this.PerformanceIssueRadioButton.Name = "PerformanceIssueRadioButton";
            this.PerformanceIssueRadioButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.PerformanceIssueRadioButton.Size = new System.Drawing.Size(108, 19);
            this.PerformanceIssueRadioButton.TabIndex = 2;
            this.PerformanceIssueRadioButton.TabStop = true;
            this.PerformanceIssueRadioButton.Text = "Performance";
            this.PerformanceIssueRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoticeIssueRadioButton
            // 
            this.NoticeIssueRadioButton.AutoSize = true;
            this.NoticeIssueRadioButton.Location = new System.Drawing.Point(313, 3);
            this.NoticeIssueRadioButton.Name = "NoticeIssueRadioButton";
            this.NoticeIssueRadioButton.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.NoticeIssueRadioButton.Size = new System.Drawing.Size(75, 19);
            this.NoticeIssueRadioButton.TabIndex = 3;
            this.NoticeIssueRadioButton.TabStop = true;
            this.NoticeIssueRadioButton.Text = "Notice";
            this.NoticeIssueRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-54, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(-51, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Give a title to your issue";
            this.textBox2.Size = new System.Drawing.Size(397, 23);
            this.textBox2.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(9, 236);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 255);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PlaceholderText = "Describe your issue";
            this.DescriptionTextBox.Size = new System.Drawing.Size(397, 223);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // UrgentCheckBox
            // 
            this.UrgentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UrgentCheckBox.AutoSize = true;
            this.UrgentCheckBox.Location = new System.Drawing.Point(14, 488);
            this.UrgentCheckBox.Name = "UrgentCheckBox";
            this.UrgentCheckBox.Size = new System.Drawing.Size(62, 19);
            this.UrgentCheckBox.TabIndex = 4;
            this.UrgentCheckBox.Text = "Urgent";
            this.UrgentCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Location = new System.Drawing.Point(12, 519);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 27);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(140, 519);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(269, 27);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ErrorReportApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 556);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UrgentCheckBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.IssueTypeGroupBox);
            this.Controls.Add(this.RegistrationDateLabel);
            this.Controls.Add(this.RegistrationDatePicker);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.ErrorIdTextBox);
            this.Controls.Add(this.ErrorIdLabel);
            this.Name = "ErrorReportApp";
            this.Text = "Report Error";
            this.IssueTypeGroupBox.ResumeLayout(false);
            this.IssueTable.ResumeLayout(false);
            this.IssueTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorIdLabel;
        private System.Windows.Forms.TextBox ErrorIdTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker RegistrationDatePicker;
        private System.Windows.Forms.Label RegistrationDateLabel;
        private System.Windows.Forms.GroupBox IssueTypeGroupBox;
        private System.Windows.Forms.TableLayoutPanel IssueTable;
        private System.Windows.Forms.RadioButton BugRadioButton;
        private System.Windows.Forms.RadioButton DocumentationIssueRadioButton;
        private System.Windows.Forms.RadioButton PerformanceIssueRadioButton;
        private System.Windows.Forms.RadioButton NoticeIssueRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.CheckBox UrgentCheckBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}

