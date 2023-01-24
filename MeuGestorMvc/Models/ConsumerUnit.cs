namespace MeuGestorMvc.Models
{
    public class ConsumerUnit : Client
    {
        public String UC { get; set; }
        public Client Holder { get; set; } //Titular da UC
        public string PowerCompany { get; set; }
        public string Connection { get; set; } //Monofásico ou Trifásico
        public string GeneralProtection { get; set; } //Disjuntor Geral

        public ConsumerUnit() { }

        public ConsumerUnit(string uC, Client holder, string powerCompany, string connection, string generalProtection)
        {
            UC = uC;
            Holder = holder;
            PowerCompany = powerCompany;
            Connection = connection;
            GeneralProtection = generalProtection;
        }
    }
}
