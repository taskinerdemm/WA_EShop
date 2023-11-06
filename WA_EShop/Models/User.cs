using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WA_EShop.Models
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("İsim")]
        public string FirstName { get; set; }
        [DisplayName("Soyisim")]
        public string LastName { get; set; }
        [DisplayName("Cep Numarası")]
        [MaxLength(11)]
        public string Mobile { get; set; }
        [DisplayName("Mail Adresi")]
        public string Email { get; set; }
    }
}
