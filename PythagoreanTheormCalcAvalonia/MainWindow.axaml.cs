using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PythagoreanTheormCalcAvalonia
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void btnSubmit_click()
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
  .GetMessageBoxStandardWindow("title", "Submit button clicked.");
            messageBoxStandardWindow.Show();
        }
    }
}
