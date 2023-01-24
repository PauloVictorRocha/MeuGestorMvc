using MeuGestorMvc.Models.Enums;

namespace MeuGestorMvc.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectArt { get; set; }
        public Client Client { get; set; }
        public ProjectType ProjectType { get; set; }        
        public ConsumerUnit ProjectUc { get; set; }        
        public string ModuleManufacturer { get; set; }
        public string ModuleModel { get; set; }
        public string ModulePower { get; set; }
        public string ModuleQuantity { get; set; }
        public string InversorManufacturer { get; set; }
        public string InversorModel { get; set; }
        public string InversorPower { get; set; }
        public string InversorQuantity { get; set; }
        public string InversorConnection { get; set; }
        public ICollection<ProjectsRecord> Records { get; set; } = new List<ProjectsRecord>();

        public Project()
        {
        }

        public Project(int id, string projectArt, Client client, ProjectType projectType, ConsumerUnit projectUc, string moduleManufacturer, string moduleModel, string modulePower, string moduleQuantity, string inversorManufacturer, string inversorModel, string inversorPower, string inversorQuantity, string inversorConnection, ICollection<ProjectsRecord> records)
        {
            Id = id;
            ProjectArt = projectArt;
            Client = client;
            ProjectType = projectType;
            ProjectUc = projectUc;
            ModuleManufacturer = moduleManufacturer;
            ModuleModel = moduleModel;
            ModulePower = modulePower;
            ModuleQuantity = moduleQuantity;
            InversorManufacturer = inversorManufacturer;
            InversorModel = inversorModel;
            InversorPower = inversorPower;
            InversorQuantity = inversorQuantity;
            InversorConnection = inversorConnection;
        }
    }    
}
