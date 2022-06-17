string[] StartArray = {"дом", "поле", "сом", "луна", "173", "вишня", "2", "солнце", "сон"};

string PrintArray(string[] array)
{
    int size = array.Length;
    string res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i]} ";
    }
    res += "] ";
    return res;
}
string[] SortArray(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            result[i] = array[i];
    }
    return result;
}

System.Console.Write(PrintArray(StartArray));
string[] resultArray = SortArray(StartArray);
System.Console.Write(" -> ");
System.Console.Write(PrintArray(resultArray));