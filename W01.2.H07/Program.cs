var courses = new List<double>()
{
    6.5, 9.5, 4, 5, 4.5, 10, 7.1
};

for (int i = 0; i < courses.Count; i ++)
{
    Console.WriteLine($"Grade: {courses[i]}");

    while (true)
    {
        if (courses[i] < 5.5)
        {
            Console.WriteLine("Retake this course? y/n");
            string retake = Console.ReadLine().ToLower();

            if (retake == "n")
            {
                break;
            }

            if (retake == "y")
            {
                courses[i] += 1;
            }

            else
            {
                continue;
            }
        }

        break;
    }
}

Console.WriteLine("Final grades: ");

foreach (var t in courses)
{
    Console.WriteLine(t);
}