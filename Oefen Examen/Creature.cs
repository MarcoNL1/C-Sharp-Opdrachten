public class Creature
{
    public int Height
    {
        get { return Height; }
        set
        {
            if (value < 0) value = 0;
        }
    }

    private int Weight
    {
        get { return Weight;}
        set
        {
            if (value < 0) value = 0;
        }
    }
    
    public Creature(int height, int weight)
    {
        Height = height;
        Weight = weight;
        
        Console.WriteLine();
    }

    public virtual string PrintInfo()
    {
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Weight: {Weight}");
        
        return $"Height: {Height}\n Weight: {Weight}";
    }

    public bool Eat(string food)
    {
        bool boolReturn = true;
        return boolReturn;
    }

}