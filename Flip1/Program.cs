using System.ComponentModel.DataAnnotations;
using System.Globalization;

SummingTask1(new int[] { 1, 5, 3, 8});
SummingTask2(new int[] { 1, 5, 3, 8});
SummingTask3(new int[] { 1, 2, 3, 4, 5, 6});
SummingTask4(3, new int[] { 1, 5, 3, 8, 6, 2 });
/*SummingTask5(3);
SummingTask6(2);
SummingTask7(3);*/

static void PrintArray(int [] input)
{
    for (int i = 0; i < input.Length; i++)
    {
     Console.Write(input[i] + " ");
    }
}

static int[] SummingTask1(int[] input)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        Console.Write(input[i] + " ");
        
    }
    Console.WriteLine();
    return input;
}

static int[] SummingTask2(int [] input)
{
    PrintArray(input);
    int[] result = new int[input.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = input[i];
    }
    PrintArray(result);
    Console.WriteLine();
    return result;
}

static int[] SummingTask3(int[] input)
{
    PrintArray(input);
    int[] result = new int[input.Length * 2];
    for (int j = input.Length - 1; j >= 0; j--)
    {
        result[j] = input[j];
        Console.Write(result[j] + " ");
    }
    Console.WriteLine();
    return result;
}

static int[] SummingTask4(int blockSize, int[] input)
{
    int[] result = new int[input.Length];
    for (int i = blockSize; i < input.Length; i++)
    {
        result[i] = input[i];
        Console.Write(result[i] + " ");
    }
    for (int j = 0; j < blockSize; j++)
    {
        result[j] = input[j];
        Console.Write(result[j] + " ");
    }
    return result;
}

static void SummingTask5(int width)
{
    int[] array = { 1, 5, 3, 8, 7, 4 };
    for (int i = width - 1; i >= 0; i--)
    {
        Console.Write(array[i] + " ");
    }
    for (int j = array.Length - 1; j >= width ; j--)
    {
        Console.Write(array[j] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask6(int width)
{
    int [] array = { 1, 2, 3, 4};
    int length = array.Length - 1;
    int [] secondArray = new int[length * 2];
    for (int i = 0; i <= length; i++)
    {
        Console.Write(array[i] + " ");
    }
    for (int j = width - 1; j >= 0; j--)
    {
        secondArray[j] = array[j];
        Console.Write(secondArray[j] + " ");
    }
    for (int k = array.Length - 1; k >= width; k--)
    {
        secondArray[k] = array[k];
        Console.Write(secondArray[k] + " ");
    }
    Console.WriteLine("");
}

static void SummingTask7(int blockSize)
{
    int[] array = { 1, 2, 3, 4, 5, 6};
    int length = array.Length - 1;
    for (int i = 0; i <= length; i++)
    {
        Console.Write(array[i] + " ");
    }
    int[] secondArray = new int [length * 2];
    for (int i = blockSize; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    for (int j = 0; j < blockSize; j++)
    {
        Console.Write(array[j] + " ");
    }
    Console.WriteLine("");
}
