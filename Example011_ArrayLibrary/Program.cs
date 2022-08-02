void FillArray (int [] collection)
{
    int lenth = collection.Length;
    int index = 0;
    while (index < lenth)
    {
        collection [index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int [] col)
{
    int lenth = col.Length;
    int index = 0;
    while (index < lenth)
    {
        Console.Write ($"{col[index]} ");
        index++;
    }
}

int IndexOf (int [] collection, int find)
{
    int lenth = collection.Length;
    int index = 0;
    int position = -1;

    while (index < lenth)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];  //указываем, что в массиве будет 10 элементов

FillArray(array);
PrintArray(array);
int pos = IndexOf(array, 5);
Console.WriteLine($"Индекс искомого числа - {pos}");

