public class Player
{
    public string Name;
    public int HealthPoints;
    public int Power;

    public Player(string name, int power)
    {
        Name = name;
        HealthPoints = 100;
        Power = power;
    }

    public bool IsAlive()
    {
        if (HealthPoints > 0) return true;
        return false;
    }

    public int TakeDamage(int power)
    {
        HealthPoints -= power;
        if (HealthPoints < 0) HealthPoints = 0;
        IsAlive();
        return HealthPoints;
    }
}