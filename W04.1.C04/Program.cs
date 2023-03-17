using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        StreamReader reader = new("Cars.json");
        string File2Json = reader.ReadToEnd();
        List<Car> listOfObjects = JsonConvert.DeserializeObject<List<Car>>(File2Json)!;
        reader.Close();

        foreach (var car in listOfObjects)
        {
            for (int i = 0; i < 5; i++)
            {
                car.Drive();
            }
        }

        StreamWriter writer = new("Cars.json");
        string List2Json = JsonConvert.SerializeObject(listOfObjects);
        writer.Write(List2Json);
        writer.Close();
    }
}