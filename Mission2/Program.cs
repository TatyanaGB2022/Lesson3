// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
  System.Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}

string GetCoord(int quorter)
{
  if (quorter == 1)
  {
    return "x > 0; y > 0";
  }
  if (quorter == 2)
  {
    return "x < 0, y > 0";
  }
  if (quorter == 3)
  {
    return "x < 0, y < 0";
  }
  return "x > 0, y < 0";
}

int a = Prompt("Введите номер четверти");
if (a > 4 || a < 1)
{
  System.Console.WriteLine("Введен не корректный номер четверти");
}
else 
  
{
string result = GetCoord(a);
System.Console.WriteLine(result);
}