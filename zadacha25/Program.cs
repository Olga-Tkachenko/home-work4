// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// Например: 3,5-243; 2,4-16.
var numberA = int.Parse(Console.ReadLine()!);
var numberB = int.Parse(Console.ReadLine()!);

if(numberB<=0)
return;

var result = Math.Pow(numberA,numberB);
Console.WriteLine(result);

