using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    internal class Color
    {
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            Alpha = 255;
        }

        public byte Red { set; get; }
        public byte Green { set; get; }
        public byte Blue { set; get; }
        public byte Alpha { set; get; }

        public byte grayscale()
        {
            return (byte)((Red + Green + Blue) / 3);
        }

    }
}
