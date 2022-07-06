Console.WriteLine("Введите X1: ");
int X1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите X2: ");
int Y1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите Z1: ");
int Z1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите X2: ");
int X2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int Y2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите Z2: ");
int Z2 = Convert.ToInt32 (Console.ReadLine());

void  Zadacha21 (int X1, int Y1, int Z1, int X2, int Y2, int Z2  )
{
   double range = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
   Console.WriteLine ($"Расстояние между заданными точками в пространстве = {range}");    
}

Zadacha21( X1,  Y1,  Z1,  X2,  Y2,  Z2  );