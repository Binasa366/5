//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

        int Max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] == max)
                    max = array[i];
            }
            return max;
        }
        int Min(int[] array)
        {
            int min = Max(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] == min)
                    min = array[i];
            }
            return min;
        }
        int Minus(int[] array)
        {
            int minus = 0;
            minus = Max(array) - Min(array);
            return minus;
        }


        Console.WriteLine("Введите размер массива");
        int A = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[A];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine($"Махсимальное число = {Max(array)}");
        Console.WriteLine($"Минимальное число = {Min(array)}");
        Console.WriteLine($"Разность между максимульным и минимальным = {Minus(array)}");

    }
}