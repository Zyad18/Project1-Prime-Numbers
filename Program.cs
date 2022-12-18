using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pls enter n2");
            int n2 = int.Parse(Console.ReadLine());

            int  x ;
            Console.Write("The prime numbers between "+n1+" and "+n2+" is: ");

            for (int i = n1 ; i <= n2; i++) 
            {
               
                for (x = 2 ; x <= i; x++)
                {
                    if ((i % x == 0))
                        break;
                 
                }

                if (x == i)  
                    Console.Write( i + ", ");
                
            }


        }
    }
}
