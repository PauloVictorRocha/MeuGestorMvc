using MeuGestorMvc.Models.Enums;

namespace MeuGestorMvc.Models
{
    public class Opportunity
    {
        public string OpportunityId { get; set; }
        public string OpportunityDescription { get; set; }
        public double OpportunityValue { get; set; }
        public OpportunityStatus Status { get; set; }
        public Client OpportunityClient { get; set; }
        public Project OpportunityProject { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime EditedOn { get; set; }
        public DateTime ConcludedOn { get; set; }

        public Opportunity() { }

        public Opportunity(string opportunityId, string opportunityDescription, double opportunityValue, OpportunityStatus status, Client opportunityClient, Project opportunityProject, DateTime createdOn, DateTime editedOn, DateTime concludedOn)
        {
            OpportunityId = opportunityId;
            OpportunityDescription = opportunityDescription;
            OpportunityValue = opportunityValue;
            Status = status;
            OpportunityClient = opportunityClient;
            OpportunityProject = opportunityProject;
            CreatedOn = createdOn;
            EditedOn = editedOn;
            ConcludedOn = concludedOn;
        }
    }
}
