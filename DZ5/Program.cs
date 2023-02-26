// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int abc;
Console.WriteLine("Введите трехзначное число abc ");
abc = Convert.ToInt32(Console.ReadLine());
int b = abc / 10 % 10;
if (abc > 99 && abc < 1000)
  Console.WriteLine(b);
  else if (abc < 100)
  Console.WriteLine("Вы ввели не трехзначное число, введите трехзначное число ");


