string filePath = @"MyTextFile.txt";
string text = "";

// Create a new text file and write some content to it
using (StreamReader reader = new(filePath))
{
    text = reader.ReadToEnd();
}

using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine($"{text}\nAdded line.");
}
