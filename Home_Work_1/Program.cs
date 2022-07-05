/*
Задача 25: 
Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//возведение
int PowerNumber(int number, int power)
{
    int result = number;
    for (int i = 1; i < power; i++)
    {
        result = result * number;
    }
    return result;
}
//Основной код
int number = InputControl("Введите число которое хотите возвести в степень.");
int power = InputControl("Введите степень, в которую хотите возвести число.");
int result = PowerNumber(number, power);
Console.WriteLine($"{number}^{power}={result}");




/*
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
      Console.WriteLine(message);
      if (int.TryParse(Console.ReadLine(), out int number))
      {
        return number;
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
      }
    }
}



//Основной код
int number = InputControl("Введите число которое хотите возвести в степень.");
int power = InputControl("Введите степень, в которую хотите возвести число.");
Console.WriteLine($"{number}^{power}={Math.Pow(number, power)}");
*/