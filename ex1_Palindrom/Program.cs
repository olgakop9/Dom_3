//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void palindrom()
{
    int number1 = new Random().Next(1, 100000); //для случайных чисел
    Console.Write("Insert 5-digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;

    if (nul < 1 || nul > 9)
    {
        Console.WriteLine(number + " -> " + "Not 5-digit number");
    }
    else if (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine(number + " -> Yes, this is palindrom");
    }
    else
    {
        Console.WriteLine(number + " -> No, this is not palindrom");
    }
}
for (int i = 0; i < 10; i++)
{
    palindrom();
}