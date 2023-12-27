using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class RegisterCommands : ICommand
    {
        public LoginVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public RegisterCommands(LoginVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: Login functionality
        }
    }
}
