using EvernoteClone.Models.Entities;
using EvernoteClone.ViewModels.Commands;
using System.Collections.ObjectModel;

namespace EvernoteClone.ViewModels
{
    public class NotesVM
    {
        public ObservableCollection<Notebook> notebooks { get; set; }
        private Notebook selectedNotebook;
        public Notebook SelectedNoteBook
        {
            get { return selectedNotebook; }
            set { selectedNotebook = value; }
        }
        public ObservableCollection<Note> Notes { get; set; }
        public NewNotebookCommand NewNotebookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }
        public NotesVM()
        {
            NewNotebookCommand = new NewNotebookCommand(this);
            NewNoteCommand = new NewNoteCommand(this);
        }
    }
}
