using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class CsvReader
{
    public static List<ScoreRecord> LoadScoreRecords(string filePath)
    {
        List<ScoreRecord> records = new List<ScoreRecord>();

        foreach(string line in File.ReadLines(filePath).Skip(1))
        {
            string[] parts = line.Split(',');

            ScoreRecord record = new ScoreRecord
            {
                AgeMin = int.Parse(parts[0]),
                AgeMax = int.Parse(parts[1]),
                Gender = parts[2],
                Performance = int.Parse(parts[3]),
                Points = int.Parse(parts[4])
            };

            records.Add(record);
        }

        return records;
    }
}