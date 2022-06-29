using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battleships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //public void CloseWindow() => ExitButtonClicked();

        void PlayButtonClicked(object sender, RoutedEventArgs e)
        {
            Game gameWindow = new Game();
            gameWindow.ShowDialog();
        }
        void OptionsButtonClicked(object sender, RoutedEventArgs e)
        {
            Options optionsWindow = new Options();
            optionsWindow.ShowDialog();
        }
        void ExitButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
