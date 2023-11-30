Console.Clear();
Console.Write("Введите натулаьное число: ");
int n = int.Parse(Console.ReadLine()!);
if (n<10)
    Console.WriteLine($"n");
else
{
    while (n>0)
    {
        int res = n%10;
        n /=  10;
        if (n>0)
            Console.WriteLine(res + ",");
        else 
        Console.WriteLine(res);
    }
}