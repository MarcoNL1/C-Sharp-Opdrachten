public class Artifact
{
    public double Rarity;
    public double Condition;

    public Artifact(double rarity, double condition)
    {
        Rarity = rarity;
        Condition = condition;
    }

    public double GetValue(double rarity, double condition)
    {
        double value = rarity * condition;
        return value;
    }

    public void Appraise()
    {
        Console.WriteLine($"Value: {GetValue(Rarity, Condition)}");
    }

    public bool IsEqualTo(Artifact artifact)
    {
        return Rarity == Condition;
    }
}