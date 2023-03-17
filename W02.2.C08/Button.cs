class Button
{
    public bool IsPressed = false;
    public int TimesPressed = 0;

    public Button()
    {
        
    }

    public void Press()
    {
        IsPressed = !IsPressed; 
        TimesPressed++;
    }

    public void Info()
    {
        Console.WriteLine(IsPressed ? "Button is pressed." : "Button is not pressed.");
        Console.WriteLine($"Pressed {TimesPressed} times.");
    }
}