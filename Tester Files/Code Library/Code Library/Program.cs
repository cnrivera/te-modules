using System;

namespace Code_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //Method to convert to binary
        private static string ConvertNumberToBinary(int base10)
        {
            string binary = "";
            while (base10 > 0)
            {
                binary = (base10 % 2) + binary;
                base10 = base10 / 2;
            }

            return binary;
        }

        //Method to print array to console
        private static void WriteArrayToConsole(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ",");
                }
            }
        }

    Setup git:
git config --global user.name "${name}"
git config --global user.email "${email}"

git config --global core.editor "code -w -n"
git config --global diff.tool code
git config --global difftool.code.cmd "code -w -d $LOCAL $REMOTE"

clone your own repository
cd into your own repository

git remote add upstream "https://bitbucket.org/te-cin-cohort-7/c-main"
git config branch.master.mergeOptions "--no-edit"
}

public static class RNG
{
    private static Random random;

    private static void Init()
    {
        if (random == null) random = new Random();
    }

    public static int GetRandomInt(int min, int max)
    {
        Init();
        return random.Next(min, max + 1);
    }
}


public class VendingMachineCLI
{
    private VendingMachine vendMach;

    public void StartTheMachine()
    {
        ReadyTheInventory(); //this would use the vendMachine object or maybe you call vendMachine.ReadTheInventory();

        string userChoice = "";
        while (userChoice != "3")
        {
            Console.WriteLine("display the menu options");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                DisplayItemList();
            }
            else if (userChoice == "2")
            {
                DisplayPurchaseMenu();
            }
            else if (userChoice == "4")
            {
                GenerateSalesReport();
            }
        }
    }



    public void DisplayItemList()
    {
        Console.WriteLine("display all the items from the object vendMach that's a class variable");
    }

    public void DisplayPurchaseMenu()
    {
        string userChoice = "";
        while (userChoice != "3") //Finish gets you out of this menu
        {
            Console.WriteLine("display the purchase menu options");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                FeedMoney();
            }
            else if (userChoice == "2")
            {
                SelectProduct();
            }

        }
        FinishTransaction();
    }

    public void GenerateSalesReport()
    {
        Console.WriteLine("display all the items from the object vendMach that's a class variable");
    }

    public static List<SelectListItem> CreateSelectListFromListOfStrings(IList<string> myList)
    {
        List<SelectListItem> mySelectList = new List<SelectListItem>();
        foreach (string s in myList)
        {
            SelectListItem item = new SelectListItem() { Text = s, Value = s };
            mySelectList.Add(item);
        }
        return mySelectList;

    }
}