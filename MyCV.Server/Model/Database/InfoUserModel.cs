using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class InfoUserModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string LastName { get; set; }
        [DataType(DataType.Currency)]
        [MaxLength(4)]
        public int BirthYear { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(500)]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Url)]
        public string FacebookLink { get; set; }
        [DataType(DataType.Url)]
        public string GitLink { get; set; }
        [DataType(DataType.Url)]
        public string LinkedinLink { get; set; }
    }
}
