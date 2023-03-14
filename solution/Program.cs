string[] arr1 = new string[4] {"2", "hello", "pie", "world"};
string[] arr2 = new string[arr1.Length];
SecondArray(arr1, arr2);
PrintArray(arr2);

void SecondArray(string[] arr1, string[] arr2)
{
    int c = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[c] = arr1[i];
        c++;
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


