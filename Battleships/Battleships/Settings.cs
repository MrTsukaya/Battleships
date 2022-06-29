using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public static class Settings
    {
        public static int height { get; set; } = 600;
        public static int width { get; set; } = 800;
        public static int volume { get; set; } = 0;
        public static bool fullscreen { get; set; } = false;

        public static double ScaleResolutionSize()
        {
            return width * 0.4;
        }
    }
}
