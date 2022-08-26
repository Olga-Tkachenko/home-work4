// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// Например: 452-11; 82-10; 9012-12.
var number = int.Parse(Console.ReadLine()!);

if (number<=0)
return;

var result = SumNum(number);
Console.WriteLine(result);

int SumNum(int a)
{
    int result = 0;
    while(a>0)
    {
        result=result+a%10;
        a=a/10;
    }
    return result;
}
