using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DwitterLoungeBar.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Please enter your First Name")]
        [MinLength(3), MaxLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        [MinLength(3), MaxLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        [MinLength(5), MaxLength(40)]
        [DisplayName("Address")]
        public string AddressLine { get; set; }
        [MinLength(4), MaxLength(10)]
        [DisplayName("ZipCode")]
        public string ZipCode { get; set; }
        [MinLength(4), MaxLength(20)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Country")]
        [MinLength(4), MaxLength(20)]
        public string Country { get; set; }
        [MaxLength(25)]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]

        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }

    }
}
