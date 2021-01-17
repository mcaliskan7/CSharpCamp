using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            //num1 = 65

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers2 = numbers1;
            numbers2[0] = 999;
            //numbers1[0] = 999
        }
    }
}
