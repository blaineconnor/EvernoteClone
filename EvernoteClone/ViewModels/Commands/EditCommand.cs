using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class EditCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public NotesVM VM { get; set; }
        public EditCommand(NotesVM vm)
        {
            VM = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.StartEditing();
        }
    }
}
