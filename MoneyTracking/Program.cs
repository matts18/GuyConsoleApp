using System;

namespace MoneyTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            joe.WriteMyInfo();
            bob.WriteMyInfo();

            while(true)
            {
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if(howMuch == "")
                {
                    return;
                }
                if(int.TryParse(howMuch, out int result))
                {
                    Console.Write("Who should give the cash? ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        joe.GiveCash(result);
                        bob.ReceiveCash(result);
                    }
                    else if(whichGuy == "Bob")
                    {
                        bob.GiveCash(result);
                        joe.ReceiveCash(result);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount or a blank line to exit");
                }
            }
        }
    }
}
