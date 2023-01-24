namespace MeuGestorMvc.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressComplement { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Cep { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        public Client()
        {

        }

        public Client(string cpfCnpj, string name, string address, string addressComplement, string county, string state, string cep, string contact, string email, ICollection<Project> projects)
        {
            CpfCnpj = cpfCnpj;
            Name = name;
            Address = address;
            AddressComplement = addressComplement;
            County = county;
            State = state;
            Cep = cep;
            Contact = contact;
            Email = email;            
        }
    }
}
