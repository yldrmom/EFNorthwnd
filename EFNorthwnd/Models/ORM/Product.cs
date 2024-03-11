using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwnd.Models.ORM
{
    public class Product:BaseModel
    {
        public string ProductName { get; set; }
        [MaxLength(40)]
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit {  get; set; }
        [MaxLength(20)]
        public double? UnitPrice { get; set; }
        public short? UnitsInStock {  get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? RecordedLevel {  get; set; }
        public bool Discontinued {  get; set; }

        public Supplier Supplier { get; set; }
        public int? SupplierId { get; set; }

        


    }
}
