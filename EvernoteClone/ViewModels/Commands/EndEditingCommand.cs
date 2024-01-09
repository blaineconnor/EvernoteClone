using EvernoteClone.Models;
using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class EndEditingCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public NotesVM VM { get; set; }
        public EndEditingCommand(NotesVM notesVM)
        {
            VM = notesVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Notebook notebook = parameter as Notebook;
            if (notebook != null)
                VM.StopEditing(notebook);
        }
    }
}
