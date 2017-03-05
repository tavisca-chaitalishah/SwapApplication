using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapApplication
{
    class SwapNumberManager
    {
        public void SwapFunction(int firstNumber, int secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("Numbers after Swap are : \n");
            Console.WriteLine("FristNumber is = " + firstNumber + " SecondNumber is = " + secondNumber);
            Console.WriteLine("Thankyou\n\nPress Any key to Exit the Application...");
            Console.ReadKey();
        }

    }
}
