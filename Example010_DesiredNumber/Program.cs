int [] array = {19, 82, 63, 46, 52, 61, 57, 84, 52, 5, 32, 11, 52};
int n = array.Length;
int find = 52;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}