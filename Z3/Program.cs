Console.Clear();
Console.Write("Введите целое число от 10 до 99:  ");
int n = int.Parse(Console.ReadLine()!);
if (n<10 || n>99)
   { Console.WriteLine("Вы ошиблись!\nВведите целое число от 10 до 99.");
    n = int.Parse(Console.ReadLine()!);
   }

    int n1 = n/10;
    int n2 = n%10;
    if (n1>n2)
    Console.WriteLine($"{n1}");
    else
    Console.WriteLine($"{n2}");