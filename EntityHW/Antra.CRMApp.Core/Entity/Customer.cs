using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.CRMApp.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string RegionId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Country { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public string Phone { get; set; }
    }
}
