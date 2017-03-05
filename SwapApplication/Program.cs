using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int fristNumber, secondNumber;
            Console.WriteLine("Enter the Frist Number");
            fristNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers you have Entered are " + fristNumber + " , " + secondNumber);
            Console.WriteLine("Press any key to swap the number");
            Console.ReadKey();
            SwapNumberManager swapObject = new SwapNumberManager();
            swapObject.SwapFunction(fristNumber,secondNumber);



                
        }
    }
}
