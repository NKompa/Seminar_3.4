//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3. 78 -> 2

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// string result = Convert.ToString(num);
// int GetCount(string number)

int GetCount(int number)
{
    int count = 0;
    while(number>0)
    {
        number/=10;
        count++;
    }
    return count;
}
Console.WriteLine("Количество цифр в числе: "+GetCount(num));

