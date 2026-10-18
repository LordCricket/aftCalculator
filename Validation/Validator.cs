public static class Validator
{
    public static string GetValidGender()
    {
        while (true)
        {
            Console.Write("Enter Gender: ");

            string? input = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            if (input == "male" || input == "female")
            {
                return input;
            }
            Console.WriteLine("Invalid! Try again");
        }
    }

    public static int GetValidInteger(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= min && value <= max )
            {
                return value;
            }
            Console.WriteLine("Invalid! Try again");
        }
    }

    public static int GetValidTime(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            string[] times = (input ?? "").Split(':');

            if (times.Length == 2)
            {
                if (int.TryParse(times[0], out int minutes) && int.TryParse(times[1], out int seconds))
                {
                    if (minutes >= 0 && seconds >= 0 && seconds < 60 && minutes <= 60)
                    {
                        return (minutes * 60) + seconds;
                    }
                }
            }
            Console.WriteLine("Invalid! Try again");
        }
    }
}