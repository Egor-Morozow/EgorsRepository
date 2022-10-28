using System.ComponentModel.DataAnnotations;
SummingTask1();
SummingTask2();
SummingTask3();
SummingTask4(2);
SummingTask5(3);
SummingTask6(2);
SummingTask7(3);

static void SummingTask1()
{
    int[] Array = { 1, 5, 3, 8, 9, 56, 454 };
    for (int i = Array.Length - 1; i >= 0; i--)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask2()
{
    int[] Array = { 1, 5, 3, 8, };
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    int length = Array.Length - 1;
    int[] SecondArray = new int [length * 2];
    for (int j = 0; j <= length; j++)
    {
        SecondArray[j] = Array[j];
        Console.Write(SecondArray[j] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask3()
{
    int[] Array = { 1, 5, 3, 8, 15, 232, 544, 55 };
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    int length = Array.Length - 1;
    int[] SecondArray = new int[length * 2];
    for (int j = length; j >= 0; j--)
    {
        SecondArray[j] = Array[j];
        Console.Write(SecondArray[j] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask4(int blockSize)
{
    int[] Array = { 1, 2, 3, 4};
    for (int i = blockSize; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    for (int j = 0; j < blockSize; j++)
    {
        Console.Write(Array[j] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask5(int width)
{
    int[] Array = { 1, 5, 3, 8, 7, 4 };
    for (int i = width - 1; i >= 0; i--)
    {
        Console.Write(Array[i] + " ");
    }
    for (int j = Array.Length - 1; j >= width ; j--)
    {
        Console.Write(Array[j] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask6(int width)
{
    int [] Array = { 1, 2, 3, 4};
    int length = Array.Length - 1;
    int [] SecondArray = new int[length * 2];
    for (int i = 0; i <= length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    for (int j = width - 1; j >= 0; j--)
    {
        SecondArray[j] = Array[j];
        Console.Write(SecondArray[j] + " ");
    }
    for (int k = Array.Length - 1; k >= width; k--)
    {
        SecondArray[k] = Array[k];
        Console.Write(SecondArray[k] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask7(int blockSize)
{
    int[] Array = { 1, 2, 3, 4, 5, 6};
    int length = Array.Length - 1;
    for (int i = 0; i <= length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    int[] SecondArray = new int [length * 2];
    for (int i = blockSize; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    for (int j = 0; j < blockSize; j++)
    {
        Console.Write(Array[j] + " ");
    }
    Console.WriteLine("");
}
