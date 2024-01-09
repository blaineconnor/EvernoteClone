using EvernoteClone.Models;
using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginVM VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public LoginCommand(LoginVM vM) { VM = vM; }
        public bool CanExecute(object parameter)
        {
            User user = parameter as User;
            if (user == null) return false;
            if (string.IsNullOrEmpty(user.Username)) return false;
            if (string.IsNullOrEmpty(user.Password)) return false;
            return true;
        }

        public void Execute(object parameter)
        {
            VM.Login();
        }
    }
}
