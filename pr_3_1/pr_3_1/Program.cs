using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: "); 
        // Пользователь вводит размер массива
        int size = int.Parse(Console.ReadLine());

        int[] T = new int[size];
        // Создаем массив T указанного размера
        Random random = new Random();
        // Создаем объект Random для генерации случайных чисел

        Console.WriteLine("Элементы массива:");

        for (int i = 0; i < size; i++)
        {
            T[i] = random.Next(-50, 51);
            // Заполнение элементов массива случайными числами от -50 до 50
            Console.WriteLine(T[i]);
            // Вывод элементов массива
        }

        int sum = 0;
        // Инициализируем переменную sum для хранения суммы положительных элементов

        // Перебираем каждый элемент массива T
        foreach (int num in T)
        {
            if (num > 0)
                // Проверяем, является ли число положительным
            {
                sum += num;
                // Если число положительное, добавляем его к сумме
            }
        }

        Console.WriteLine("Сумма положительных элементов массива: " + sum);
        // Выводим сумму положительных элементов массива
    }
}

