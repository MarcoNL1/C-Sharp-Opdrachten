public class Scale
{
    public bool UseKg;

    public Scale()
    {
        UseKg = true;
    }

    public static double ConvertKgToLbs(double kilo)
    {
        return kilo * 2.2;
    }

    public string DisplayWeight(double weight)
    {
        if (UseKg)
        {
            return $"{weight} kg";
        }
        return $"{ConvertKgToLbs(weight)} lbs";
    }
}