//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3. 78 -> 2

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string number = Convert.ToString(num);
Console.WriteLine(number.Length);

// int GetCount(int number)
// {
//     int count = 0;
//     while(number>0)
//     {
//         number/=10;              // В этом случае число 0 даст 0 цифр, хотя там 1 цифра.
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Количество цифр в числе: "+GetCount(num));

