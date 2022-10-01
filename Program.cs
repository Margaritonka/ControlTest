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


string[] first = { "Sam", "Alexander", "Tom", "Margarita", "Bob", "Ror" };
string[] second = new string[CountArraySize(first)];

CopyElem(first, second);