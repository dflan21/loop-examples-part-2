// Author: David Flannery 
// Date: 9/13/2022
// Description: Loop delivary 3 




using System; // declaring systems library 


namespace loop_examples_part__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 0 and 20 to execute a loop:");

            try
            {
                int input = int.Parse(Console.ReadLine()); 
                
                if((input >=0) && (input <=5))
                {
                    Console.WriteLine("executing a for loop:");
                    Console.WriteLine("The for loop will iterat" + input.ToString() + "times"); 

                    for (int i = 0; i < input; i++)
                    {
                        Console.WriteLine("the value of the variable i is: " + i.ToString()); 
                    }
                }
                else if ((input > 5) && (input <= 15))
                {
                    Console.WriteLine("executing a While loop:"); 
                    Console.WriteLine("The while loop will iterate" + input.ToString() + "times");

                    int j = 0; 
                    while (j <= input)
                    {
                        Console.WriteLine("The value of the variable i is: " + j.ToString()); 
                        j++;
                    }
                }
                else if ((input > 15) && (input <=20))
                {
                    Console.WriteLine("executing a do/while loop");
                    Console.WriteLine(" the do/while loop will iterate" + input.ToString() + "times");

                    int k = 0;
                    do
                    {
                        Console.WriteLine("The value of the variable k is :" + k.ToString() + "times");
                        k++;
                    }
                    while (k <= input);

                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true); 


                }

                else
                {
                    Console.WriteLine("Please try again and type integer numner");
                    Console.WriteLine("Press any key to leave program");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a integer value and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true); 
            }
        }
    }
}