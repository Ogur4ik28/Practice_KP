using SQLite;

namespace Task1.Models
{
    [Table("ToursData")]
    public class TourDataModel
    {
        [PrimaryKey, AutoIncrement, Column("TourId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Price")]
        public double Price { get; set; }

        [Column("Information")]
        public string Information { get; set; }
    }
}
