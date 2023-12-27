using EvernoteClone.Models.Common;
using SQLite;

namespace EvernoteClone.Models.Entities
{
    public class Notebook : BaseEntity
    {
        [Indexed]
        public int UserId { get; set; }
        public string Name { get; set; }

        //NavProp
        public User User { get; set; }
    }
}
