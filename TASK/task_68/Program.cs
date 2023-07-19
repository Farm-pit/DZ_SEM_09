// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


ulong ReadInt(string text, string error = "Error")
{
    try
    {
        System.Console.Write(text);
        return Convert.ToUInt64(Console.ReadLine());
    }
    catch
    {
      System.Console.WriteLine(error);
      return 0;
    }
}
  

  ulong A(ulong n, ulong m)
  {
    if(n == 0) return m + 1;
    else if(n != 0 && m == 0) return A(n - 1,1);
    else return A(n -1,A(n,m - 1));
    
  }

void Main()
{
ulong number1 = ReadInt("Введите число 1: ");
ulong number2 = ReadInt("Введите число 2: ");

System.Console.WriteLine(A(number1,number2));
}

Main();

