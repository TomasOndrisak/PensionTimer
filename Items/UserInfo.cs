namespace PensionTimer.Items
{
    public class UserInfo
    {
        public DateTime BirthDate;
        public bool IsFemale;
        public int NumberOfChildren;

        public UserInfo(DateTime birthDate, bool isFemale, int numberOfChildren)
        {
            BirthDate = birthDate;
            IsFemale = isFemale;
            NumberOfChildren = numberOfChildren;
        }
    }
}
