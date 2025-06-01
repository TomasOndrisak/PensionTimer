using PensionTimer.Items;

namespace PensionTimer.Models
{
    public class MainPageModel
    {
        List<RetirementInfo> retirementAgesMale = new List<RetirementInfo>
        {
            new RetirementInfo(1943, 0, 60),
            new RetirementInfo(1944, 0, 60, 9),
            new RetirementInfo(1945, 0, 61, 6),
            new RetirementInfo(1946, 0, 62),
            new RetirementInfo(1955, 0, 62, 0, 76),
            new RetirementInfo(1956, 0, 62, 0, 76),
        };
        List<RetirementInfo> retirementAgesFemale = new List<RetirementInfo>();

        private UserInfo? UserInfo;

        //Todo: 
        // 1. Create valid data
        // 2. Check for kids for males
        public RetirementInfo GetRetirementAge(UserInfo userInfo)
        {
            UserInfo = userInfo;
            var yearOfBirth = UserInfo.BirthDate.Year;

            if (yearOfBirth >= 1967)
            {
                if (UserInfo.IsFemale)
                {
                    return retirementAgesFemale.Where(x => x.YearOfBirth == yearOfBirth).First(x => x.NumberOfChildren == UserInfo.NumberOfChildren);
                }
                else
                {
                    // Todo: male with kids
                    return retirementAgesMale.Where(x => x.YearOfBirth == yearOfBirth).First();
                }
            }
            else if (yearOfBirth <= 1943)
            {
                if (UserInfo.IsFemale)
                {
                    return retirementAgesFemale.Where(x => x.YearOfBirth == yearOfBirth).First(x => x.NumberOfChildren == UserInfo.NumberOfChildren);
                }
                else
                {
                    // Todo: male with kids
                    return retirementAgesMale.First(x => x.YearOfBirth == yearOfBirth);
                }
            }

            if (UserInfo.IsFemale)
            {
                return retirementAgesFemale.First(x => x.YearOfBirth == yearOfBirth && x.NumberOfChildren == UserInfo.NumberOfChildren);
            }
            else
            {
                return retirementAgesMale.First(x => x.YearOfBirth == yearOfBirth && x.NumberOfChildren == UserInfo.NumberOfChildren);
            }
        }

    }
}
