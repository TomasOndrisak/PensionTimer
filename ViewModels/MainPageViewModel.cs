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

        [ObservableProperty]
        private bool _isFemale = false;

        [ObservableProperty]
        private int _numberOfChildren = 0;

        private MainPageModel _model;
        public MainPageViewModel()
        {
            YearOfBirth = new(2000, 1, 1);
            _model = new MainPageModel();
        }

        [RelayCommand]
        private void SubmitDateOfBirth()
        {
            try
            {
                YearOfBirthStep = false;

                var user = new UserInfo(YearOfBirth, IsFemale, NumberOfChildren);
                var retirementInfo = _model.FindRetirementRequirements(user);

                HeadLineText = _model.GetRetirementInfo(user.BirthDate, retirementInfo);
                CalculationStep = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}