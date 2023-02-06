Console.WriteLine("How many seconds?");
int seconds = Convert.ToInt32(Console.ReadLine());

TimeSpan time = TimeSpan.FromSeconds(seconds);

string calculatedTime = time .ToString(@"hh\:mm\:ss");

Console.WriteLine(calculatedTime);