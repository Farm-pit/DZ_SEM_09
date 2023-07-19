// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text, string error = "Данные были введены ошибочно")
{
    try
    {
        System.Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        System.Console.WriteLine(error);
        return 0;
    }

}

int CountToValue(int value1, int value2)
{
    if (value1 > value2) return 0;
    return CountToValue(value1 + 1, value2) + value1;
}


void Main()
{
    int value1 = ReadInt("Введите число: ");
    int value2 = ReadInt("Введите число: ");
    if (value1 > value2) System.Console.WriteLine($"M = {value2}; N = {value1} -> {CountToValue(value2, value1)}" );
    else System.Console.WriteLine($"M = {value1}; N = {value2} -> {CountToValue(value1, value2)}");


}
Main();