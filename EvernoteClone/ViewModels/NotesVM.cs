using EvernoteClone.Models;
using EvernoteClone.ViewModels.Commands;
using System;
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

        public void CreateNotebook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "New Notebook"
            };
            DatabaseHelper.Insert(newNotebook);
        }

        public void CreateNote(int notebookId)
        {
            Note newNote = new Note()
            {
                NotebookId = notebookId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Title = "New Note"
            };

            DatabaseHelper.Insert(newNote);
        }
    }
}
