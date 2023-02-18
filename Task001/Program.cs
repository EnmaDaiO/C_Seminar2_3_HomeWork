//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
 Console.Write("Введите число от 100 до 999: ");
 int number = Convert.ToInt32(Console.ReadLine());
 if (number < 999 && number > 100)
 {
    int secondValue = number % 100 / 10;
    Console.WriteLine("Вторая цифра числа "+ number + " равна " + secondValue);
 }
else
{
    Console.WriteLine("Число " + number + " не является трехзначным");
}