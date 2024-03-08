using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class ProjectsModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string ProjectName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string[] TeamMembers { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string ProjectRole { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string Description { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string[] KeyFeatures { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string[] TechnologiesUsed { get; set; }
    }
}
