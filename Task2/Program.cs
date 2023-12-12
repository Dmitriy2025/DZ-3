void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100); 
}

bool CheckCondition(int x)
{
    if (x%2 == 0) 
            return true;
        return false;
}


void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CheckCondition(array[i]) == true)
            count ++;
    Console.WriteLine(count);
}

Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);

