using EvernoteClone.Models;
using EvernoteClone.ViewModels.Commands;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace EvernoteClone.ViewModels
{
    public class NotesVM : INotifyPropertyChanged
    {
        public ObservableCollection<Notebook> Notebooks { get; set; }
        public ObservableCollection<Note> Notes { get; set; }

        private Notebook selectedNotebook;


        public Notebook SelectedNoteBook
        {
            get { return selectedNotebook; }
            set
            {
                selectedNotebook = value;
                OnPropertyChanged("SelectedNotebook");
                GetNotes();
            }
        }
        public NewNotebookCommand NewNotebookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public NotesVM()
        {
            NewNotebookCommand = new NewNotebookCommand(this);
            NewNoteCommand = new NewNoteCommand(this);

            Notebooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Note>();
            GetNotebooks();
        }

        public void CreateNotebook()
        {
            Notebook newNotebook = new Notebook
            {
                Name = "New Notebook"
            };
            DatabaseHelper.Insert(newNotebook);

            GetNotebooks();
        }

        public void CreateNote(int notebookId)
        {
            Note newNote = new Note
            {
                NotebookId = notebookId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Title = $"Note for {DateTime.Now.ToString()}"
            };

            DatabaseHelper.Insert(newNote);
            GetNotes();
        }
        private void GetNotebooks()
        {
            var notebooks = DatabaseHelper.Read<Notebook>();
            Notebooks.Clear();
            foreach (var notebook in notebooks)
            {
                Notebooks.Add(notebook);
            }
        }
        private void GetNotes()
        {
            if (SelectedNoteBook != null)
            {
                var notes = DatabaseHelper.Read<Note>().Where(n => n.NotebookId == SelectedNoteBook.Id).ToList();
                Notes.Clear();
                foreach (var note in notes)
                {
                    Notes.Add(note);
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
