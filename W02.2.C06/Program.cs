class Program
{
    public static void Main()
    {
        List<Pet> pets = new List<Pet>(3)
        {
            new("Dog", "Nugent"),
            new("Cat", "Steve"),
            new("Goldfish", "Brutus")
        };

        foreach (Pet pet in pets)
        {
            Console.WriteLine($"I have a {pet.WhatAmI} named {pet.Name}");
        }
    }
}