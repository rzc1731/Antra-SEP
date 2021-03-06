using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Antra.CRMApp.Core.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "varchar(40)")]
        public string Name { get; set; }

        [Column(TypeName = "int")]
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        [Column(TypeName = "int")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "smallint")]
        public Int16 UnitsInStock { get; set; }

        [Column(TypeName = "smallint")]
        public Int16 UnitsOnOrder { get; set; }

        [Column(TypeName = "smallint")]
        public Int16 ReorderLevel { get; set; }

        [Required(ErrorMessage = "Discontinued is required")]
        [Column(TypeName = "smallint")]
        public Int16 Discontinued { get; set; }
    }
}
