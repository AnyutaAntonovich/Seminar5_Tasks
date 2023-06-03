// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Input the length for array:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int EvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}

int length = GetLength();
int[] array = GetArray(length);
string arrayToStr = String.Join(", ", array);
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"In array [{arrayToStr}], total {array.Length} numbers of which {EvenNumbers(array)} are even");