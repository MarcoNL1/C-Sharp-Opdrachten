Console.WriteLine("What is your age?");
int yourAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the age of the student next to you?");
int studentAge = Convert.ToInt32(Console.ReadLine());

if (yourAge == studentAge)
{
    Console.WriteLine("Your ages are equal");
}
else if (yourAge > studentAge)
{
    Console.WriteLine("You are older");
}
else
{
    Console.WriteLine("You are younger");
}