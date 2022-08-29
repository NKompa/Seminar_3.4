// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма = "+GetSum(num));

int GetSum (int number)
{
    int sum = 0;
    int count = 0;

    while (number>count)
    {
        count++;
        sum+=count;
    }
    return sum;
}
