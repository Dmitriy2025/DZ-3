Console.Clear();

int number = new Random().Next(1, 10001);
string NumberString = number.ToString();
Console.WriteLine($"Сгенерированное число: {number}");

int length = NumberString.Length;
int [] result = new int[length];

for (int j = length - 1; j >= 0; j--)
{
    result[j] = number % 10;
    number /= 10;
}

Console.Write("Массив: ");
Console.WriteLine(string.Join(", ", result));
