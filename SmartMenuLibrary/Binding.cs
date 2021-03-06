﻿using System;
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
        public void chooseFucntion(string callID, int bind,string userInputSprog)
        {
            string var1;
            string var2;
            double[] numbers = new double[] { 4.5, 90.2, 2.9, 15.8, 938.0 };
            if (bind == 1)
            {
                switch (callID)
                {
                    case "1":
                        Console.WriteLine(Functions.DoThis());
                        break;

                    case "2":
                        Console.WriteLine(Functions.DoThat());
                        break;

                    case "3":
                        Console.WriteLine(Functions.DoSomething("Did something"));
                        break;

                    case "4":
                        Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                        break;

                    case "0":
                        if (userInputSprog == "d")
                        {
                            Console.WriteLine("Stopper program");
                        }
                        else if (userInputSprog == "e")
                        {
                            Console.WriteLine("Stopping program");
                        }
                        break;

                    default:
                        if (userInputSprog == "d")
                        {
                            Console.WriteLine("Forstår ikke");
                        }
                        else if (userInputSprog == "e")
                        {
                            Console.WriteLine("Don't understand");
                        }
                        break;
                }
            }
            
            else if (bind == 2)
            {
                switch (callID)
                    {
                        case "1":
                        Console.WriteLine("Indtast første variabel");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Indtast anden varialbel");
                        var2 = Console.ReadLine();

                            Console.WriteLine(Calculator.Add(double.Parse(var1), double.Parse(var2)));
                            break;

                        case "2":
                        Console.WriteLine("Indtast første variabel");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Indtast anden varialbel");
                        var2 = Console.ReadLine();
                        Console.WriteLine(Calculator.Subtract(double.Parse(var1), double.Parse(var2)));
                            break;

                        case "3":
                        Console.WriteLine("Indtast første variabel");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Indtast anden varialbel");
                        var2 = Console.ReadLine();
                        Console.WriteLine(Calculator.Multiply(double.Parse(var1), double.Parse(var2)));
                            break;

                        case "4":
                        Console.WriteLine("Indtast første variabel");
                        var1 = Console.ReadLine();
                        Console.WriteLine("Indtast anden varialbel");
                        var2 = Console.ReadLine();
                        Console.WriteLine(Calculator.Divide(double.Parse(var1), double.Parse(var2)));
                            break;

                        case "5":

                            Console.WriteLine(Calculator.Sum(numbers));
                            break;

                        case "6":
                            Console.WriteLine(Calculator.Minimum(numbers));
                            break;

                        case "7":
                            Console.WriteLine(Calculator.Maximum(numbers));
                            break;

                        case "8":
                            Console.WriteLine(Calculator.Average(numbers));
                            break;

                        case "0":
                            if (userInputSprog == "d")
                            {
                                Console.WriteLine("Stopper program");
                            }
                            else if (userInputSprog == "e")
                            {
                                Console.WriteLine("Stopping program");
                            }
                            break;

                        default:
                            if (userInputSprog == "d")
                            {
                                Console.WriteLine("Forstår ikke");
                            }
                            else if (userInputSprog == "e")
                            {
                                Console.WriteLine("Don't understand");
                            }
                            break;
                    }
            }

        }
    }
}
