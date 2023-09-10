using SQLite;

namespace MauiSQLite.MVVM.Models
{

    [Table("Contatos")]
    public class Contato
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull, MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(200), NotNull]
        public string Email { get; set; }
    }
}
