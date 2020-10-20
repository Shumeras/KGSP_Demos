using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using WPFDemo.DataModels;

namespace WPFDemo.Converters
{
    [ValueConversion(typeof(bool), typeof(IssueType), ParameterType = typeof(IssueType))]
    public class RadioButtonToIssueTypeConverter : IValueConverter
    {
        #region Singleton interface
        private RadioButtonToIssueTypeConverter() { }

        public static RadioButtonToIssueTypeConverter Instance { get; } = new RadioButtonToIssueTypeConverter();

        #endregion //Singleton interface

        public /*bool*/ object Convert(/*IssueType*/ object value, Type targetType, /*IssueType*/ object parameter, CultureInfo culture)
        {
            return value.Equals(parameter);
        }

        public /*IssueType*/ object ConvertBack(/*bool*/object value, Type targetType, /*IssueType*/ object parameter, CultureInfo culture)
        {
            return (bool)value ? parameter : Binding.DoNothing;
        }
    }
}
