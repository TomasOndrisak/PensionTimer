using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PensionTimer.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] 
        private string _title = "Main page view model!";

        [ObservableProperty]
        private int _count = 0;

        [ObservableProperty]
        private string _buttonText = "Click me";

        public MainPageViewModel()
        {
            // Inicializácia, ak je potrebná
            ButtonText = $"Clicked {Count} x";
        }

        [RelayCommand]
        private void CounterClicked()
        {
            Count++;
            Title = $"Counter: {Count}";
            ButtonText = $"Clicked {Count} x";
        }
    }
}