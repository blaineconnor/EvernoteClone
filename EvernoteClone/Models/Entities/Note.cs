using EvernoteClone.Models.Common;
using SQLite;

namespace EvernoteClone.Models.Entities
{
    public class Note : AuditableEntity
    {
        [Indexed]
        public int NotebookId { get; set; }
        public string Title { get; set; }
        public string FileLocation { get; set; }


        //NavProp
        public Notebook Notebook { get; set;}
    }
}
