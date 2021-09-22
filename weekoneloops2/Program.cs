using System;

namespace weekoneloops2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] msgs = new string[3];
            bool on = true;

            while (on) { 
                Console.WriteLine("Would you like to leave a message, retrieve a message, or quit?");
                string ans = Console.ReadLine();

                if (ans == "m")
                {
                    for (int i = 0; i < msgs.Length; i++)
                    {           
                        
                        if (msgs[i] == null)
                        {
                            Console.WriteLine("Leave your message!");
                            msgs[i] = Console.ReadLine();
                            Console.WriteLine($"Your message number is {i}");
                            Console.WriteLine("Would you like to leave another");
                            string ans2 = Console.ReadLine();
                            if (ans2 == "y")
                            {
                                if (i == 2)
                                {
                                    Console.WriteLine("Your mailbox is Full!");
                                }
                                else 
                                { 
                                    Console.WriteLine("ok!"); 
                                }
                                
                            }
                            else
                            {
                                i = msgs.Length;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your mailbox is full.");
                            i = msgs.Length;
                        }
                    
                    }
                }
                if(ans == "r")
                {
                    Console.WriteLine("Which message would like to retreive: 0-3");
                    int refNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(msgs[refNum]);
                }
                if(ans == "q") 
                { 
                    on = false; 
                }
            }


            /*for (int i = 1; i <= 100; i++)
            {
                string FizzBuzz = "";
                if (i % 3 == 0)
                {
                    FizzBuzz = FizzBuzz + "Fizz";
                }
                if (i % 5 == 0)
                {
                    FizzBuzz = FizzBuzz + "Buzz";
                }
                if (i % 5 != 0 && i % 3 != 0)
                {
                    FizzBuzz = Convert.ToString(i);
                }
                Console.WriteLine(FizzBuzz);
            }*/
            /*for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

        }
    }
}
