// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.


int userLength = UserInput();

int[] userArray = GenerateArray(userLength);

PrintArray(userArray);

int sumOfNumb = GetSumOfNonEvenIndexNumbers(userArray);

Console.WriteLine($"Сумма чисел с нечетными индексами составляет: {sumOfNumb}.");



// Methods:

int UserInput()
{
    Console.Write("Введите желаемый размер массива:\t");
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

int[] GenerateArray(int userLength)
{
    Random random = new Random();
    int[] array = new int[userLength];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}

int GetSumOfNonEvenIndexNumbers(int[] collection)
{
    int sum = 0;
    for (var i = 1; i < collection.Length; i++)
    {
        sum += collection[i];
        i++;
    }
    return sum;
}