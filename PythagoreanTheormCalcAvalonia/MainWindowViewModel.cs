using ReactiveUI;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PythagoreanTheormCalcAvalonia
{
    public class MainWindowViewModel : ReactiveObject
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Interaction<MainWindowViewModel, Window1ViewModel?> ShowDialog { get; }

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

        public string Result { get; set; } = "This is a test.";

        public void OnSubmit()
        {
            var ResultWindow = new Window1();
            ResultWindow.Title = "Pythagorean Theorm Calculator";
            ResultWindow.Show();
            //MainWindow.GotFocusEvent += ()
        }
    }
}