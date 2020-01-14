using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name = "TechElevator;";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            Console.WriteLine("Seasons of Firefly: "+seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
            string yourName = "Noel Rivera";
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numMouseButtons = 5;
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            double percentPhoneBatteryLeft = 99;
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int diff = 121 - 27;
            // or
            int value1 = 121;
            int value2 = 27;

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum = 12.3 + 32.1;
            /*
            12. Create a string that holds your full name.
            */
            string myName = "Noel Rivera";
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + myName;
            // or
            string hello = "Hello, "
            string greeting = hello + myName;
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            myName += myName + "Esquire";
            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            myName += "Esquire";
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string scaryMovieName = "Saw " + 2;
            //or
            string scaryMovieName = "Saw " + "2";

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            scaryMovieName += "0"
            /*
            18. What is 4.4 divided by 2.2?
            */
            double divResults18 = 4.4 / 2.2
            /*
            19. What is 5.4 divided by 2?
            */
            double divResults19 = 5.4 / 2;

            /*BONUS*/
            double testValue = (divResults18 + divResults19) / 3.2 * 5;
            bool isClassFun = true;

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            int result = 5 / 2;
            Console.WriteLine("The result of 5/2 is " + result);
            /*
            21. What is 5.0 divided by 2?
            */
            double resultB = 5.0 / 2;
            Console.WriteLine("The result of 5.0/2 is " + resultB);

            double resultC = 5 / 2;
            Console.WriteLine("The result of 5/2 is stored in a double is" + resultC);

            /* More bonus stuff */
            double x = 5.4;
            int y = (int) x;

            x = y; //putting it in a bigger box - not losing data
            y = x; //you'll lose data, are you sure that's ok?

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double bankBalance = 1234.56;
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int three = 3;
            long bil = 1000000000;
            long multiplicationResult = three * bil;
            Console.WriteLine("3 and 1,000,000,000 is " + multiplicationResult);
            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

            //practice literals
            float f = 3.0;
            float f2 = 3.0F;

            Console.ReadLine();
        }
    }
}
