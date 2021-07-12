/**
 * Matthew Taylor
 * ITC366-899
 * 
 * HW 6
 * 
 * Video Link
 * 
 * Source Link
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ITC366_899_Matthew_Taylor_HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //// DECLARE ANY ENUM's HERE 
            ///BETWEEN CLASS DECLARATION & MAIN METHOD ////

            String headerBar = new string('*', 40);
            String header = "\n  -  ITC366-899 Homework  -\nMatthew Taylor\nmatt271@live.missouristate.edu\n";
            String instructions = "Enter the number from one the following to run the corresponding exercise code: \n";
            String exerciseList = ": Exercise ";

            //Main method control variable declaration and initialization
            Boolean continueStatus = true; //initialize and set loop control boolean
            int length = 5; //sets number of exercises
            char exerciseSelection, continueChoice; //character variables to hold exercise selection


            Console.WriteLine(headerBar + header + headerBar);


            //Console.Write("Enter your name: ");
            //String enteredName = Console.ReadLine(); 

            /**
            * While loop runs as long as users choose to continue program
            * 
            * Improvement notes: implement break and continue statements
            */

            while (continueStatus == true)
            {

                ///// Write Program Instructions /////
                Console.WriteLine(instructions);


                //loop through exercises and display menu
                for (int loopIndex = 1; loopIndex <= length; loopIndex++)
                {
                    Console.WriteLine(loopIndex + exerciseList + loopIndex);

                }//end menu text for loop

                //prompt for and retrieve exercise selection
                Console.WriteLine("Enter exercise selection: ");
                exerciseSelection = (char)Console.Read();
                ClearKeys();


                switch (exerciseSelection)
                {
                    case '1':
                        Exercise1();
                        break; // end case 1

                    case '2':
                        Exercise2();
                        break;
                    case '3':
                        Exercise3();
                        break;
                    case '4':
                        Exercise4();
                        break; //end case 4

                    case '5':
                        Exercise5();
                        break; //end case 5
                    default:
                        Console.WriteLine("Invalid input.");
                        break;

                }  // switch on exerciseSelection to launch exercise methods

                ///// Continue program section /////
                Console.WriteLine("Continue (y/n)?");
                continueChoice = (char)Console.Read();
                ClearKeys();

                // conditionals to determine whether to exit while loop
                // improve with continue statement?
                if (continueChoice == 'y')
                {
                    continueStatus = true;
                    Console.WriteLine("Choose another exercise.\n");

                }//end if

                else
                {
                    continueStatus = false;
                    Console.WriteLine("Thank you for using this application.\n");
                }//end else

            }// program continue while loop

            Console.WriteLine("\nEnd Program");
        } // end main method

        // ClearKeys method code located through research to ensure that characters are read correctly
        public static void ClearKeys()
        {
            while (Console.In.Peek() != -1)
                Console.In.Read();
        }

        /**
         * Exercise 1
         * Write a method to accept 8 test scores, calculate the arithmetic mean, and display the
         * deviation from the mean for each score
         */

        public static void Exercise1()
        {
            String entryPrompt = "Enter a distance in miles >> ";
            Console.Write($"{entryPrompt}");
            String entryValueStr = Console.ReadLine();
            double entryValue = Double.Parse(entryValueStr);
            double convertedToKm = milesToKilometers(entryValue);
            String convertedKmStr = String.Format("{0:0.000}", convertedToKm);
            Console.WriteLine($"{entryValue} mile(s) is equal to {convertedKmStr} kilometers");
            
        } // exercise1

        /**
         * Exercise 2
         * Input (5) daily temps in degrees farenheit, ranging from -30 to 130 degrees. 
         * If Temp is out of range, force reentry
         * If temp n > temp n-1 > ... > temp_1, "enter getting cooler"
         * If temp_n < temp_n-1 < ... < n_1, display "getting warmer"
         * If there is not a specific increasing or decreasing trend, display "mixed bag"
         * Finally, display the temps in order and the average
         * 
         * I created test arrays of booleans and used a comparison method from 
         * https://stackoverflow.com/questions/4423318/how-to-compare-arrays-in-c
         * 
         */
        public static void Exercise2()
        {

            
            String overdueBooksPrompt = "Enter the number of books that are overdue >> ";
            Console.Write(overdueBooksPrompt);
            String booksOverdueStr = Console.ReadLine();
            int booksOverdue = int.Parse(booksOverdueStr);
            String daysOverduePrompt = $"Enter number of days that the {booksOverdue} are overdue >> ";
            Console.Write($"{daysOverduePrompt}");
            String daysOverdueStr = Console.ReadLine();
            int daysOverdue = int.Parse(daysOverdueStr);

            calculateFines(booksOverdue, daysOverdue);



        } // exercise 2

        /** Exercise 3
         * 
         * 
         * Prompt user to enter number of days for a restort stay.
         * Display price per night and total price.
         *
         */
        public static void Exercise3()
        {
            String stayLengthPrompt = "How many nights in your stay? ";
            String pricePerNightMsg = "Price per night is ";

            double stayRate = 0;
            Console.WriteLine($"{stayLengthPrompt} ");
            int stayLength = int.Parse(Console.ReadLine());

            if (stayLength > 0)
            {
                switch (stayLength)
                {
                    case 1:
                    case 2:
                        stayRate = 200;
                        //Console.WriteLine($"Stay rate: {stayRate.ToString("C")}");
                        break;
                    case 3:
                    case 4:
                        stayRate = 180;
                        //Console.WriteLine($"Stay rate: {stayRate.ToString("C")}");
                        break;
                    case 5:
                    case 6:
                    case 7:
                        stayRate = 160;
                        //Console.WriteLine($"Stay rate: {stayRate.ToString("C")}");
                        break;
                    default:
                        stayRate = 145;
                        //Console.WriteLine($"Stay rate: {stayRate.ToString("C")}");
                        break;
                } // switch on stayLength to set stayRate

            } //valid input case, set nightly rate
            else
                Console.WriteLine("invalid");
            //invalid input case

            double stayInvoice = (double)stayLength * stayRate;

            Console.WriteLine($"{pricePerNightMsg} {stayRate.ToString("C")}");
            Console.WriteLine($"Total for {stayLength} nights is {stayInvoice.ToString("C")}.");

        } // exercise 3

        /**
             * Exercise 4
             */

        public static void Exercise4()
        {
            //Console.WriteLine("exercise4");

            int[] numbers = { 12, 15, 22, 88 }; //had to change case from Int to int
            int x;
            double average;
            double total = 0;

            Console.Write("\nThe numbers are...");
            for (x = 0; x < numbers.Length; x++)
            {
                Console.Write($"{numbers[x],6}"); //spelling error on numbers, loop index issue. x should start at 0 and should increment after rather than before, i.e. x++ rather than ++X

            } //display the numbers

            Console.WriteLine();

            for (x = 0; x < numbers.Length; ++x)
            {
                total = total + numbers[x];
            }

            average = total / numbers.Length; //needed to capitalize the L in length, 

            //there was no output statement to print the average. 
            Console.WriteLine($"The average is {average,2}");

        } // exercise 4

        public static void Exercise5()
        {

            ///**

            const int QUIT = 999;
            List<int> numbers = new List<int>(); //need to specify a length for the array or use a list construction
            int x = 0; // need to initialize to zero
            int num;

            double average;
            double total = 0;

            string inString;

            Console.Write("Please enter a number or " + QUIT + " to quit...");
            inString = Console.ReadLine();  //missing parenthesis 

            num = Convert.ToInt32(inString); //need to specify int size? e.g. ToInt32

            while ((x <= numbers.Count) && num != QUIT) // x was unassigned, will need to be initialized. also, the logical statement should be changed. 
            {

                numbers.Add(num);
                total += numbers[x];
                x++;
                Console.Write("Please enter a number or " +
                    QUIT + " to quit...");
                inString = Console.ReadLine(); //capitalization error, missing Console.
                num = Convert.ToInt32(inString);

            }

            //Console.WriteLine("QUIT selected");

            Console.WriteLine("The numbers are:");
            for (int y = 0; y < numbers.Count; y++)  //tried swapping ++x (orig) for y++, 
                Console.Write("{0,6}", numbers[y]);

            average = total / numbers.Count;
            Console.WriteLine();
            Console.WriteLine("The average is {0}", average); // spelling issue, missing parenthesis 

            //*/

        } // exercise 5 method

        /** isEqual method
         * 
         * A quick method to compare two arrays of booleans and returns a boolean. A lot of the methods I saw recommended 
         * from stack overflow, etc, like checkEquality 
         * 
         */

        public static bool isEqual(bool[] arr1, bool[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                //Console.WriteLine($"arr1[{i}]   {arr1[i],10}   arr2[{i}]   {arr2[i],10}     ");

                if (arr1[i] == arr2[i])
                {
                    //Console.WriteLine($"arr1[{i}]   {arr1[i],10}   arr2[{i}]   {arr2[i],10}     ");

                    continue;
                }
                else
                {
                    //Console.WriteLine("\nnot equal, return false");
                    return false;
                } // method return false;
            } // continue on equal values, return false if not equal

            //Console.WriteLine("\nequal, return true");
            return true;
        } // quick and dirty boolean array equivalence tester

        public static double milesToKilometers(double milesEntry)
        {
            const double MTOKFACTOR = 1.60934;
            double kilometers = milesEntry * MTOKFACTOR;
            return kilometers;
        }

        public static void calculateFines(int booksOverdue,int daysOverdue)
        {
            const double SMALLFINE = 0.1;
            const double LARGEFINE = 0.2;
            double fineTotal;
            String fineTotalStr = "";

            if(daysOverdue <= 7)
            {
                fineTotal = booksOverdue * daysOverdue * SMALLFINE;
                fineTotalStr = fineTotal.ToString("C");
                //fineTotalStr = String.Format("{0,$.$$}", fineTotal);
                //Console.WriteLine($"The fine for {booksOverdue} book(s) for {daysOverdue} day(s) is {fineTotalStr}");
            }
            else
            {
                fineTotal = booksOverdue * (7 * SMALLFINE + (daysOverdue - 7) * LARGEFINE);
                fineTotalStr = fineTotal.ToString("C");
            }
            
            Console.Write($"The fine for {booksOverdue} book(s) for {daysOverdue} day(s) is {fineTotalStr} ");
            
            //Console.Write("{0:C2}", fineTotalStr);
            //Console.WriteLine("end calculateFines");
        } // calculate the fine 


} // end class

    } // end namespace