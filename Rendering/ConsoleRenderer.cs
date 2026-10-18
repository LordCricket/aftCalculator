public static class Renderer
{
    public static void DrawHeader()
    {
        Console.Clear();
        Console.WriteLine("==================================");
        Console.WriteLine("===Army Fitness Test Calculator===");
        Console.WriteLine("==================================");
        Console.WriteLine();
    }

    public static void DrawSeparator()
    {
        Console.WriteLine();
        Console.WriteLine("==================================");
        Console.WriteLine();
    }

    public static void DrawEvent()
    {
        DrawSeparator();
        Console.WriteLine("===Events===");
        Console.WriteLine();
    }

    public static void DrawResults()
    {
        DrawSeparator();
        Console.WriteLine("===Results===");
        Console.WriteLine();
    }
}