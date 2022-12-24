Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int maximum = a;

if (b > maximum) maximum = b;
if (c > maximum) maximum = c;

Console.Write("Максимальное значение: ");
Console.Write(maximum);