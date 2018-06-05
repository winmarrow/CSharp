using System;
using System.Runtime.Remoting.Channels;
using System.Text;

namespace CW_Lecture_1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Exercice_1();
            //Exercice_2();
            //Exercice_3();
            Exercice_4();
            ;

            //exit
            Console.ReadKey();
        }

        static void Exercice_1()
        {
            Console.Write("Введите дату рождения");
            string userInput = Console.ReadLine();

            DateTime dob;
            bool isValidDate = DateTime.TryParse(userInput, out dob);

            if (!isValidDate)
            {
                Console.WriteLine("Дата введена не верно - \" {0}\"", userInput);
                Console.ReadKey();
                return;
            }

            //if (dob >= DateTime.Now)
            //    Console.WriteLine("Не может исспользоваться дата в будующем");

            //else if (DateTime.Now.Year - dob.Year > 100) Console.WriteLine("ЧТооо,????? Щ_щ");
            //else
            //    Console.WriteLine(DateTime.Now.Year - dob.Year);

            if (dob >= DateTime.Now)
            {
                Console.WriteLine("Не может исспользоваться дата в будующем");
            }
            else
            {
                if (DateTime.Now.Year - dob.Year > 100)
                {
                    Console.WriteLine("ЧТооо,????? Щ_щ");
                }
                else
                {
                    int age = DateTime.Now.Year - dob.Year;
                    if (age < 18)
                    {
                        Console.WriteLine("");
                    }
                    else { Console.WriteLine("Можете продолжать"); }

                }
            }

            Console.WriteLine("Пожалуйста введите опцию" + "\r\nС Создать" + "\r\nО Открыть" + "\r\nУ Удалить");
            string optionInput = Console.ReadLine();

            const string c = "с";

            switch (optionInput)
            {
                case c:
                case "С":
                    Console.WriteLine("Записть '{0}' создана", Guid.NewGuid());
                    break;
                case "О":
                case "о":
                    Console.WriteLine("Открываю записть 1...");
                    break;
                case "У":
                case "у":
                    Console.WriteLine("записть не может быть удалена. У вас их нету.");
                    break;

                default:
                    Console.WriteLine("\"{0}\" - не валидная опция", optionInput);
                    break;
            }


            DayOfWeek dayOfWeek = DayOfWeek.Tuesday;

            switch (dob.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Tuesday:
                    break;

                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Родился в выходной");
                    break;
            }

            ConsoleKeyInfo info = Console.ReadKey();

            switch (info.Key)
            {
                case ConsoleKey.Backspace:
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Zoom:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.OemClear:
                    break;
                default:
                    break;
            }
        }

        static void Exercice_2()
        {
            const string inputMsg = "Введите {0}= ";
            const string equalMsg = "Значения Х и У равны";
            const string invalidInputMSg = "Введённые значения содержат ошибку";

            Console.Write(inputMsg, "X");
            string xInputString = Console.ReadLine();
            Console.Write(inputMsg, "Y");
            string yInputString = Console.ReadLine();


            bool isValidInput = uint.TryParse(xInputString, out uint x) & uint.TryParse(yInputString, out uint y);

            if (!isValidInput || x == 0 & y == 0)
            {
                Console.WriteLine(invalidInputMSg);
                Console.ReadKey();
                return;
            }

            if (x > y) Console.WriteLine($"Значение Х больше У на {x - y}");
            else if (x < y) Console.WriteLine($"Значение Х меньше У на {y - x}");
            else Console.WriteLine(equalMsg);

        }

        static void Exercice_3()
        {



            #region FOR



            int n = 150;
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = {0}", sum);

            //for (int i = n; i > 0 && i<10; i++)
            //{
            //    if(i%2 == 0) Console.WriteLine(i);
            //}

            //for (int i = 0, j = n; i < j; i++, j--)
            //{
            //    Console.WriteLine("{0} - {1}", i,j);
            //}

            for (int i = 1; i < 500; i++)
            {
                if (i % 27 == 0) break;
                if (i % 2 == 0) continue;

                Console.WriteLine(i);
            }

            #endregion

            #region WHILE / DO...WHILE



            while (DateTime.Now.Hour < 14 && DateTime.Now.Hour > 8)
            {

            }


            ;
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Console.WriteLine("You pressed a \"{0}\" key, its value is {1}", keyInfo.Key, (int)keyInfo.KeyChar);


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            #endregion

            string textOutput = "Some text input string.";

            foreach (char symbol in textOutput)
            {
                Console.WriteLine(symbol);
            }

        }

        static void Exercice_4()
        {
            const string choiceMsg = "\tВарианты:;\r\n 1 - двигать курсором\r\n 2 - выводить списком;\r\n 2 - выводить последнюю команду.\r\n Выберите вариант вывод [1-3]:";
            const string invalidInputMsg = "Введены неверные значения...";
            const string outputMsg = "Иду {0}";

            Console.Write(choiceMsg);

            string choiceString = Console.ReadLine();
            bool isInputValid = sbyte.TryParse(choiceString, out sbyte choice);

            if (!isInputValid || choice > 3)
                Console.WriteLine(invalidInputMsg);

            int cursorX = 0;
            int cursorY = 0;


            Console.Clear();


            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if(choice==3) Console.Clear();

                Console.SetCursorPosition(0, 0);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine(outputMsg, "вверх ");
                        if(cursorY>0)cursorY--;
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine(outputMsg, "вниз  ");
                        if (cursorY< Console.BufferHeight) cursorY++;
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine(outputMsg, "влево ");
                        if (cursorX > 0) cursorX--;
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine(outputMsg, "вправо");
                        if (cursorX < Console.BufferWidth) cursorX++;
                        break;
                }

                if (choice == 1)
                {
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.Write(keyInfo.KeyChar);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
