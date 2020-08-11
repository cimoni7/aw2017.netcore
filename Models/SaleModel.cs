using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AW2017.Models
{
    [Table("SalesOrderHeader", Schema = "Sales")]
    public class Sale
    {
        [Key]
        public int SalesOrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int BillToAddressID { get; set; }
        public int CustomerID { get; set; }
        public int TerritoryID { get; set; }
        public int ShipMethodID { get; set; }
        public decimal TotalDue { get; set; }
    }
}
