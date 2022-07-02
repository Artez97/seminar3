/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

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

void Sqrt(int Number)
{
    for (int i = 1; i < Number; i++)
    {
        Console.WriteLine(" 5 ^3 = " + Math.Pow(i, 2));
    }
}
int Number = GetNumber("Введите число");

Sqrt(Number);