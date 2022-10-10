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
          
            Console.WriteLine("Введите M: ");
            
            var m1 = Console.ReadLine();
            int m = Convert.ToInt32(m1);
            Console.WriteLine("Введите N: ");
         
            var n1 = Console.ReadLine();
            int n = Convert.ToInt32(n1);
            
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
