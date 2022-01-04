// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] GetArrayA(int size, int leftBound, int rightBound)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(leftBound, rightBound);
    }
    return Array;
}


void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{Array[i]} ");
    }
}

int FindLength(int[] ArrayA)
{
    int count = 0;

    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] % 2 == 0)
        {
            count++;

        }
    }
    return count;
}

int[] GetArrayB(int[] ArrayA, int size)
{
    int index = 0;
    int[] ArrayB = new int[size];
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] % 2 == 0)
        {
            ArrayB[index] = ArrayA[i];
            index++;
        }
    }
    return ArrayB;
}


int[] ArrayA = GetArrayA(10, 1, 10);
PrintArray(ArrayA);
int i = FindLength(ArrayA);
System.Console.WriteLine();
int[] ArrayB = GetArrayB(ArrayA, i);
PrintArray(ArrayB);
