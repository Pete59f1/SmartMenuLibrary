using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    class Binding
    {
        public void chooseFucntion(string callID)
        {
            SmartMenu smart = new SmartMenu();
            if(smart.bind == 1)
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
                            Console.WriteLine("Stopping program");
                            break;

                        default:
                            Console.WriteLine("Don't understand");
                            break;
                    }
                } while (callID != "0");
            }
            else if(smart.bind == 2)
            {
                //Tilføj calculator functions!!
            }
            
        }
    }
}
