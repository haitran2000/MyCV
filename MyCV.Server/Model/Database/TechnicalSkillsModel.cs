using System.ComponentModel.DataAnnotations;

namespace MyCV.Server.Model.Database
{
    public class TechnicalSkillsModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(255)]
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        [MaxLength(4)]
        public int ProficiencyLevel { get; set; }
    }
}
