using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива, разделенные запятой:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результат:");
        foreach (var item in resultArray)
        {
            Console.WriteLine(item);
        }
    }
    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }