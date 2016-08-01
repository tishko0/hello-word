using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Ball
    {
        private int size;
        private int radius;
        private int ThrowCount=0;
        Color BallColor = new Color(100, 150, 200);

        public Ball(int size, int radius, byte red, byte green, byte blue)
        {
            this.size = size;
            this.radius = radius;
            red = BallColor.GetRed();
            green = BallColor.GetGreen();
            blue = BallColor.GetBlue();
        }
        
        public void Pop()
        {
            size = 0;
            
        }

        public void Throw()
        {
            ThrowCount++;
        }

        public int Numberofthrows()
        {
            return ThrowCount;
        }


    }
}
