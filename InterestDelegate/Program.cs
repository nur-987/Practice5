using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestDelegate
{
    /// <summary>
    /// Default Delegates and events
    /// Custom Event Args
    /// Custom Even Args
    /// </summary>
    
    delegate void interestDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculator = new Calculate();

            //multi cast delegate
            interestDelegate interestDelegate = new interestDelegate(calculator.GetPrincipal);
            interestDelegate += calculator.GetInterest;
            interestDelegate += calculator.GetTime;
            interestDelegate += calculator.CalculateSimpleInt;

            //run the delegate with multiple funcs
            interestDelegate();

            calculator.CalculateInterestEvent += Calculator_CalculateInterestEvent1;

            Console.ReadLine();

        }

        //uses the new EventArgs you customed
        private static void Calculator_CalculateInterestEvent1(object sender, EventArgs result)
        {
            Console.WriteLine("Simple interest is; " + result);
        }

    }

}
