using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;

            }
            Console.WriteLine(" sum is {0} ", sum);
            Console.ReadLine();
        }
    }
}
