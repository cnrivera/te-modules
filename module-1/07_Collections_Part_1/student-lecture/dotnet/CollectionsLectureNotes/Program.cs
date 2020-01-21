﻿using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Creating lists of integers

            List<int> myList = new List<int>();
            List<int> theSecondList = List < int{ }>

            // Creating lists of strings



            List<string> myString = new List<String>();

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////
            if (myList == theSecondList) // ==to compare the empty list of integers)
            {
                Console.WriteLine ("The two lists are thes same")
            }
            else
            {
                Console.WriteLine("==compares addreses");
            }
            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            myList.Add(4);
            myList.Add(200);
            myListOfStrings.Add("c# is great");
            /////////////////
            // ADDING MULTIPLE ITEMS
            /////////////////

            int[] numsToAdd = { 4, 5, 6 };
            myList.AddRange(numsToAdd);
            //myList.AddRange(theSecondList);

            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            for (int i = 0, i < myList.Count, i++)
            {
                Console.Write(myList[i] + " "); Console.Write($" {myList[i]} + ");

            }



            ///////////////////
            // ACCESSING WITH FOR-EACH
            ///////////////////


            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////


            ////////////////////////
            // SORT and PRINT A LIST
            ////////////////////////




            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////



            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 


            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 

            

            ////////////////////
            // POPPING THE STACK
            ////////////////////
            

            Console.ReadLine();

        }
    }
}
