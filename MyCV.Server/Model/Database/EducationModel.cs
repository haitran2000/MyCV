using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class EducationModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string SchoolName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(800)]
        public string Description { get; set; }
    }
}
