using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class SummaryUserModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(2000)]
        public string Summary { get; set; }
    }
}
