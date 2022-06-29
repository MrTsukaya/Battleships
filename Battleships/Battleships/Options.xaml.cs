using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Battleships
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
            SetSettings();
        }
        void SetSettings()
        {
            this.Height = Settings.height;
            this.Width = Settings.width;
            if (Settings.fullscreen)
            {
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
            else
            {
                WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
        }
        void Options_Loaded(object sender, RoutedEventArgs e)
        {
            DependencyPropertyDescriptor dpd = DependencyPropertyDescriptor.FromProperty(ComboBox.TextProperty, typeof(ComboBox));
            dpd.AddValueChanged(comboBoxResolutionSize, OptionsSettings_SelectionChanged);
        }
        public void OptionsSettings_SelectionChanged(object sender, EventArgs e)
        {
            string? selectedValue = comboBoxResolutionSize.Text;
            Debug.WriteLine($"Resolution: {selectedValue}");
        }
    }
}
