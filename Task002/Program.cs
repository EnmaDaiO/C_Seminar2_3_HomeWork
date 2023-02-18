// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного 
// числа или сообщает, что третьей цифры нет.
// 78 -> третьей цифры нет
// 3267900 -> 6

// Console.Write("Введите семизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number >= 100 && number <= 9999999) // //К сожалению не работает такое условие, т.к. нет понимания как двигать запятую слева направо в значении которое мы находим в строке 10. 
// {
//     int thirdValueLeft = number / 10000 % 10; // Сработало бы если бы была возможность перемещать запятую слева направо. 
//     Console.WriteLine("Третья цифра слева " + thirdValueLeft );
//     int thirdValueRight = number % 1000 / 100;
//     Console.WriteLine("Третья цифра справа " + thirdValueRight );
// }
// else if ( number < 100)
// {
//     Console.WriteLine("Число не трехзначное");
// }
//======================================
Console.Write("Введите семизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number >= 1000000 && number <= 9999999)
{
    int thirdValueLeft = number / 10000 % 10; 
    Console.WriteLine("Третья цифра слева " + thirdValueLeft );
    int thirdValueRight = number % 1000 / 100;
    Console.WriteLine("Третья цифра справа " + thirdValueRight );
}
else if ( number < 1000000)
{
    Console.WriteLine("Число не семизначное");
}