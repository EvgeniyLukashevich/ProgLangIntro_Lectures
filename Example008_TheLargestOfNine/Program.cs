int LargestNumOfTreeNums (int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    return max;
}

int a1 = 3;
int b1 = 32;
int c1 = 12;
int a2 = 11;
int b2 = 53;
int c2 = 147;
int a3 = 112;
int b3 = 2056;
int c3 = 2;

//Первый вариант
/*
int max1 = LargestNumOfTreeNums(a1, b1, c1);
int max2 = LargestNumOfTreeNums(a2, b2, c2);
int max3 = LargestNumOfTreeNums(a3, b3, c3);
int max = LargestNumOfTreeNums(max1, max2, max3);
Console.WriteLine(max);
*/

//Второй вариант
int max = LargestNumOfTreeNums(
LargestNumOfTreeNums(a1, b1, c1),
LargestNumOfTreeNums(a2, b2, c2),
LargestNumOfTreeNums(a3, b3, c3));
Console.WriteLine(max);