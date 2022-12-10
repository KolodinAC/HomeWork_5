// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.



int minN = UserInput();
int maxN = UserInput();
int lengthA = UserInput();

int[] array = GenerateArray(minN, maxN , lengthA);

PrintArray(array);

int countOfeven = GetCountOfEvenNumbers(array);

Console.WriteLine($"Количество четных чисел в данном массиве составляет: {countOfeven}.");





// Methods:

int UserInput()
{
    Console.Write("Введите минимальное и максимальное значения эелементов и желаемый размер массива:\t");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum && num > 0)
    {
        return num;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int GetCountOfEvenNumbers(int[] collection)
{
    int count = 0;
    for (var i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}