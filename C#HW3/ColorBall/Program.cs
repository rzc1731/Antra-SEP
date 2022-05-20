// See https://aka.ms/new-console-template for more information
using System;

namespace ColorBall
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball(3,new Color(1,1,1));
            Ball b2 = new Ball(3,new Color(100,100,100));
            Ball b3 = new Ball(3, new Color(200, 200, 200));

            b1.Throw();
            b1.Throw();
            b2.Throw();
            b3.Throw();

            b2.Pop();

            b1.Throw();
            b2.Throw();
            b3.Throw();

            Console.WriteLine(b1.Thrown());
            Console.WriteLine(b2.Thrown());
            Console.WriteLine(b3.Thrown());
        }
    }
}
