//27 задание
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
      
        public static void my_function(int m, int n)
        {

            Console.WriteLine(m);
            if (m == n) return;
            my_function( m + 1 , n);


        }

        static void Main(string[] args)
        {
        Label:
          
            Console.Write("Введите M: ");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите N: ");
            int n = Convert.ToInt16(Console.ReadLine());
            if(n<0||m<0)
            {
                Console.Write("Можно вводить только положительные числа, попробуйте еще раз.\n");
                goto Label;
            }
           else if (m>n)
            {
                
                    Console.Write("Нужно ввести числа при которых N больше M, попробуйте еще раз.\n");
                    goto Label;
                
            }
       
            my_function(m,n);
        }
       
    }
}