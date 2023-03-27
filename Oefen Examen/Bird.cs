public class Bird : Creature, IFly, ISing
{
    public int Height
    {
        get { return Height; }
        set
        {
            if (value > 20) value = 20;
        }
    }

    public int Altitude
    {
        get { return Altitude; }
        set { }
    }

    public int Weight;

    public Bird(int height, int weight) : base(height, weight)
    {
        Height = height;
        Weight = weight;
    }

    public void Fly()
    {
        Altitude += 1;
    }

    public void Land()
    {
        Altitude = 0;
    }

    public string Sing()
    {
        return "Chirp chirp";
    }

    public bool Eat(string food)
    {
        if (food == "Worm" || food == "Seed" || food == "Insect")
        {
            Height += 3;
            Weight += 5;
            return true;
        }

        return false;
    }

    public override string PrintInfo()
    {
        Console.WriteLine($"{base.PrintInfo()}\n Altitude: {Altitude}");

        return $"{base.PrintInfo()}\n Altitude: {Altitude}";
    }

}