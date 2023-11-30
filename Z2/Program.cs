Console.Clear();
Console.Write("Введите значение координаты точки x: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение координаты точки y: ");
int y = int.Parse(Console.ReadLine()!);
if ((y>0) && (x>0))
    Console.WriteLine("Точка в первой координатной  плоскости.");
if ((y>0) && (x<0))
    Console.WriteLine("Точка в второй координатной  плоскости."); 
if ((y<0) && (x<0))
    Console.WriteLine("Точка в третьей координатной  плоскости.");  
if ((y<0) && (x>0))
    Console.WriteLine("Точка в четвертой координатной  плоскости.");
