using System;

namespace CW_Lecture_1_7
{
    public class Parser
    {
        public void StringToHuman()
        {

        }

        public bool ResizeArray(ref int[] array, int newLenght)
        {
            if (array == null || newLenght < 0)return false;

            int[] tempArray = new int[newLenght];

            for (int i = 0; i<newLenght && i <array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;

            return true;
        }

        public void Test1( string msg, string header)
        {
            Console.WriteLine($"[{header}]:{msg}");
        }

        public void Test1(string msg)
        {
            Console.WriteLine($"[Info]:{msg}");
        }

        public void Test2(string msg, string header="INFO")
        {
            Console.WriteLine($"[{header}]:{msg}");
        }

        public void Test3(string msg, string header)
        {
            Console.WriteLine($"[{header}]:{msg}");
        }
        public void Test3(string msg)
        {
            Test3(msg, "INFO");
        }

        public void Test(params string[] strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public void T(params string[] strings)
        {

        }

    }
}