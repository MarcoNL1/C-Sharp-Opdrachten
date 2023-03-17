string filePath = @"MyTextFile.txt";
string text = "";

using (StreamReader reader = new(filePath))
{
    text = reader.ReadToEnd();
}

using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine($"{text}");
}

Console.WriteLine(File.ReadAllText(filePath));