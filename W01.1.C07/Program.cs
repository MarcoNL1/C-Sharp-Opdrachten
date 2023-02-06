Console.WriteLine("You have one chance to guess this six-letter word:\nLe..th");
string word = Console.ReadLine();

if (word == "Length")
{
    Console.WriteLine("Correct!");
}
else if (word == "length")
{
    Console.WriteLine("Kind of correct; the case was just wrong");
}
else if (word.Length != 6)
{
    Console.WriteLine("Incorrect! That is not even a six-letter word!");
}
else
{
    Console.WriteLine("Incorrect!");
}
