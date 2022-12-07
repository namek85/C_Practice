Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int P = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int K = Convert.ToInt32(Console.ReadLine());
int max = 0;
 if (N > P)
 {
     max = N;
 }
  else 
 {
    max = P;
 }

 if (max > K)
 { Console.WriteLine("max = " + max);}
 else {Console.WriteLine ("max = " + K);}
