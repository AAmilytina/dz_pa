Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);
if (n%7==0 && n%23==0)
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");