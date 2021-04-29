using ReactiveUI;

namespace PythagoreanTheormCalcAvalonia
{
    public class MainWindowViewModel : ReactiveObject
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get => _sideA;
            set => this.RaiseAndSetIfChanged(ref _sideA, value);
        }

        public double SideB
        {
            get => _sideB;
            set => this.RaiseAndSetIfChanged(ref _sideB, value);
        }

        public double SideC
        {
            get => _sideC;
            set => this.RaiseAndSetIfChanged(ref _sideC, value);
        }

        public void OnSubmit()
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", "Submit button clicked.");
            messageBoxStandardWindow.Show();
        }
    }
}