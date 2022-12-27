string[] mass = { "Wor", "Google", "221", "Lololo" };

string[] array = NewArray(mass);
Console.WriteLine($"[{string.Join(", ", array)}]");

string[] NewArray(string[] array)
{
    int leng = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) leng++;
    }
    string[] result = new string[leng];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            result[k] = array[j];
            k++;
        }
    }
    return result;
}
