
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