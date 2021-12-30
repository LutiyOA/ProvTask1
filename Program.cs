
/* 
Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[1, 2, 3, 4] -> [2, 4]
[1, 3, 4, 5, 7, 1, 3] -> [4]
[2, -4, 6] -> [2, -4, 6]
[1, 3, 5] -> []
*/

string printArray(int[] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.Length; i++)
        result += $"{array[i]}; ";

    return result.TrimEnd();
}

int getRandom(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int[] setArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = getRandom(min, max);

    return array;
}

int[] getOddArray(int[] array)
{
    int[] result = new int[array.Length];
    int countResult = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            result[countResult++] = array[i];


    int[] result2 = new int[countResult];
    for (int i = 0; i < countResult; i++)
        result2[i] = result[i];

    return result2;
}

void solveTask()
{
    int length = 100;
    int min = -100;
    int max = 100;

    int[] array = setArray(length, min, max);

    int[] resultArray = getOddArray(array);

    Console.WriteLine($"[{printArray(array)}] -> [{printArray(resultArray)}]");

}

solveTask();