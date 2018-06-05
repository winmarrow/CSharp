using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lecture_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            const int numberOfPeriods = 12;

            const string inputMsg = " Введите {0}: ";
            const string paymentTypeMsg = "Вида платежа:\r\n 1 - аннуитетный платеж - это равный по сумме ежемесячный платеж по кредиту;\r\n 2 - дифференцированный платеж -  это ежемесячный платеж, уменьшающийся к концу срока кредитования.\r\n Выберите циру [1-2]:";
            const string invalidInputMsg = "Введены неверные значения...";
            const string tableLineMsg = " | {0,6} | {1,13:0.##}\u00A4 | {2,13:0.##}\u00A4 | {3,13:0.##}\u00A4 | {4,13:0.##}\u00A4 |";
            const string tableFooterLineMsg = " | Итого: | {0,30:0.##}\u00A4 | {1,13:0.##}\u00A4 | {2,13:0.##}\u00A4 |";

            string borderString = new string('=', Console.BufferWidth - 1);

            Console.WriteLine(borderString);

            //input
            Console.Write(inputMsg, "cумму кредитования, \u00A4");
            string creditAmountString = Console.ReadLine();

            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            Console.Write(inputMsg, $"ставку кредитования, % [1 - 100% как 15{separator}5% ]");
            string creditRateString = Console.ReadLine();
            Console.WriteLine(borderString);

            bool numbersAreValid = decimal.TryParse(creditAmountString, out decimal originalCreditAmount) &
                                   double.TryParse(creditRateString, out double creditInterestRate);


            if (!numbersAreValid || originalCreditAmount <= 1 || (creditInterestRate < 1 & creditInterestRate > 100))
            {
                Console.WriteLine(invalidInputMsg);
                Console.ReadKey();
                return;
            }

            Console.Write(paymentTypeMsg);
            string paymentTypeString = Console.ReadLine();
            Console.WriteLine(borderString);

            bool paymentTypeIsValid = int.TryParse(paymentTypeString, out int paymentType);

            if (!paymentTypeIsValid)
            {
                Console.WriteLine(invalidInputMsg);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(tableLineMsg, "Период", "Задолженность", "Начисленные %",
                "Основной долг", "Сумма платежа");


            decimal sumOfInterestCharges = 0m;
            decimal sumOfPayments = 0m;
            decimal debt = originalCreditAmount;

            creditInterestRate *= 0.01;


            if (paymentType == 1) //аннуитетный платеж
            {
                double monthlyCreditInterestRate = creditInterestRate / 12;
                decimal amountOfPayment = originalCreditAmount *
                                          (decimal)(monthlyCreditInterestRate +
                                                     monthlyCreditInterestRate /
                                                     (Math.Pow(1 + monthlyCreditInterestRate, 12d) - 1d));

                for (int period = 1; period <= 12; period++)
                {
                    decimal interestCharges = debt * (decimal)monthlyCreditInterestRate;
                    decimal repaymentOfCredit = amountOfPayment - interestCharges;

                    Console.WriteLine(tableLineMsg, period, debt, interestCharges,
                        repaymentOfCredit, amountOfPayment);

                    debt -= repaymentOfCredit;

                    sumOfInterestCharges += interestCharges;
                    sumOfPayments += amountOfPayment;
                }
            }
            else //дифференцированный платеж
            {
                decimal repaymentOfCredit = originalCreditAmount / numberOfPeriods;
                int currentYear = DateTime.Today.Year;

                for (int period = 1; period <= 12; period++)
                {
                    decimal interestCharges =
                        debt * (decimal)(creditInterestRate * DateTime.DaysInMonth(currentYear, period) / 365d);
                    decimal amountOfPayment = repaymentOfCredit + interestCharges;

                    Console.WriteLine(tableLineMsg, period, debt, interestCharges,
                        repaymentOfCredit, amountOfPayment);

                    debt -= repaymentOfCredit;

                    sumOfInterestCharges += interestCharges;
                    sumOfPayments += amountOfPayment;
                }
            }


            Console.WriteLine(borderString);
            Console.WriteLine(tableFooterLineMsg, sumOfInterestCharges, originalCreditAmount, sumOfPayments);
            Console.WriteLine(borderString);



            //Exit
            Console.ReadKey();
        }
    }
}
