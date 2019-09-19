///Name: Joseph Carusillo
///Date: 9/19/2019
///Project: Class Project Deliveravle 3 Arrays
///Description: select a type of array that doesnt ask the user anythng it just runs a program for size 25

using System;


namespace ClassProject_Deliverable3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the value 25 to run the program");

            // try/catch used to handle possible errors
            try
            {
                //get the value 25 to start the program
                string input = Console.ReadLine();
                //parse the string value
                int array_input = int.Parse(input);
                //iff statemetn for value 25 to give a array of size 25
                if ((array_input >=25) && (array_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Automatically populated array for the size 25 ");
                    int[] countdown = new int[array_input];
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number: " + array_input);
                    Console.WriteLine("Therefore " + array_input + " elements should be automatically populated in the array");
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine(" ");
                    int pop_array = 0;
                    // for loop to iterate in the array
                    for(int i = 0; i < array_input; i++)
                    {
                        countdown[i] = pop_array;
                        Console.Write(i + " ");
                                                                                                              
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________");
                    Console.WriteLine("please press any key to close the window");
                                                         
                }
                else
                {
                    //error messages for any errors that occur in the if/else statement 
                    Console.WriteLine("Please enter integer 25");
                    Console.WriteLine("Press any key to close the window after it has computed");

                }
                                                                                                    
            }
            catch
            {
                Console.WriteLine("There were errors in the program please try again");
                Console.WriteLine("Please press any key to close the window");
            }
            //used to keep window open
            Console.ReadKey();
                                                      
        }
    }
}
