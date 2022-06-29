using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Battleships
{
    public class OptionsSettings : ObservableObject
    {
        public OptionsSettings()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Debug.WriteLine($"Settings: \n{Settings.fullscreen}\n{Settings.height}\n{Settings.width}\n{Settings.volume}");
                    Thread.Sleep(2000);
                }
            });
        }

        private string _resolution;
        private bool _fullscreen;
        private int _volume;

        public string SetResolution
        {
            get { return _resolution; }
            set
            {
                if (SetResolution != value)
                {
                    _resolution = value;
                    OnPropertyChanged("SetResolution");
                    ConvertResolution(value);
                }
            }
        }
        public bool SetFullscreen
        {
            get { return _fullscreen; }
            set
            {
                if (SetFullscreen != value)
                {
                    _fullscreen = value;
                    OnPropertyChanged("SetFullscreen");
                    UpdateFullScreen();
                }
            }
        }
        public int SetVolume
        {
            get { return _volume; }
            set
            {
                if (SetVolume != value)
                {
                    _volume = value;
                    OnPropertyChanged("SetVolume");
                    UpdateVolume();
                }
            }
        }

        private void ConvertResolution(string toConvert)
        {
            string[] temp = toConvert.Split("x");
            int width = Convert.ToInt16(temp[0]);
            int height = Convert.ToInt16(temp[1]);
            UpdateResolution(width, height);
        }
        private void UpdateResolution(int width, int height)
        {
            Settings.width = width;
            Settings.height = height;
        }
        private void UpdateVolume()
        {
            Settings.volume = _volume;
        }

        private void UpdateFullScreen()
        {
            Settings.fullscreen = _fullscreen;
        }
    }
}
