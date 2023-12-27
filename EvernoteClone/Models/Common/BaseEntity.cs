using SQLite;

namespace EvernoteClone.Models.Common
{
    public class BaseEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}
