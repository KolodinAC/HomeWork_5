// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


int userLength = UserInput();

float[] userArray = GenerateArray(userLength);

Console.Write("Ваш массив:  ");

PrintArray(userArray);

userArray = SortUserArray(userArray);

Console.Write("Отсортированный массив:  ");

PrintArray(userArray);

float diffBetweenMinMax =  GetDiffBetweenMaxMin(userArray);

Console.WriteLine("Разница между min и max элементами Вашего массива составляет:  " + diffBetweenMinMax);




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

float[] GenerateArray(int userLength)
{
    Random random = new Random();
    float[] array = new float[userLength];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
    return array;
}

void PrintArray(float[] collection)
{
    Console.WriteLine("[{0}]", string.Join(", ", collection));
}

float[] SortUserArray(float[] collection)
{
    float temp = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        for (int index2 = 1; index2 < collection.Length; index2++)
        {
            if (collection[index2] < collection[index2 - 1])
            {
                temp = collection[index2 - 1];
                collection[index2 - 1] = collection[index2];
                collection[index2] = temp;
            }
        }
    }
    return collection;
}

float GetDiffBetweenMaxMin(float[] collection)
{
    float diff = 0;

    if(collection[0] < 0)
    {
        diff = collection[collection.Length - 1] + collection[0];
    }
    else
    {
        diff = collection[collection.Length - 1] - collection[0];
    }
    return diff;
}