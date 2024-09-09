// See https://aka.ms/new-console-template for more information

string[] arrayOfStrings = ["guava", "apple", "moist", "bread", "car", "cat", "math", "book", "curry", "zebra", "animal", "jaberwoky", "plane", "rhombus", "generic", "couch", "sleep", "ceiling", "light", "tree", ""];
PrintArray(arrayOfStrings);
SortArrayForward(arrayOfStrings);
PrintArray(arrayOfStrings);
SortArrayBackward(arrayOfStrings);
PrintArray(arrayOfStrings);


void PrintArray(string[] array)
{
    Console.WriteLine("[");
    foreach (var word in array)
    {
        Console.Write($"{word}, ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

void SortArrayBackward(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[i][0] > array[j][0])
            {
                string left = array[i];
                array[i] = array[j];
                array[j] = left;
            }
        }
    }
}
void SortArrayForward(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[i][0] < array[j][0])
            {
                string left = array[i];
                array[i] = array[j];
                array[j] = left;
            }
        }
    }
}
