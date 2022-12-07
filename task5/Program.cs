
Console.WriteLine("Введите трёхзначное число");
int N = Convert.ToInt32(Console.ReadLine());

if ((N < 1000) && (N > 99))
{ Console.WriteLine("Последняя цифра числа:" +N%10);}
else 
{Console.WriteLine("Неправильное число");
}