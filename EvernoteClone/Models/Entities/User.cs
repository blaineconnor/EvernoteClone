using EvernoteClone.Models.Common;
using SQLite;

namespace EvernoteClone.Models.Entities
{
    public class User : BaseEntity
    {
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
