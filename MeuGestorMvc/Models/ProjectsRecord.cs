using MeuGestorMvc.Models.Enums;

namespace MeuGestorMvc.Models
{
    public class ProjectsRecord
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime EditedOn { get; set; }
        public DateTime FinishedOn { get; set; }

        public ProjectsRecord() { }

        public ProjectsRecord(int id, Project project, ProjectStatus status, DateTime createdOn, DateTime editedOn, DateTime finishedOn)
        {
            Id = id;
            Project = project;
            Status = status;
            CreatedOn = createdOn;
            EditedOn = editedOn;
            FinishedOn = finishedOn;
        }
    }
}
