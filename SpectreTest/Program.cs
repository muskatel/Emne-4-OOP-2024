using Spectre.Console;

public static class Program
{
    public static void Main(string[] args)
    {
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItem("Apple", 112, Color.Yellow)
            .AddItem("Orange", 54, Color.Green)
            .AddItem("Banana", 33, Color.Red));
    }
}