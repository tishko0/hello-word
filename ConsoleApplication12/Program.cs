using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Ball> Topka = new List<Ball>();


            Console.WriteLine("How many balls?");
            string Responce1 = Console.ReadLine();
            int Responce = Convert.ToInt32(Responce1);
            for (int b = 0; b < Responce; b++)
            {
                Topka.Add(new Ball(10, 20, 100, 200, 80));
            }
                    

            Topka[0].


            

            Console.WriteLine("numbers of throws of ball1 = " + Ball1.Numberofthrows());
            Console.WriteLine("numbers of throws of ball2 = " + Ball2.Numberofthrows());

            Console.ReadKey();

            Console.WriteLine("Select how many numbers of balls do you want to pop");


        }
    }
}
