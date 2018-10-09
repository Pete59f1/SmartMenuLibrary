using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;
using CalculatorLibrary;

namespace SmartMenuLibrary
{
    class Binding
    {
        public void chooseFucntion(string callID)
        {
            double[] numbers = new double[] {4.5, 90.2, 2.9, 15.8, 938.0};
            SmartMenu smart = new SmartMenu();
            int bindcopy = smart.bind;
            if(bindcopy == 1)
            {
                do
                {
                    switch (callID)
                    {
                        case "1":
                            Functions.DoThis();
                            break;

                        case "2":
                            Functions.DoThat();
                            break;

                        case "3":
                            Functions.DoSomething("Did something");
                            break;

                        case "4":
                            Functions.GetTheAnswerToLifeTheUniverseAndEverything();
                            break;

                        case "0":
                            if(smart.userInputSprog == "d")
                            {
                                Console.WriteLine("Stopper program");
                            }
                            else if(smart.userInputSprog == "e")
                            {
                                Console.WriteLine("Stopping program");
                            }
                            break;

                        default:
                            if(smart.userInputSprog == "d")
                            {
                                Console.WriteLine("Forstår ikke");
                            }
                            else if(smart.userInputSprog == "e")
                            {
                                Console.WriteLine("Don't understand");
                            }
                            break;
                    }
                } while (callID != "0");
            }

            else if(smart.bind == 2)
            {
                do
                {
                    switch (callID)
                    {
                        case "1":
                            Calculator.Add(int.Parse(callID), int.Parse(callID));
                            break;

                        case "2":
                            Calculator.Subtract(int.Parse(callID), int.Parse(callID));
                            break;

                        case "3":
                            Calculator.Multiply(int.Parse(callID), int.Parse(callID));
                            break;

                        case "4":
                            Calculator.Divide(int.Parse(callID), int.Parse(callID));
                            break;

                        case "5":
                            Calculator.Sum(numbers);
                            break;

                        case "6":
                            Calculator.Minimum(numbers);
                            break;

                        case "7":
                            Calculator.Maximum(numbers);
                            break;

                        case "8":
                            Calculator.Average(numbers);
                            break;

                        case "0":
                            if (smart.userInputSprog == "d")
                            {
                                Console.WriteLine("Stopper program");
                            }
                            else if (smart.userInputSprog == "e")
                            {
                                Console.WriteLine("Stopping program");
                            }
                            break;

                        default:
                            if (smart.userInputSprog == "d")
                            {
                                Console.WriteLine("Forstår ikke");
                            }
                            else if (smart.userInputSprog == "e")
                            {
                                Console.WriteLine("Don't understand");
                            }
                            break;
                    }
                } while (callID != "0");
            }
            
        }
    }
}
