string[] array = new string[5] { "Hello", "HI", "Bye", "Wazzup", "Ola" }; // Array 
string[] SortedArray = new string[array.Length]; //Sorted array init

void SortArray (string[] array, string[] SortedArray) //Sort array function
{
    int count = 0;

    for (int i = 0; i < array.Length; i++) //find ellement with lenght less or equal 3
    {
        if (array[i].Length <= 3) 
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array) //Print array
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SortArray(array, SortedArray);
PrintArray(SortedArray);