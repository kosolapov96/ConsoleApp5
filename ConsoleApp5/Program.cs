using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double f = 0;

                for (int i = 0; i <= 100; i++)
                {

                    f = 9 * i / 5 + 32;
                    Console.WriteLine($" {i}  Градусов Цельсия =  {f} Градусов по Фаренгейту");
                }

            }


            {
                double decision;
                for (int i = 0; i <81; i += 9)
                {
                    decision = 12345679 * i;
                    Console.WriteLine($"{decision}");

                }

            }



            {
                double grn, rate;
                Console.WriteLine(  "Введите курс доллара: ");
                rate = Convert.ToDouble(Console.ReadLine());
                for (double i = 0; i <= 20; i++)
                {
                    
                    grn = i * rate;
                    Console.WriteLine($"{i} Доллара = {grn} Гривны");

                }


                


            }
        }
    }
}
