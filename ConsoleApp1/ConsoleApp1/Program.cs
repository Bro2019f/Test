using System;

namespace ConsoleApp1
{
   public class Program
    {
        public class Mycalc
        {

           static public int Sum(int x)
            {
                
               int c = x * x * x;
                // Console.WriteLine(x.ToString());
                Console.WriteLine("Обєм куба");
                Console.WriteLine(x.ToString() + " * " + x.ToString() + " * " + x.ToString() + " = " + c.ToString());
                return c ; 
            }
           static public int Bul(int x)
            {
                Console.WriteLine("Площа куба");
                int d = 6 * x * x;
                Console.WriteLine(6.ToString() + " * " + x.ToString() + " * " + x.ToString() + " = " + d.ToString());
                
                return d;
            }
            static void Main(string[] arg)
            {
                Console.WriteLine("Введiть сторону ромба");
                string S1 = Console.ReadLine();
                int x = int.Parse(S1);
                Sum(x);
                //Console.ReadLine();
                Bul(x);
                Console.ReadLine();
            }
        }

    }
}
