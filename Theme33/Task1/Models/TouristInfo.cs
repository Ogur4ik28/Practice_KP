using SQLite;

namespace Task1.Models
{
    [Table("TouristInformation")]
    public class TouristInformation
    {
        [PrimaryKey, Column("TouristId")]
        public int TouristId { get; set; }

        [Column("PassportSeries")]
        public string PassportSeries { get; set; }

        [Column("City")]
        public string City { get; set; }

        [Column("Country")]
        public string Country { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("Index")]
        public int Index { get; set; }

        [Ignore]
        public Tourist Tourist { get; set; }
    }
}
