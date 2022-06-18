string[] array = new string[6] { "1234", "123", "-2", "Russia", "world", "Mos" };
string[] newArray = new string[array.Length];
int count = 0;
void ResultArray(string[] array, string[] newArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(array, newArray);
PrintArray(newArray);
