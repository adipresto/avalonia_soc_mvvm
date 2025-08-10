using ReactiveUI;
using System.Windows.Input;

namespace MainAplikasi.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Halo Dunia, aku AvaloniaUI!";

        public ICommand cmd { get; set; }

        public MainWindowViewModel()
        {

            cmd = ReactiveCommand.Create(funccmd, this.WhenAnyValue(x => x.cancmd));
        }

        private bool cancmd { get; set; } = true;
        private void funccmd()
        {

        }
    }
}
