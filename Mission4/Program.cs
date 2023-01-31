// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
  Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}
int N = Prompt("Введите число");
int i = 1;
while (i <= N) //меньше или равно
{
  double result = Math.Pow(i, 2);
  System.Console.WriteLine(result);
  i++;
}