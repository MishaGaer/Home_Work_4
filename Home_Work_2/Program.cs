/*
Напишите программу, 
которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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
            Console.WriteLine("Вы ввели не верное значение. Пожалуйста исправьте введенное значение.");
        }
    }
}
//Cчетчик цифр
int Digit(int number)
{
    int result = 0;
    while(true)
    {
        if (number>0)
        {
        result += number % 10;
        number = number/10;
        }
        else
        {
            break;
        }
    }
    return result;
}
//Основной код
int number = InputControl("Введите число сумму цифр которого Вы хотите узнать:");
int result = Digit(number);
Console.WriteLine(result);

