string[] arr1 = new string[7] { "2485", "Hi", "World", "Number", "11", "123", "456" };
string[] arr2 = new string[arr1.Length];
void FindArr2(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Массив: ");
PrintArray(arr1);
FindArr2(arr1, arr2);
System.Console.Write("Массив, в котором 3 или меньше символов: ");
PrintArray(arr2);