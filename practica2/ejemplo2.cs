using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcula_el_itbis
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double p;
            float itbis = 0.16f;
            
            Console.WriteLine("ingresa el precio");
            p = Convert.ToDouble(Console.ReadLine());

            if (p >= 150) 
            {
                r = (p * 0.16);
                Console.WriteLine("el resultado es ");
                Console.WriteLine(r); 
             }
                 


            
              else {
                Console.WriteLine(p);

            }
            




        }
    }
}
