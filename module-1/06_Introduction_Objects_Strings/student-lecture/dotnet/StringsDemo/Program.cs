using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character. ");
            Console.WriteLine(name[0] + " " + name[name.Length - 1]);

            //2. How do we write code that prints out the first three characters
            // Output: Ada
            name.Substring(0, 3); // if no second number (length) it goes to the end. Making a number longer than avaialble chars will give error
            Console.WriteLine("First 3 characters: "); // returns another string. Does not modify. If create a new variable, that creates new.
            Console.WriteLine("original " + name);

            //3. Now print out the first three and the last three characters
            // Output: Adaace
            Console.WriteLine(name.Substring(name.Length - 3) + name.Substring(name.Length(0, 3));


            // Console.WriteLine("Last 3 characters: ");
            Console.WriteLine(name.Substring(name.Length - 3);

            // 4. What about the last word?
            // Output: Lovelace
            int space = name.IndexOf(" ");
            string lastName = name.Substring(space + 1);
            Console.WriteLine("Last Word: " + lastName);

            // Console.WriteLine("Last Word: ");

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\"");
            Console.WriteLine(name.Contains("Love"));

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int indexOfLace = name.IndexOf("lace");
            Console.WriteLine("Index of \"lace\": " + indexOfLace);

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            // options:
            //go through like an array of characters and increment count if a or A

            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals('a') || name[i].Equals('A'))
                {

                }
            }

            //or find the index of A or a, increment count and then look through substring to right of that


            int indexOfA = lower.IndexOf('a');
            int count Str = 0;
            int indexOfA >= 0

                while (indexOfA => 0)
            {
                countStr++
                    if (indexOfA < lowerName.Length - 1)
                {
                    string subStr = lowerName.Substring(indexOfA++);
                    indexOfA
                }
            }
            // Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            // Console.WriteLine(name);
            string somethingElse = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(somethingElse);

            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done". //anything null cannot use eferences
            if (name == null || name == "") 
                {
                Console.WriteLine("all done")
                 }
            Console.ReadLine();



        }
    }
}