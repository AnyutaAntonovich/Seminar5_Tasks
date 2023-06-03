// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(int length)
{
    double[] array = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,1000);
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Input the length for array:");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
        {
            max = array[i];            
        }
        else if (min > array[i])
        {
            min = array[i];
        }
        
        i = i + 1;
    }
    
    return max-min;
}

int length = GetLength();
double[] array = GetArray(length);
string arrayToStr = String.Join(", ", array);
double difference = Difference(array);
Console.WriteLine($"In array [{arrayToStr}], total {array.Length} numbers, the difference between the largest and smallest numbers is {difference}");