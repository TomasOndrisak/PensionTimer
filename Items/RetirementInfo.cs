namespace PensionTimer.Items;
public class RetirementInfo
{
    public int YearOfBirth { get; set; }
    public int NumberOfChildren { get; set; }

    public int RetirementAgeYears { get; set; }
    public int RetirementAgeMonths { get; set; }
    public int RetirmeentAgeDays { get; set; }

    public RetirementInfo(int yearOfBirth, int numberOfChildren, int retirementAgeYears, int retirementAgeMoths = 0, int retirmeentAgeDays = 0)
    {
        YearOfBirth = yearOfBirth;
        NumberOfChildren = numberOfChildren;
        RetirementAgeYears = retirementAgeYears;
        RetirementAgeMonths = retirementAgeMoths;
        RetirmeentAgeDays = retirmeentAgeDays;
    }
}
