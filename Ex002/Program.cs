using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
      
        public static int my_function(int m, int n,int sum)
        {
            if (m <= n)
            {
             
                sum = sum + m;
                m++;
                
               return my_function(m, n, sum);
            }
            return sum;

        }

        static void Main(string[] args)
        {
            int sum = 0;
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
            Console.Write("Сумма чисел в диапазоне от M до N равна: ");
            Console.Write(my_function(m, n, sum));
        }
       
    }
}