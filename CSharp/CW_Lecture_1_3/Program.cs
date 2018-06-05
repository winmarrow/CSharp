using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CW_Lecture_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Exercice1();
            Exercice2();


            Console.ReadKey();
        }

        static void Exercice1()
        {

            #region Chechked/Uncheed

            //byte b0 = (byte)int.MaxValue; Error

            //действия в контролируемом котексте
            checked
            {
                //byte b0 = (byte)int.MaxValue; Error
            }

            //действия в НЕконтролируемом котексте
            unchecked
            {
                int int0 = int.MaxValue + (int)Math.Pow(int.MaxValue, 10);

                Console.WriteLine(int0);
            }

            #endregion

            #region Increment/Decrement

            int counter = 0;
            counter = counter + 1;
            //Постинкремент
            counter++;
            //Преинкремент
            ++counter;
            Console.WriteLine($"counter {counter++}"); //counter =2
            Console.WriteLine($"counter {counter}");

            //НЕ ИССПОЛЬЗУЙТЕ несколько таких операций в одной строке !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine($"1:counter {counter++},2:counter {counter++},3:counter { counter++ * counter++}");


            counter = counter - 1;
            //Постдекримент
            counter--;
            //Предекримент
            --counter;

            Console.WriteLine($"counter {counter--}");

            Console.WriteLine($"counter {--counter}");

            #endregion

            #region Type

            object o = 150;
            Type type1 = o.GetType();

            Console.WriteLine($"type is {type1}");

            Type type2 = typeof(Program);
            Console.WriteLine($"type of Program is {type2}");

            #endregion

            #region AND OR XOR

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Regex regex = new Regex("[0-9]");
            bool isNameValid = !string.IsNullOrWhiteSpace(name) && name.Length >= 2 && !name.Contains(' ') && !regex.IsMatch(name);

            Console.WriteLine("Name {0} {1} valid", name, isNameValid ? "is" : "isn\'t");
            //string text1 = null;
            //string text2 = "";
            //string text3 = string.Empty;

            //string text4 = "   ";
            //string text5 = " \r\n  ";

            //Console.WriteLine($"text4: { string.IsNullOrWhiteSpace(text4)}\r\ntext5: {string.IsNullOrWhiteSpace(text5)}");


            Console.Write("Введите возвраст: ");
            string ageString = Console.ReadLine();

            int ageValue;
            bool isAgeValid = int.TryParse(ageString, out ageValue);
            Console.WriteLine($"Значение введено {(isAgeValid ? string.Empty : "не")}верно");

            const string errorMesg = "\"{0}\" неправильный фрмат ввода";
            const string outputMsg = "Вы родились в {0} году";

            DateTime date = DateTime.Now;
            int year = date.AddYears(-ageValue).Year;

            string msg = isAgeValid && ageValue >= 0 && ageValue < 120
                ? string.Format(outputMsg, year)
                : string.Format(errorMesg, ageString);
            Console.WriteLine(msg);



            #endregion
        }

        static void Exercice2()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("ВВедите значения  трё целых чисел А, Б и С в диапазоне [0-255]");

            byte a, b, c;
            string tempString;
            bool isInputValid;

            Console.Write("Введите переменную А: ");
            tempString = Console.ReadLine();
            isInputValid = byte.TryParse(tempString, out a);
            if(!isInputValid)
                Console.WriteLine($"Эта песня хороша, начинай с начала. Ввод \"{tempString}\" не корретен или не удовлетворяет условиям выше");

            Console.Write("Переменную В: ");
            tempString = Console.ReadLine();
            isInputValid = byte.TryParse(tempString, out b);
            if (!isInputValid)
                Console.WriteLine($"Эта песня хороша, начинай с начала. Ввод \"{tempString}\" не корретен или не удовлетворяет условиям выше");
            Console.Write("И переменную С: ");
            tempString = Console.ReadLine();
            isInputValid = byte.TryParse(tempString, out c);
            if (!isInputValid)
                Console.WriteLine($"Эта песня хороша, начинай с начала. Ввод \"{tempString}\" не корретен или не удовлетворяет условиям выше");

            bool aIsChet = a % 2 == 0 & a!=0;
            bool bIsChet = b % 2 == 0 & b != 0;
            bool cIsChet = c % 2 == 0 & c != 0;

            string chetChetResultString = (aIsChet ? string.Empty : $", число А={a} не чётное")
                                          + (bIsChet ? string.Empty : $", число B={b} не чётное")
                                          + (cIsChet ? string.Empty : $", число C={c} не чётное");

            Console.WriteLine($"Проверка на чётность {(aIsChet && bIsChet && cIsChet? string.Empty: "не")}пройдена{chetChetResultString}.");

            double d = b * b - 4.0 * a * c;


            Console.WriteLine($"Уравнение {(d>=0? string.Empty : "не")}имеет корни{(d >= 0? (d == 0.0? "1 корень или корни равны": "2 веществнных корня"): string.Empty)}.");
            
        }
    }
}
