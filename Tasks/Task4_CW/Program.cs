// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray()
{
    int[] array = new int[123];
    
    for (int i = 0; i < 123; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
    return array;
}

int TwoDigit(int[] array)
{
    int count = 0;
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count = count + 1;
        }
    }
       
    return count;

}

int[] array = GetArray();
string arrayToStr = String.Join(", ", array);
int twoDigit = TwoDigit(array);
Console.WriteLine($"In array [{arrayToStr}], of which two-digit [{twoDigit}]");