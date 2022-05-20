using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorBall
{
    internal class Ball
    {
        int size;
        Color color;
        int thrown;

        public Ball(int size, Color color, int thrown = 0)
        {
            this.size = size;
            this.color = color;
            this.thrown = thrown;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if (size != 0)
            {
                thrown++;
            }
        }

        public int Thrown()
        {
            return thrown;
        }
    }
}
