using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>();
            var rand = new Random();
            int listSize = 20;

            for (int i = 0; i < listSize; i++)
            {
                list.Add(rand.Next(0, 100));
            }

            int sum = 0;
            for (int i = 2; i < listSize; i = i + 2)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);

            int maxValueInList = list.Max();
            int secondMaxValueInList = 0;

            for (int i = 0; i < listSize; i++)
            {
                if (list[i] > secondMaxValueInList && list[i] < maxValueInList)
                {
                    secondMaxValueInList = list[i];
                }
            }


            Console.WriteLine();
            Console.WriteLine($"secondMaxValueInList: {secondMaxValueInList}, item: {list.IndexOf(secondMaxValueInList)}    sum: {sum}");


        }
    }
}
