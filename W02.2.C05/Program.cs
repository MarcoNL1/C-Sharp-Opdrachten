double[] grades = {7, 5.5, 3.2, 10, 4.5};
int passed = 0;

foreach (double grade in grades)
{
    if (grade >= 5.5)
    {
        passed++;
    }
}

Console.WriteLine($"{passed} out of {grades.Length} students passed");