using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Antra.CRMApp.Core.Entity;

namespace Antra.CRMApp.Core.Model
{
    public class SupplierModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "CompanyName is required")]
        [Column(TypeName = "varchar(40)")]
        public string CompanyName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ContactName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ContactTitle { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string City { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Region")]
        public int RegionId { get; set; }

        public RegionModel Region { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(24)")]
        public string Phone { get; set; }
    }
}
