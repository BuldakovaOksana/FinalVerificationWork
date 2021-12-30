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

void FillArrayEvenNumbers(int[] ArrayA)
{
    int[] ArrayB = new int[ArrayA.Length];
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] % 2 == 0)
        {
            ArrayB[i] = ArrayA[i];
            System.Console.Write($"{ArrayB[i]} ");
        }
    }
}

int[] ArrayA = GetArrayA(10, 1, 10);
PrintArray(ArrayA);
System.Console.WriteLine();
FillArrayEvenNumbers(ArrayA);
