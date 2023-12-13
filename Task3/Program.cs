
void InputArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble()* (100 - 1) + 1; // от 1 до 100
    }
}
Console.Clear();
double[] array = new double[10];
InputArray(array);

double maxNumber = array[0];
double minNumber = array[0];

for (int j = 1; j < array.Length; j++)
{
    if (array[j] > maxNumber)
    {
        maxNumber = array[j];
    }
    else if (array[j] < minNumber)
    {
        minNumber = array[j];
    }
}

double difference = maxNumber - minNumber;

Console.WriteLine($"Максимальное число: {maxNumber}");
Console.WriteLine($"Минимальное число: {minNumber}");
Console.WriteLine($"Разница: {difference}");
