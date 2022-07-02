/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int GetPal(int x, int y, int i, int z, int v)
{
    if (x == y && z == v)
        Console.WriteLine("полиндром");
    else
        Console.WriteLine("не полиндром");
}


int x = GetNumber("Введите первое цифру числа:");
int y = GetNumber("Введите второе цифру числа:");
int i = GetNumber("Введите третью цифру числа:");
int z = GetNumber("Введите четвертую цифру числа:");
int v = GetNumber("Введите пятую цифру числа:");
int Pal1 = GetPal(x, y, i, z, v);
return result;
Console.WriteLine($"({x}, {y}, {i}, {z}, {v}) число");
*/
/*n = int(input("Введите число:"))
temp = n
rev = 0
while (n > 0):
    dig = n % 10
    rev = rev * 10 + dig
    n = n // 10
if (temp == rev):
    print("Это палиндром!")
else:
    print("Это не палиндром!")*/


/*int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;

}

void result(string[] args)
{
    Console.WriteLine("Число");
    string s = Console.ReadLine();
    char[] str = s.ToCharArray();
    char a, b;
    Array.Reverse(str);
    if (str[str.Length - 1] == '-')
    {
        a = str[str.Length - 1];
        b = str[str.Length - 2];
        str[str.Length - 2] = a;
        str[str.Length - 1] = b;
    }
    Console.Write(str);
    Console.ReadKey();
    if (GetNumber == )

        Console.WriteLine("палиндром");

    else

        Console.WriteLine("не палиндром");
}

result(args);*/


Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])

        Console.WriteLine($"Ваше число: {number} - палиндром.");

    else
        Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");