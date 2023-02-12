Console.WriteLine("Give a number (1-9): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    number = 1;
}

if (number > 9)
{
    number = 9;
}

for (int i = 0; i <= number; i++)
{
    for (int j = 0; j <= number; j++)
    {
        Console.Write((i == 0? j : (j == 0? i + "|" : i*j)) + "\t");
    }
    Console.Write("\n");
}

