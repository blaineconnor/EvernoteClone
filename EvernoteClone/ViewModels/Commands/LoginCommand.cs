using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        public  LoginVM VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public LoginCommand(LoginVM vM) { VM = vM; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
