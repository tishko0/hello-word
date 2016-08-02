using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            alpha = 255;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public byte red{get;set}
        public byte green{get;set}
        public byte blue{get;set}
        

    }
}

