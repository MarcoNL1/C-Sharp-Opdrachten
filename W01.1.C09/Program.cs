Console.WriteLine("Enter an age:");
int age = Convert.ToInt32(Console.ReadLine());

string typeAge = age switch
{
    >= 0 and < 13 => $"Age {age}: a child",
    > 12 and < 20 => $"Age {age}: a teenager",
    > 19 and < 151 => $"Age {age}: an adult",
    _ => $"Age {age}: invalid"

};

Console.WriteLine(typeAge);
