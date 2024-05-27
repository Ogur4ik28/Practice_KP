using SQLite;

namespace Task1.Models
{
    [Table("TouristsData")]
    public class TouristDataModel
    {
        [PrimaryKey, AutoIncrement, Column("TouristId")]
        public int Id { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }
    }
}
