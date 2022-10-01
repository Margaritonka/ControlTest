string[] CopyElem(string[] first, string[] second)
{
    int j = 0;
    for (int i = 0; i < first.Length; i++)
    {
        if (first[i].Length < 4)
        {
            second[j] = first[i];
            j++;
        }
    }
    return second;
}

void PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        if (i != matr.Length - 1) Console.Write($"{matr[i]}, ");
        else Console.Write($"{matr[i]} ");
    }
}

int CountArraySize(string[] first)
{
    int sum = 0;
    for (int i = 0; i < first.Length; i++)
    {
        if (first[i].Length < 4)
        {
            sum += 1;
        }
    }
    return sum;
}


string[] first = { "Sam", "Alexander", "Tom", "Margarita", "Bob", "Ron" };
string[] second = new string[CountArraySize(first)];

CopyElem(first, second);
Console.WriteLine($"Задан массив: ");
PrintArray(first);
Console.WriteLine();
Console.WriteLine($"Новый массив будет из {CountArraySize(first)} элементов: ");
PrintArray(second);