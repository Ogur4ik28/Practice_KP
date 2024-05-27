using SQLite;
using System;

namespace Task1.Models
{
    [Table("SeasonsData")]
    public class SeasonDataModel
    {
        [PrimaryKey, AutoIncrement, Column("SeasonId")]
        public int Id { get; set; }

        [Column("TourId")]
        public int TourId { get; set; }

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Column("IsClosed")]
        public bool IsClosed { get; set; }

        [Column("NumberOfSeats")]
        public int NumberOfSeats { get; set; }
    }
}
