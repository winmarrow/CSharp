using System;
using System.Text;
using System.Threading;

namespace HW_Lecture_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.CursorVisible = false; 

            const string timeMark = "{time}"; // так помечается место для времени
            const char borederTopChar = '_';
            const char borederBottomChar = '‾';
            const char borderLeftRightChar = '|';
            const char spaceChar = ' ';

            // С этими можно играться
            const char backgroundChar = '·'; // spaceChar; можно задать фон текста
            const int lineSize = 20; //15; // длина бегущей строки, 15 маловато
            const int sleepInterval = 150; //Интервал обновления
            string[] strings = //выводимые строки
            {
                "Минское время {time}. ",
                "Говорят и показывают все телестанции страны... "
            };

            //Выводим рамку
            Console.WriteLine(new string(borederTopChar, lineSize + 2));
            Console.WriteLine("{0}{1}{0}", borderLeftRightChar, new string(backgroundChar, lineSize));
            Console.WriteLine(new string(borederBottomChar, lineSize + 2));

            //Забиваем все строки в буфер
            StringBuilder buffer = new StringBuilder(new string(spaceChar, lineSize));
            foreach (string str in strings)
                buffer.Append(str);

            buffer.Replace(spaceChar, backgroundChar); //Устанавливаем символ для фона

            Console.ForegroundColor = ConsoleColor.DarkYellow; //Цвет текста
            string oldTime = timeMark;
            int currentPosition = 0;

            while (true)
            {
                //'Обновляем' время в буфере, если оно изменилось
                string newTime = DateTime.Now.ToLongTimeString();
                if (!newTime.Equals(oldTime))
                {
                    buffer.Replace(oldTime, newTime);
                    oldTime = newTime;
                }

                int charsToBufferEnd = buffer.Length - currentPosition; // Находим остаток до конца буфера

                Console.SetCursorPosition(1, 1); // прыгаем в начало бегущей стоки

                if (charsToBufferEnd >= lineSize) //если хватает то виыводим так
                    Console.Write(buffer.ToString(currentPosition, lineSize));
                else // если нет, то добисываем с начала буфера
                {
                    Console.Write(buffer.ToString(currentPosition, charsToBufferEnd));
                    Console.Write(buffer.ToString(0, lineSize - charsToBufferEnd));
                }

                Thread.Sleep(sleepInterval); //Поток спит
                currentPosition = ++currentPosition % buffer.Length; //Идём на следующий символ
            }
        }
    }
}
