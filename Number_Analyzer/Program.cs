using System;

namespace Number_Analyzer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declareng my contuinue var so it can be used gobally 
            Boolean con = true;

            //ask user for name now so it does ask again if the loop is run more than once
            Console.Write("What is your name?");
            string userName = Console.ReadLine();

            //Putting my code into a while loop so that it runs until con = false
            while (con == true)
            {
                

                // ask user for number between 1 - 100
                Console.WriteLine($"{userName} Please enter a number between 1 and 100");
                float userNum = float.Parse(Console.ReadLine());

                // Pring the users number, tell them what it is (even/odd, etc)
                if (userNum<1 || userNum>100)
                {
                    Console.WriteLine($"{userName} You entered an invalid amount, please retry");
                }
                else if (userNum % 2 == 0)
                {
                    if (userNum > 2 && userNum < 25)
                    { Console.WriteLine($"{userName} you're number was {userNum} and it is even and less than 25"); }
                    else
                    { Console.WriteLine($"{userName} you're number was {userNum} and it is even"); }
                }
                else
                {
                    Console.WriteLine($"{userName} you're number was {userNum} and it is odd.");

                }

                //asks if they would like to continue 
                Console.WriteLine("Would you like to enter another number? (yes or no)");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();


                if (userInput == "yes")
                {
                    con = true;
                }
                else
                {
                    Console.WriteLine($"Goodbye {userName}, you shall be missed");
                    con = false;
                }

            }


        }
    }
}
