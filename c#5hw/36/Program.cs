// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;
class HelloWorld
{
    static void Main()
    {

        void FillArray(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
                array[i] = new Random().Next(100, 1000);
        }

        void PrintArray(int[] array)
        {
            foreach (var el in array)
                Console.Write($"{el} ");
            Console.WriteLine();
        }

        Console.WriteLine("Введите размер массива");
        int A = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[A];
        FillArray(array);
        PrintArray(array);
        int sum = 0;

        for (int i = 0; i < array.Length; i += 2)
            sum = sum + array[i];

        Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sum}"); ;


    }
}