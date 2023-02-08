double critChance = 0.33;
int bossHP = 1000;
var random = new Random();

while (bossHP > 0)
{
    int attack = 50;
    bool crit = (random.NextDouble() < critChance) ? true : false;

    if (crit)
    {
        attack *= 2;
    }

    bossHP -= attack;


    Console.WriteLine($"Boss HP: {bossHP}");
    Console.WriteLine($"Damage: {attack}\n");
    if (bossHP == 0)
    {
        Console.WriteLine("Boss defeated");
        break;
    }

    continue;
}