// Задача 43: Написать прогр,которая найдет точку пересечения двух прямых, заданных ур:
// y=k1*x+b1  y=k2*x+b2 Значения k1 k2 b1 b2 задаются пользователем.
Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*(b2-b1)/(k1-k2)+b1;
if(k1!=k2)
{
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {x},{y}");
}
else
{
  Console.WriteLine("Прямые не пересекаются"); 
} 
