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

        Person person = new("John", pets); 

        foreach (Pet pet in person.Pets)
        {
            Console.WriteLine($"{person.Name} has a {pet.WhatAmI} named {pet.Name}");
        }
    }
}