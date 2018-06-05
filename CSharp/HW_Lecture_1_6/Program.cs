using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lecture_1_6
{
    class Program
    {
        private const char BreakChar = '=';

        private static readonly string BreakString = new string(BreakChar, Console.BufferWidth);  //лень было писать в методах

        static void Main(string[] args)
        {
            //Создать консольное приложения для работы со списком покупок.
            //    2.Добавить возможность добавления покупки «называние» «цена»
            //    3.Добавить возможность «узнать цену товара»
            //    4.Добавить возможность «вывести товары дороже чем»

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Dictionary<string, decimal> purchasesList = new Dictionary<string, decimal>();

            decimal filterValue = 0m;
            int filterDirection = 0;
            bool isPriceVisible = false;

            int selectedMenuIndex = -1;
            string[] menuOptions = { // There must be Enum
                "Add purchase",//0
                "Set price filter",//1
                "Show/Hide prices",//2
                "Exit"//3
            };

            InitializePurchasesListByDefault(purchasesList);

            while (true)
            {
                Console.Clear();

                WritePurchasesListToConsole(purchasesList, isPriceVisible, filterDirection, filterValue);

                if (selectedMenuIndex == -1) // Show main menu
                    selectedMenuIndex = GiveChoiceToUser(menuOptions, "Options:");
                else
                {
                    if (menuOptions[selectedMenuIndex] == menuOptions[0]) //Add purchase
                    {
                        KeyValuePair<string,decimal> newPurchase = GetNewPurchaseInfo();
                        purchasesList.Add(newPurchase.Key, newPurchase.Value);

                        Console.WriteLine("Purchase was added to list");
                    }
                    else if (menuOptions[selectedMenuIndex] == menuOptions[1]) //Set price filter
                    {
                        string[] options = 
                        {
                            "No",//0
                            "Yes i do, i want to see purchases with price LOWER than...", //1
                            "Yes i do, i want to see purchases with price HIGHER than..." //2
                        };
                        string str = "Do you want to filter list?";

                        filterDirection = GiveChoiceToUser(options, str);

                        if (filterDirection != 0)
                            filterValue = GetPriceFilterValue();
                    }
                    else if (menuOptions[selectedMenuIndex] == menuOptions[2]) //Show/Hide prices
                    {
                        string[] options = { "No", "Yes" };
                        string str = "Do you want to see prices in the purchases list?";
                        isPriceVisible = GiveChoiceToUser(options, str) != 0;
                    }
                    else if (menuOptions[selectedMenuIndex] == menuOptions[3]) //Exit
                        break;

                    selectedMenuIndex = -1;
                }
            }
        }

        private static void InitializePurchasesListByDefault(Dictionary<string, decimal> purchasesList)
        {
            purchasesList.Add("Cheese", 10.6M);
            purchasesList.Add("Wine", 26.6M);
            purchasesList.Add("Bread", 2.5M);
            purchasesList.Add("Bre@d", 2.56M);
        }
        private static void WritePurchasesListToConsole(Dictionary<string, decimal> purchasesList, bool isPriceVisible, int filterDirection, decimal filterValue)
        {
            const string captionStr = "Shopping List";
            const string filtrStr = "Filter applied to the list. Items with a price {0} than {1} are displayed.";
            const string listStrWithPrice = "|{0,25}|{1,15}|";
            const string listStrWithoutPrice = "|{0,25}|";


            Console.WriteLine(captionStr);
            Console.WriteLine(BreakString);

            if (filterDirection != 0)
            {
                Console.WriteLine(filtrStr, filterDirection == 2 ? "higher" : "lower", filterValue.ToString("C"));
                Console.WriteLine(BreakString);
            }

            Console.WriteLine(isPriceVisible ? listStrWithPrice : listStrWithoutPrice, "Purchase name", "Price");

            foreach (KeyValuePair<string, decimal> keyValuePair in purchasesList)
            {
                if(filterDirection == 1 && keyValuePair.Value > filterValue) continue;
                if(filterDirection == 2 && keyValuePair.Value < filterValue) continue;

                Console.WriteLine(isPriceVisible ? listStrWithPrice: listStrWithoutPrice, keyValuePair.Key, keyValuePair.Value.ToString("C"));
            }

            Console.WriteLine(Environment.NewLine);
        }


        private static decimal GetPriceFilterValue()
        {
            bool isInputValid;
            decimal priceFilterValue;

            do
            {
                Console.WriteLine(BreakString);

                string priceFilterValueStr = GetStringFromConsole($"filter value [{0.5m:C}/{9.99m:C}]");

                isInputValid = decimal.TryParse(priceFilterValueStr, out priceFilterValue);

            } while (!isInputValid);

            return priceFilterValue;
        }
        private static KeyValuePair<string, decimal> GetNewPurchaseInfo()
        {
            bool isInputValid;

            string purchaseName;
            decimal purchasePrice;

            do
            {
                Console.WriteLine(BreakString);

                purchaseName = GetStringFromConsole("purchase name [Butter/Wine/Caviar/ e.t.c.]");
                string purchasePriseStr = GetStringFromConsole($"purchase price [{0.5m:C}/{9.99m:C}/ e.t.c.]");

                bool isValidPurchaseName = !string.IsNullOrWhiteSpace(purchaseName);
                bool isValidPurchasePrice = decimal.TryParse(purchasePriseStr, out purchasePrice);

                isInputValid = isValidPurchaseName || isValidPurchasePrice;


                if (!isInputValid)
                    Console.WriteLine("Incorrect input. Try again.");

            } while (!isInputValid);

            return new KeyValuePair<string, decimal>(purchaseName, purchasePrice);
        }



        private static string GetStringFromConsole(string text)
        {
            Console.Write(" Please input the {0}: ", text);
            return Console.ReadLine();
        }

        public static int GiveChoiceToUser(string[] options, string text = null)
        {
            Console.Write(BreakString);

            if(!string.IsNullOrWhiteSpace(text))
                Console.WriteLine("  {0} (Select option with the arrow keys.)", text);

            Console.CursorVisible = false;

            int selectedItem = 0;
            int cursorTopPos = Console.CursorTop;

            do
            {
                Console.SetCursorPosition(0, cursorTopPos);

                for (int i = 0; i < options.Length; i++)
                    Console.WriteLine("{0,4}{1}", selectedItem == i ? " >> " : String.Empty, options[i]);

                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedItem = --selectedItem < 0 ? options.Length - 1 : selectedItem;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedItem = ++selectedItem % options.Length;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        return selectedItem;
                }
            } while (true);
        }
    }
}
