using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        try
        {
            StreamReader reader = new("People.json");
            string File2Json = reader.ReadToEnd();
            List<Person> listOfObjects = JsonConvert.DeserializeObject<List<Person>>(File2Json)!;
            reader.Close();

            foreach (var person in listOfObjects)
            {
                foreach (var car in person.OwnedCars)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        car.Drive();
                    }
                }
            }

            StreamWriter writer = new("People.json");
            string List2Json = JsonConvert.SerializeObject(listOfObjects);
            writer.Write(List2Json);
            writer.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}