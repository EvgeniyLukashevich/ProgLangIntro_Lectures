/*
// Вид 1 (ничего не принимают, ничего не возвращают)
void Method1()
{
    Console.WriteLine("Check your back, bro");
}

// Вызываются методы первого вида следующим образом:
Method1();
*/

/*
//Вид 2 (принимает аргументы, но ничего не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Вызываются методы второго вида следующим образом:
string yourtxt = "приветики";
Method2(yourtxt);

//Либо
Method2("Текст сообщения");
*/
/*
void Method2_1(string msg, int count)
{
    int a = 0;
    while (a < count)
    {
        Console.WriteLine (msg);
        a++;
    }
}
Method2_1(count: 8, msg: "Тыц");
*/

/*
//Вид 3 (ничего не принимают, но что-то возвращают)

int Method3()
{
    return DateTime.Now.Year;
}

//Вызываются методы третьего вида следующим образом:
int y = Method3();
Console.WriteLine(y);
*/



//Вид 4 (что-то принимают и что-то возвращают)

/*
string Method4 (int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//Вызываются методы четвертого вида следующим образом:
string disco = Method4(8, "Туц ");
Console.WriteLine(disco);

*/

// Цикл for
/*
string Method4 (int count, string text)
{
    string result = string.Empty;
        //иниц счетчика / условие  /  счетчик  
    for (int i = 0;       i < 10;     i++)
    {
        result = result + text;
    }
    return result;
}

string disco = Method4(8, "Туц ");
Console.WriteLine(disco);
*/

//Цикл внутри цикла

/*
for (int a = 2; a <= 10; a++)
{
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{a} x {b} = {a*b}");
    }

    Console.WriteLine(); //Для перехода на новую строку
}
*/


// ЗАДАЧА. Работа с текстом
// Дан текст. В нём нужно все пробелы " " заменить черточками "_",
// маленькие буквы "к" заменить большими "К",
// а маленькие "с" заменить символом "$"
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "если бы вас послали вместо нашего милого Винцегероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

//                  string a = "qwerty"
// нумерация символов строки:   012345
// Например, a[3] это буква r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) 
            result = result + $"{newValue}";    
        else 
            result = result + $"{text[i]}";
    }
    return result;
}

string newTxt = Replace (text, ' ', '_');  //char в одинарных кавычках
Console.WriteLine(newTxt);
Console.WriteLine();

newTxt = Replace (newTxt, 'к', 'К');
Console.WriteLine(newTxt);
Console.WriteLine();

newTxt = Replace (newTxt, 'с', '$');
Console.WriteLine(newTxt);
Console.WriteLine();
*/

// Задача. Упорядочить массив от меньшего к большему
/*
int [] array = {1, 4, 2, 55, 7, 13, 6, 9, 21, 4, 6, 55, 13, 7, 1};

void PrintArray (int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ArraySort(int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < arrayLength; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(array);
ArraySort(array);
PrintArray(array);
*/

// Самостоятельная работа. 
//Адаптировать метод для упорядочивания массива от большего эл к меньшему

int [] array = {1, 4, 2, 55, 7, 13, 6, 9, 21, 4, 6, 55, 13, 7, 1, 7};

void PrintArray (int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ArraySort(int[] array)
{
    int arrayLength = array.Length;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < arrayLength; j++)
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(array);
ArraySort(array);
PrintArray(array);