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
