using System.Windows;

namespace Battleships
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
            SetSettings();
        }
        void SetSettings()
        {
            Height = Settings.height;
            Width = Settings.width;
            if(Settings.fullscreen)
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
    }
}
