using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.CRMApp.Core.Entity
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string TitleOfCourtesy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime HireDate { get; set; }

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

        [Column(TypeName = "int")]
        public int ReportsTo { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string PhotoPath { get; set; }
    }
}
