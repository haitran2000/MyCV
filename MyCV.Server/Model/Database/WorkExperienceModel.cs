using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class WorkExperienceModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string CompanyName { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string Position { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(1000)]
        public string Description { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string TechnologiesUsed { get; set; }
    }
}
