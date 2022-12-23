Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    Console.Write("Последняя цифра: ");
    Console.Write (n % 10);
}
else
{
    Console.Write("Ошибка");
}