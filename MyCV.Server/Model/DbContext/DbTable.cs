using Microsoft.EntityFrameworkCore;
using MyCV.Server.Model.Database;
using System.Collections.Generic;

namespace MyCV.Server.Model.DbContext
{
    public partial class DBContext
    { 
        public DbSet<ActivitiesModel> Activities { get; set; }
        public DbSet<EducationModel> Education { get; set; }
        public DbSet<InfoUserModel> InfoUser { get; set; }
        public DbSet<OtherSkillsModel> OtherSkills { get; set; }
        public DbSet<ProjectsModel> Projects { get; set; }
        public DbSet<SummaryUserModel> SummaryUser { get; set; }
        public DbSet<TechnicalSkillsModel> TechnicalSkills { get; set; }
        public DbSet<WorkExperienceModel> WorkExperience { get; set; }
        protected void TableBuilder(ModelBuilder modelBuilder)
        {
        }
    }
}
