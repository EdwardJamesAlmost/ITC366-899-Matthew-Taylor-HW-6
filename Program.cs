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
            do
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

            } while (continueStatus == true); // program continue while loop

            Console.WriteLine("\nEnd Program");
        } // end main method

        public static void ClearKeys()
        {
            while (Console.In.Peek() != -1)
                Console.In.Read();
        } // run after using Console.Read() to obtain single character input and clear buffer

        /**
         * Exercise 1
         * 
         * Write a method to convert a distance in miles to a distance in kilometers. The milesToKilometers
         * method accepts a double parameter and returns a double. 
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
         * 
         * A method has been written to calculate the total fines for varying quantities of overdue books and days overdue. The method then returns a fine total which is displayed by the Exercise2() method.
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

            String fineTotalStr = calculateFines(booksOverdue, daysOverdue);

            Console.Write($"The fine for {booksOverdue} book(s) for {daysOverdue} day(s) is {fineTotalStr} ");

        } // exercise 2

        /** Exercise 3
         * 
         * Tip calculator
         * 
         */
        public static void Exercise3()
        {
            String mealPricePrompt = "Enter meal price: ";
            String tipPercentPrompt = "Enter tip percentage as an integer, e.g. 20 for 20%: ";
            String tipAmountPrompt = "Enter temp quantity (e.g. 5 for a $5 tip): ";

            // input section
            Console.Write($"{mealPricePrompt}");
            String mealPriceStr = Console.ReadLine();
            
            Console.Write($"{tipPercentPrompt}");
            String tipPercentStr = Console.ReadLine();

            Console.Write($"{tipAmountPrompt}");
            String tipAmountStr = Console.ReadLine();

            //value conversion
            int tipPercent = int.Parse(tipPercentStr);
            double mealPrice = double.Parse(mealPriceStr);
            int tipAmount = int.Parse(tipAmountStr);

            // Call methods
            Console.WriteLine(" - Percentage Method - ");
            tipCalculator(mealPrice,tipPercent);
            Console.WriteLine();
            Console.WriteLine(" - Tip Total Method - ");
            tipCalculator(mealPrice, tipAmount);


        } // exercise 3

        /** Exercise 4
        * It seems like this would be better implemented using arrays and the Reverse method
        */

        public static void Exercise4()
        {
            //Console.WriteLine("exercise4");
            int firstInt, middleInt, lastInt;

            Console.Write("Enter 1st integer: ");
            firstInt = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd integer: ");
            middleInt = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd integer: ");
            lastInt = int.Parse(Console.ReadLine());

            Console.WriteLine($"The numbers are: {firstInt}      {middleInt}     {lastInt}");
            reverseInts(ref firstInt, ref middleInt, ref lastInt);

        } // exercise 4

        public static void Exercise5()
        {
            FancyDisplay(33, 'X'); // does not specify a decoration character
            FancyDisplay(44, '@'); // if the FancyDisplay method is expecting a character, single quotes should be used

            FancyDisplay(Convert.ToString(55.55),'+'); // there is no method signature that accepts only a double. Also, the double values need to be converted to strings to match the method declaration
            FancyDisplay(Convert.ToString(77.77), '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
            
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
        } // convert miles to kilometers

        public static String calculateFines(int booksOverdue,int daysOverdue)
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

            return fineTotalStr;
            
            //Console.Write("{0:C2}", fineTotalStr);
            //Console.WriteLine("end calculateFines");
        } // calculate the fine

        /// <summary>   Method to calculate a tip based on the meal price and a percentage value for a tip
        /// 
        /// </summary>
        /// <param name="mealPrice"></param>
        /// <param name="tipPercent"></param>
        public static void tipCalculator(double mealPrice, int tipPercent)
        {
            double tipDecimal = (double)tipPercent / 100.0;
            double tipAmount = mealPrice * tipDecimal;
            Console.WriteLine($"Meal Price: {mealPrice}. Tip percentage {tipDecimal.ToString("P")}");
            Console.WriteLine($"Tip in dollars: {tipAmount}. Total Bill: {mealPrice + tipAmount}");
        } // tip percentage method


        /// <summary>   Method to calculate the tip percentage based on the total meal price 
        ///             and a set tip value
        /// 
        /// </summary>
        /// <param name="mealPrice"></param>
        /// <param name="tipTotal"></param>
        public static void tipCalculator(double mealPrice, double tipTotal)
        {
            double tipPercent = tipTotal / mealPrice;
            Console.WriteLine($"Meal Price: {mealPrice}. Tip percentage {tipPercent.ToString("P")}");
            Console.WriteLine($"Tip in dollars: {tipTotal}. Total Bill: {mealPrice + tipTotal}");
        } // tip total method


        /// <summary> Method that accepts 3 integers and reverses their order
        /// 
        /// </summary>
        /// <param name="firstInt"></param>
        /// <param name="middleInt"></param>
        /// <param name="lastInt"></param>
        public static void reverseInts(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int swap1 = lastInt;
            int swap2 = firstInt;
            Console.WriteLine($"The numbers are: {swap1}      {middleInt}     {swap2}");

            // If this were a longer list of integers, I would implement a loop to populate an 
            // integer array and then use an array method to reverse the order of the integers
            // and iterate through the reversed array elements.
           
        } //swaps the order of the first and last integer in a sequence of 3




        private static void FancyDisplay(int num, char decoration) // assigning 'X' to decoration at method call will lock in the decoration character, should be passed as an argument
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num); // a third variable is not provided in the method, order is wrong to match provided output
        }
        private static void FancyDisply(double num, char decoration = 'X') // allow decoration to be set by method call argument
        {
            String dollars = num.ToString("C");
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, dollars); // 2nd placeholder variable not used
        }
        private static void FancyDisplay(String word, char decoration = 'X') // method declaration doesn't specify the data type for word
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word); // extra second placeholder variable called, should be {0}
        }

    } // end class

} // end namespace