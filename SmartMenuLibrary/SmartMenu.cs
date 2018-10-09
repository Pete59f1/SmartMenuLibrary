using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string[] danskTxt;
        string[] englishTxt;
        int[] callID;
        public string userInput = null, userInputSprog = null;
        int counter;
        public int bind = 0;
        public void LoadMenu(string path)
        {
            if(path == "MenuSpec.txt")
            {
                bind = 1;
            }
            else if(path == "CalcMenu.txt")
            {
                bind = 2;
            }

            string[] heleTxt = System.IO.File.ReadAllLines(@"C:\Users\Niclas\Desktop\SmartMenuLibrary\SmartMenuLibrary" + path);
            danskTxt = heleTxt.Take(heleTxt.Length / 2).ToArray();
            englishTxt = heleTxt.Skip(heleTxt.Length / 2).ToArray();

            for (int i = 0; i < danskTxt.Length; i++)
            {
                if (danskTxt[i].Contains(';'))
                {
                    counter++;
                    string[] splitter = danskTxt[i].Split(';');
                    danskTxt[i] = splitter[0];
                }
            }

            callID = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                callID[i] = i + 1;
            }
        }

        public void Activate()
        {
            Console.WriteLine("Vælg sprog - Choose language: \n Tryk D for Dansk \n Press E for English");

            do
            {
                userInputSprog = Console.ReadLine().ToLower();
                printMenu(userInputSprog);

            } while (userInputSprog != "d" && userInputSprog != "e");

            Binding bind = new Binding();

            do
            {
                userInput = Console.ReadLine();

                Console.Clear();
                printMenu(userInputSprog);
                bind.chooseFucntion(userInput);
                
            } while (userInput != "0");
        }

        public void printMenu(string lang)
        {
            if (lang == "d")
            {
                Console.Clear();
                Console.WriteLine("Du har valgt dansk\n");
                for (int i = 2; i < danskTxt.Length; i++)
                {
                    Console.WriteLine(danskTxt[i]);
                }
                Console.WriteLine("\n" + "(" + danskTxt[1] + ")");
            }
            else if (lang == "e")
            {
                Console.Clear();
                Console.WriteLine("You have chosen English\n");
                for (int i = 2; i < englishTxt.Length; i++)
                {
                    Console.WriteLine(englishTxt[i]);
                }
                Console.WriteLine("\n" + "(" + englishTxt[1] + ")");
            }
            else
            {
                Console.WriteLine("Du har ikke valgt et gyldigt sprog - You have not chosen a viable language");
            }
        }
    }
}
