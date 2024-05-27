using SQLite;

namespace Task1.Models
{
    [Table("TravelPackages")]
    public class TravelPackage
    {
        [PrimaryKey, AutoIncrement, Column("PackageId")]
        public int Id { get; set; }

        [Column("TouristId")]
        public int TouristId { get; set; }

        [Column("SeasonId")]
        public int SeasonId { get; set; }

        [Ignore]
        public Tourist Tourist { get; set; }

        [Ignore]
        public Season Season { get; set; }
    }
}
