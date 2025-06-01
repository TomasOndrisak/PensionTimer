using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PensionTimer.Items;
using PensionTimer.Models;
using System.Diagnostics;

namespace PensionTimer.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {


        [ObservableProperty]
        private string _title = "Main page view model!";

        [ObservableProperty]
        private int _count = 0;

        [ObservableProperty]
        private DateTime _yearOfBirth;

        [ObservableProperty]
        private string _headLineText = "Zadaj dátum narodenia";


        [ObservableProperty]
        private string _buttonText = "Potvrdiť";

        [ObservableProperty]
        private bool _yearOfBirthStep = true;

        [ObservableProperty]
        private bool _calculationStep = false;
        private MainPageModel _model;
        public MainPageViewModel()
        {
            YearOfBirth = new(1960, 1, 1);
            _model = new MainPageModel();
        }

        [RelayCommand]
        private void SubmitDateOfBirth()
        {
            try
            {
                YearOfBirthStep = false;

                HeadLineText = $"Vek ";

                var today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - YearOfBirth.Year;

                if (today < new DateOnly(today.Year, YearOfBirth.Month, YearOfBirth.Day))
                    age--;

                var user = new UserInfo(YearOfBirth, false, 0);

                CalculationStep = true;

                var ageUntilRetirement = _model.GetRetirementAge(user);

                HeadLineText = $"Vek: {age} a do dôchodku {ageUntilRetirement.RetirementAgeYears} {ageUntilRetirement.RetirementAgeMonths}";
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
        }

    }
}