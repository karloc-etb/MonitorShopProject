using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLInes { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your first name is required")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your last name is required")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your last name is required")]
        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your zip code is required")]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your country is required")]
        public string Country { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your phone number is required")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }


        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }

    }
}
