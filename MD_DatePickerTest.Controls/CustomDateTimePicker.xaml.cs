using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MD_DatePickerTest.Controls
{
    /// <summary>
    /// Interaction logic for DateTimePicker.xaml
    /// </summary>
    public partial class CustomDateTimePicker : UserControl
    {
        public static DependencyProperty SelectedDateTimeProperty =
        DependencyProperty.Register("SelectedDateTime", typeof(DateTime), typeof(CustomDateTimePicker));

        public DateTime SelectedDateTime
        {
            get => (DateTime)GetValue(SelectedDateTimeProperty);
            set => SetValue(SelectedDateTimeProperty, value);
        }

        public CustomDateTimePicker()
        {
            InitializeComponent();

            SelectedDateTime = DateTime.Now;
        }
    }
}
