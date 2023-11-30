using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirveli ricxvi: ");

            double number1 = Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("Meore ricxvi: ");

            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine("Rixvebis jami aris: " + sum);

        }
    }
}
