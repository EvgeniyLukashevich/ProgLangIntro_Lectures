int LargestNumOfTreeNums (int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    return max;
}
//               0   1   2   3   4    5    6   7   8
int [] array = {12, 24, 33, 47, 541, 164, 73, 85, 19};

int max = LargestNumOfTreeNums(
LargestNumOfTreeNums(array[0], array[1], array[2]),
LargestNumOfTreeNums(array[3], array[4], array[5]),
LargestNumOfTreeNums(array[6], array[7], array[8]));
Console.WriteLine(max);