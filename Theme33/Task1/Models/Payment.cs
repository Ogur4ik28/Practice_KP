using SQLite;
using System;

namespace Task1.Models
{
    [Table("PaymentsData")]
    public class PaymentDataModel
    {
        [PrimaryKey, AutoIncrement, Column("PaymentId")]
        public int Id { get; set; }

        [Column("PackageId")]
        public int PackageId { get; set; }

        [Column("PaymentDate")]
        public DateTime Date { get; set; }

        [Column("Amount")]
        public double Amount { get; set; }

        [Ignore]
        public Package Package { get; set; }
    }
}
