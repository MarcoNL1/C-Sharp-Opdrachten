class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");

        List<Person> personsList = new List<Person>()
        {
            john, jane
        };
        
        foreach (var p in personsList)
        {
            Console.WriteLine(p.Introduce());
            
            
            Student s = p as Student;
            if (s != null)
            {
                Console.WriteLine(s.Status());
            }
        }
    }
}