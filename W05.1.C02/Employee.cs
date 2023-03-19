class Employee : Person
{
    public double Salary;

    public Employee(string name, double salary) : base(name)
    {
        Name = name;
        Salary = salary;
    }
}