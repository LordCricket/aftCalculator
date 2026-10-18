using System.Numerics;

Renderer.DrawHeader();

int age = Validator.GetValidInteger("Enter Age: ", 17, 100);
string gender = Validator.GetValidGender();

Renderer.DrawEvent();

List<ScoreRecord> mdlRecords = CsvReader.LoadScoreRecords("Data/MDL.csv");
List<ScoreRecord> hrpRecords = CsvReader.LoadScoreRecords("Data/HRP.csv");
List<ScoreRecord> sdcRecords = CsvReader.LoadScoreRecords("Data/SDC.csv");
List<ScoreRecord> plkRecords = CsvReader.LoadScoreRecords("Data/PLK.csv");
List<ScoreRecord> tmrRecords = CsvReader.LoadScoreRecords("Data/2MR.csv");

int mdl = Validator.GetValidInteger("Enter Maximum Deadlift: ", 60, 350);
int hrp = Validator.GetValidInteger("Enter Hand-Release Pushups: ", 4, 62);
int sdc = Validator.GetValidTime("Enter Sprint-Drag-Carry: ");
int plk = Validator.GetValidTime("Enter Plank: ");
int tmr = Validator.GetValidTime("Enter 2-Mile: ");

int mdlScore = Calculator.CalculateScore(age, gender, mdl, mdlRecords, true);
int hrpScore = Calculator.CalculateScore(age, gender, hrp, hrpRecords, true);
int sdcScore = Calculator.CalculateScore(age, gender, sdc, sdcRecords, false);
int plkScore = Calculator.CalculateScore(age, gender, plk, plkRecords, true);
int tmrScore = Calculator.CalculateScore(age, gender, tmr, tmrRecords, false);

Renderer.DrawResults();

Console.WriteLine($"MDL: {mdlScore}");
Console.WriteLine($"HRP: {hrpScore}");
Console.WriteLine($"SDC: {sdcScore}");
Console.WriteLine($"PLK: {plkScore}");
Console.WriteLine($"2MR: {tmrScore}");

Console.WriteLine("---");

int total = Calculator.TotalScore(mdlScore, hrpScore, sdcScore, plkScore, tmrScore);
Console.WriteLine($"Total Score: {total}");

if (Calculator.PassFail(mdlScore, hrpScore, sdcScore, plkScore, tmrScore))
{
    Console.WriteLine("Status: PASS");
}
else
{
    Console.WriteLine("Status: FAIL");
}