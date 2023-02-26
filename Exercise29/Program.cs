// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenArray(int size, int lowRange, int highRange)   //Сделал универсальный генератор одномерного массива из size элементов
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(lowRange, highRange + 1);

    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"Создан массив: [{string.Join(", ", array)}]");
}

// Далее для красоты чуть лишнего, и хоть какой то осмысленности действиям...
System.Console.WriteLine("Сгенерировать массив?  1 - Да, 2 - Нет");
string? answer = Console.ReadLine();

if(answer == "1")
{
    PrintArray(GenArray(8, -20, 20));
}
else if(answer == "2")
{
    System.Console.WriteLine("пока-пока");
}
else System.Console.WriteLine("Ничего не понимаю!");
