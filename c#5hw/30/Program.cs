        void FillArray(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
                array[i] = new Random().Next(1, 1000);
        }

        void PrintArray(int[] array)
        {
            foreach (var el in array)
                Console.Write($"{el} ");
            Console.WriteLine();
        }

        void FillArray1(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int i = 0; i < size; i++)
            {
                temp = array[i];
                int z = new Random().Next(0, size);
                array[i] = array[z];
                array[z] = temp;
            }
            return;
        }
        void FillArray2(int[] array)
        {
            int temp;
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return;
        }


        Console.WriteLine("Введите размер массива");
        int array1_size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[array1_size];
        FillArray(array);
        Console.WriteLine($"Исходный массив:");
        PrintArray(array);

        FillArray2(array);
        Console.WriteLine($"Исходный массив, сортированный от большего к меньшему:");
        PrintArray(array);

        FillArray1(array);
        Console.WriteLine($"Случайно перемешанный массив:");
        PrintArray(array);

