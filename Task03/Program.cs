// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24, 5 -> 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetMult (int number)
{
    int mult = 1;

    for (int i = 1; i <= number; i++)
    {
        mult = mult*i;
    }
    return mult;
}

// {
//     int mult = 1;
//     int count = 1;

//     while (number>count)
//     {
//         count++;
//         mult*=count;
//     }
//     return mult;
// }
Console.WriteLine("Произведение = "+GetMult(num));