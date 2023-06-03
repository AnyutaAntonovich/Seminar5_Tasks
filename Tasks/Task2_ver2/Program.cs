// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// по номеру индекса (если индекс нечетный, то ++)

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Input the length for array:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    
    return sum;
}

int length = GetLength();
int[] array = GetArray(length);
string arrayToStr = String.Join(", ", array);
int sum = Sum(array);
Console.WriteLine($"In array [{arrayToStr}], total {array.Length} numbers of which the sum of the numbers in odd positions is {sum} are even");