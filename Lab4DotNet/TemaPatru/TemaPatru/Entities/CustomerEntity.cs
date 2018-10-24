using System.ComponentModel.DataAnnotations;

namespace TemaPatru.Entities
{
    public class CustomerEntity: BaseEntity
    {

        public string Address { get; set; }

        [RegularExpression(@"^\(?([0]{1}[7]{1})\)?[-.●]?([0-9]{8})$", ErrorMessage = "Characters are not allowed.")]
        public string PhoneNumber{ get; set; }

        [RegularExpression(@"^[a-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}$")]
        public string Email{ get; set; }
    }
}