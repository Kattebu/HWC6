// Задача 41: Поль-ль вводит М чисел. Сколько чисел больше нуля ввел п-ль.
Console.Write("Введите M чисел: ");
string[]array=Console.ReadLine().Split(" ");
Console.WriteLine(String.Join(";",array));
 int amount = 0;
for(int i=0; i<array.Length;i++)
{
    int a = Convert.ToInt32(array[i]);
    if(a>0)
    {
        amount++;
    }
}
Console.WriteLine($"Колическтво положительных чисел: {amount}");