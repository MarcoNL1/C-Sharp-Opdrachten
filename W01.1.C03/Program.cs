Console.WriteLine("What is the temperature in Celsius?");
int celsius = Convert.ToInt32(Console.ReadLine());
double fahrenheit = Convert.ToDouble(celsius * 1.8 + 32);
Console.WriteLine($"{celsius} C = {fahrenheit} F");
Console.WriteLine($"Rounded down that is {Math.Floor(fahrenheit)} F");