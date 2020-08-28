using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1, z = 1;
            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0) {
                for (int i = 1; i <= a; i++) {
                    Console.Write(z + " ");
                    z = x + y;
                    x = y;
                    y = z;
                }
            }
            else
            {

                Console.WriteLine("inputkan bilangan asli");
               
               
            }
            Console.ReadLine();

            
        }
    }
}
