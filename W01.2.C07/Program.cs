var tasks = new List<string>()
{

};
Console.WriteLine($"Amount of tasks: {tasks.Count}");
foreach(var i in tasks)
{
    Console.WriteLine(i);
}
tasks.Add("Mow lawn");
tasks.Add("Pay taxes");
Console.WriteLine($"Amount of tasks: {tasks.Count}");
foreach(var i in tasks)
{
    Console.WriteLine(i);
}
tasks.Remove("Mow lawn");
tasks.Add("Shopping");
Console.WriteLine($"Amount of tasks: {tasks.Count}");
foreach(var i in tasks)
{
    Console.WriteLine(i);
}
