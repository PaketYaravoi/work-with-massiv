
// Напишем программу котороая будет находить максимальное число из 9 чисел
Console.Clear();
int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {51, 32, 353, 44, 95, 16, 47, 28, 9,};

int answer = max(
    max(array[0], array[1], array[2]),
    max(array[3], array[4], array[5]),
    max(array[6], array[7], array[8])
);

Console.WriteLine(answer);





