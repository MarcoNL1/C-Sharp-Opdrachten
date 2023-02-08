var studentGrades = new List<double>()
{
    7, 5.5, 3.2, 10, 4.5
};

int passed = 0;
foreach (double i in studentGrades)
{
    if (i > 5.4)
    {
        passed++;
    }
}

Console.WriteLine($"{passed} out of {studentGrades.Count} students passed");