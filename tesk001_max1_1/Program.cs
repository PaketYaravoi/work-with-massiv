// Напишем программу котороая будет находить максимальное число из 9 чисел

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int number1 = 3;
int number2 = 5;
int number3 = 12;
int number4 = 1555;
int number5 = 10;
int number6 = 2;
int number7 = 25;
int number8 = 33;
int number9 = 9;

/*int max1 = max(number1, number2, number3) ;
int max2 = max(number4, number5, number6) ;
int max3 = max(number7, number8, number9) ;
int answer = max(max1, max2, max3);

мы можем внутри аргумента передать

*/

int answer = max(max(number1, number2, number3),
    max(number4, number5, number6),
    max(number7, number8, number9));

Console.WriteLine(answer);