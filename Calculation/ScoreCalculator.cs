using System.Runtime.CompilerServices;

public static class Calculator
{
    public static int CalculateScore(int age, string gender, int performance, List<ScoreRecord> records, bool higherIsBetter)
    {
        int highest = 0;

        foreach (ScoreRecord record in records)
        {
            if 
            (
                age >= record.AgeMin
                && age <= record.AgeMax
                && gender == record.Gender.ToLowerInvariant() 
                && ((higherIsBetter && performance >= record.Performance) || (!higherIsBetter && performance <= record.Performance))
            )
            {
                if (record.Points > highest)
                {
                    highest = record.Points;
                }
            }
        }
        return highest;
    }

    public static int TotalScore(int mdl, int hrp, int sdc, int plk, int tmr)
    {
        return mdl + hrp + sdc + plk + tmr;
    }

    public static bool PassFail(int mdl, int hrp, int sdc, int plk, int tmr)
    {
        if (mdl >= 60 && hrp >= 60 && sdc >= 60 && plk >= 60 && tmr >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}