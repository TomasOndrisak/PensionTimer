using PensionTimer.Items;

namespace PensionTimer.Models
{
    public class MainPageModel
    {
        //TODO: Make sure retirement infos are valid
        List<RetirementInfo> retirementAgesMale = new List<RetirementInfo>
        {
            new RetirementInfo(1943, 0, 60, 0, 0),
            new RetirementInfo(1944, 0, 60, 9, 0),
            new RetirementInfo(1945, 0, 61, 6, 0),
            new RetirementInfo(1946, 0, 62, 0, 0),
            new RetirementInfo(1947, 0, 62, 0, 0),
            new RetirementInfo(1948, 0, 62, 0, 0),
            new RetirementInfo(1949, 0, 62, 0, 0),
            new RetirementInfo(1950, 0, 62, 0, 0),
            new RetirementInfo(1951, 0, 62, 0, 0),
            new RetirementInfo(1952, 0, 62, 0, 0),
            new RetirementInfo(1953, 0, 62, 0, 0),
            new RetirementInfo(1954, 0, 62, 0, 0),
            new RetirementInfo(1955, 0, 62, 2, 16),
            new RetirementInfo(1956, 0, 62, 4, 19),
            new RetirementInfo(1957, 0, 62, 6, 0),
            new RetirementInfo(1958, 0, 62, 8, 0),
            new RetirementInfo(1959, 0, 62, 10, 0),
            new RetirementInfo(1960, 0, 63, 0, 0),
            new RetirementInfo(1961, 0, 63, 2, 0),
            new RetirementInfo(1962, 0, 63, 4, 0),
            new RetirementInfo(1963, 0, 63, 6, 0),
            new RetirementInfo(1964, 0, 63, 8, 0),
            new RetirementInfo(1965, 0, 63, 10, 0),
            new RetirementInfo(1966, 0, 64, 0, 0),

            //1 
            new RetirementInfo(1957, 1, 62, 0),
            new RetirementInfo(1958, 1, 62, 2),
            new RetirementInfo(1959, 1, 62, 4),
            new RetirementInfo(1960, 1, 62, 6),
            new RetirementInfo(1961, 1, 62, 8),
            new RetirementInfo(1962, 1, 62, 10),
            new RetirementInfo(1963, 1, 63, 0),
            new RetirementInfo(1964, 1, 63, 2),
            new RetirementInfo(1965, 1, 63, 4),
            new RetirementInfo(1966, 1, 63, 6),
            //2
            new RetirementInfo(1958, 2, 61, 8),
            new RetirementInfo(1957, 2, 61, 6),
            new RetirementInfo(1959, 2, 61, 10),
            new RetirementInfo(1960, 2, 62, 0),
            new RetirementInfo(1961, 2, 62, 2),
            new RetirementInfo(1962, 2, 62, 4),
            new RetirementInfo(1963, 2, 62, 6),
            new RetirementInfo(1964, 2, 62, 8),
            new RetirementInfo(1965, 2, 62, 10),
            new RetirementInfo(1966, 2, 63, 0),
            //3 +
            new RetirementInfo(1957, 3, 61, 0),
            new RetirementInfo(1958, 3, 61, 2),
            new RetirementInfo(1959, 3, 61, 4),
            new RetirementInfo(1960, 3, 61, 6),
            new RetirementInfo(1961, 3, 61, 8),
            new RetirementInfo(1962, 3, 61, 10),
            new RetirementInfo(1963, 3, 62, 0),
            new RetirementInfo(1964, 3, 62, 2),
            new RetirementInfo(1965, 3, 62, 4),
            new RetirementInfo(1966, 3, 62, 6),
        };

        List<RetirementInfo> retirementAgesFemale = new List<RetirementInfo>
        {
            new RetirementInfo(1943, 0, 57, 0, 0),
            new RetirementInfo(1943, 1, 56, 0, 0),
            new RetirementInfo(1943, 2, 55, 0, 0),
            new RetirementInfo(1943, 3, 54, 0, 0),
            new RetirementInfo(1943, 5, 53, 0, 0),

            new RetirementInfo(1944, 0, 57, 0, 0),
            new RetirementInfo(1944, 1, 56, 0, 0),
            new RetirementInfo(1944, 2, 55, 0, 0),
            new RetirementInfo(1944, 3, 54, 0, 0),
            new RetirementInfo(1944, 5, 53, 0, 0),

            new RetirementInfo(1945, 0, 57, 0, 0),
            new RetirementInfo(1945, 1, 56, 0, 0),
            new RetirementInfo(1945, 2, 55, 0, 0),
            new RetirementInfo(1945, 3, 54, 0, 0),
            new RetirementInfo(1945, 5, 53, 0, 0),

            new RetirementInfo(1946, 0, 57, 0, 0),
            new RetirementInfo(1946, 1, 56, 0, 0),
            new RetirementInfo(1946, 2, 55, 0, 0),
            new RetirementInfo(1946, 3, 54, 0, 0),
            new RetirementInfo(1946, 5, 53, 0, 0),

            new RetirementInfo(1947, 0, 57, 9, 0),
            new RetirementInfo(1947, 1, 56, 0, 0),
            new RetirementInfo(1947, 2, 55, 0, 0),
            new RetirementInfo(1947, 3, 54, 0, 0),
            new RetirementInfo(1947, 5, 53, 0, 0),

            new RetirementInfo(1948, 0, 58, 6, 0),
            new RetirementInfo(1948, 1, 57, 0, 0),
            new RetirementInfo(1948, 2, 55, 9, 0),
            new RetirementInfo(1948, 3, 54, 6, 0),
            new RetirementInfo(1948, 5, 53, 3, 0),

            new RetirementInfo(1949, 0, 59, 3, 0),
            new RetirementInfo(1949, 1, 57, 6, 0),
            new RetirementInfo(1949, 2, 55, 9, 0),
            new RetirementInfo(1949, 3, 54, 6, 0),
            new RetirementInfo(1949, 5, 53, 3, 0),

            new RetirementInfo(1950, 0, 60, 0, 0),
            new RetirementInfo(1950, 1, 58, 3, 0),
            new RetirementInfo(1950, 2, 56, 6, 0),
            new RetirementInfo(1950, 3, 54, 9, 0),
            new RetirementInfo(1950, 5, 53, 0, 0),

            new RetirementInfo(1951, 0, 60, 9, 0),
            new RetirementInfo(1951, 1, 59, 0, 0),
            new RetirementInfo(1951, 2, 57, 3, 0),
            new RetirementInfo(1951, 3, 55, 6, 0),
            new RetirementInfo(1951, 5, 53, 9, 0),

            new RetirementInfo(1952, 0, 61, 6, 0),
            new RetirementInfo(1952, 1, 59, 9, 0),
            new RetirementInfo(1952, 2, 58, 0, 0),
            new RetirementInfo(1952, 3, 56, 3, 0),
            new RetirementInfo(1952, 5, 54, 6, 0),

            new RetirementInfo(1953, 0, 62, 0, 0),
            new RetirementInfo(1953, 1, 60, 6, 0),
            new RetirementInfo(1953, 2, 58, 9, 0),
            new RetirementInfo(1953, 3, 57, 0, 0),
            new RetirementInfo(1953, 5, 55, 3, 0),

            new RetirementInfo(1954, 0, 62, 0, 0),
            new RetirementInfo(1954, 1, 61, 3, 0),
            new RetirementInfo(1954, 2, 59, 6, 0),
            new RetirementInfo(1954, 3, 57, 9, 0),
            new RetirementInfo(1954, 5, 56, 0, 0),

            new RetirementInfo(1955, 0, 62, 2, 16),
            new RetirementInfo(1955, 1, 62, 2, 16),
            new RetirementInfo(1955, 2, 60, 3, 0),
            new RetirementInfo(1955, 3, 58, 6, 0),
            new RetirementInfo(1955, 5, 56, 9, 0),

            new RetirementInfo(1956, 0, 62, 4, 19),
            new RetirementInfo(1956, 1, 62, 4, 19),
            new RetirementInfo(1956, 2, 61, 0, 0),
            new RetirementInfo(1956, 3, 59, 3, 0),
            new RetirementInfo(1956, 5, 57, 6, 0),

            new RetirementInfo(1957, 0, 62, 6, 0),
            new RetirementInfo(1957, 1, 62, 6, 0),
            new RetirementInfo(1957, 2, 62, 0, 0),
            new RetirementInfo(1957, 3, 61, 6, 0),
            new RetirementInfo(1957, 3, 60, 0, 0),
            new RetirementInfo(1957, 5, 58, 3, 0),

            new RetirementInfo(1958, 0, 62, 8, 0),
            new RetirementInfo(1958, 1, 62, 2, 0),
            new RetirementInfo(1958, 2, 61, 8, 0),
            new RetirementInfo(1958, 3, 60, 9, 0),
            new RetirementInfo(1958, 5, 59, 0, 0),

            new RetirementInfo(1959, 0, 62, 10, 0),
            new RetirementInfo(1959, 1, 62, 4, 0),
            new RetirementInfo(1959, 2, 61, 10, 0),
            new RetirementInfo(1959, 3, 61, 4, 0),
            new RetirementInfo(1959, 5, 59, 9, 0),

            new RetirementInfo(1960, 0, 63, 0, 0),
            new RetirementInfo(1960, 1, 62, 6, 0),
            new RetirementInfo(1960, 2, 62, 0, 0),
            new RetirementInfo(1960, 3, 61, 6, 0),
            new RetirementInfo(1960, 5, 60, 6, 0),

            new RetirementInfo(1961, 0, 63, 2, 0),
            new RetirementInfo(1961, 1, 62, 8, 0),
            new RetirementInfo(1961, 2, 62, 2, 0),
            new RetirementInfo(1961, 3, 61, 8, 0),
            new RetirementInfo(1961, 5, 61, 3, 0),

            new RetirementInfo(1962, 0, 63, 4, 0),
            new RetirementInfo(1962, 1, 62, 10, 0),
            new RetirementInfo(1962, 2, 62, 4, 0),
            new RetirementInfo(1962, 3, 61, 10, 0),
            new RetirementInfo(1962, 5, 61, 7, 0),

            new RetirementInfo(1963, 0, 63, 6, 0),
            new RetirementInfo(1963, 1, 63, 0, 0),
            new RetirementInfo(1963, 2, 62, 6, 0),
            new RetirementInfo(1963, 3, 62, 0, 0),
            new RetirementInfo(1963, 5, 61, 11, 0),

            new RetirementInfo(1964, 0, 63, 8, 0),
            new RetirementInfo(1964, 1, 63, 2, 0),
            new RetirementInfo(1964, 2, 62, 8, 0),
            new RetirementInfo(1964, 3, 62, 2, 0),
            new RetirementInfo(1964, 5, 62, 2, 0),

            new RetirementInfo(1965, 0, 63, 10, 0),
            new RetirementInfo(1965, 1, 63, 4, 0),
            new RetirementInfo(1965, 2, 62, 10, 0),
            new RetirementInfo(1965, 3, 62, 4, 0),
            new RetirementInfo(1965, 5, 62, 4, 0),

            new RetirementInfo(1966, 0, 64, 0, 0),
            new RetirementInfo(1966, 1, 63, 6, 0),
            new RetirementInfo(1966, 2, 63, 0, 0),
            new RetirementInfo(1966, 3, 62, 6, 0),
            new RetirementInfo(1966, 5, 62, 6, 0)
        };

        private UserInfo? UserInfo;

        public RetirementInfo FindRetirementRequirements(UserInfo userInfo)
        {
            var list = userInfo.IsFemale ? retirementAgesFemale : retirementAgesMale;

            if (userInfo.NumberOfChildren == 4)
                userInfo.NumberOfChildren = 3;

            else if (userInfo.NumberOfChildren > 5)
                userInfo.NumberOfChildren = 5;

            if (userInfo.BirthDate.Year == 1943)
                userInfo.BirthDate = new DateTime(1943, 1, 1);

            UserInfo = userInfo;

            var found = list
                .Where(x => x.NumberOfChildren == userInfo.NumberOfChildren && x.YearOfBirth <= userInfo.BirthDate.Year)
                .ToList();

            if (!found.Any())
                throw new ArgumentOutOfRangeException($"Invalid data.");

            var nearestYear = found.Max(x => x.YearOfBirth);
            return found.First(x => x.YearOfBirth == nearestYear);
        }

        public string GetRetirementInfo(DateTime dateOfBirth, RetirementInfo retirementInfo)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);

            int age = today.Year - dateOfBirth.Year;
            if (today < new DateOnly(today.Year, dateOfBirth.Month, dateOfBirth.Day))
                age--;

            var retirementDate = dateOfBirth
            .AddYears(retirementInfo.RetirementAgeYears)
            .AddMonths(retirementInfo.RetirementAgeMonths)
            .AddDays(retirementInfo.RetirmeentAgeDays);

            var yearsToRetire = retirementDate.Year - today.Year;
            var monthsToRetire = retirementDate.Month - today.Month;
            var daysToRetire = retirementDate.Day - today.Day;


            if (daysToRetire < 0)
            {
                monthsToRetire--;
                daysToRetire += DateTime.DaysInMonth(today.Year, (today.Month == 12 ? 1 : today.Month + 1));
            }
            if (monthsToRetire < 0)
            {
                yearsToRetire--;
                monthsToRetire += 12;
            }

            return $"Vek: {age}\nPočet rokov: {yearsToRetire}\nPočet mesiacov: {monthsToRetire}\nPočet dní: {daysToRetire}\nDátum: {retirementDate:dd.MM.yyyy}";
        }

    }
}
