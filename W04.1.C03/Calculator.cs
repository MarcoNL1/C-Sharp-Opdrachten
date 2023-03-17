using Newtonsoft.Json;

public static class Calculator
{
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }

    public static double Modulo(double num1, double num2)
    {
        return num1 % num2;
    }

    public static void StoreInMemory(double num1)
    {
        StreamWriter writer = new StreamWriter("Memory.json");
        writer.Write(JsonConvert.SerializeObject(num1));
        writer.Close();
    }

    public static double RestoreFromMemory()
    {
        StreamReader reader = new StreamReader("Memory.json");
        string jsonString = reader.ReadToEnd();
        reader.Close();
        var fromjson = JsonConvert.DeserializeObject<double>(jsonString)!;

        return fromjson;
    }
}