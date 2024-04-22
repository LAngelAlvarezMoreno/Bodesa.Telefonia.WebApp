namespace Bodesa.Telefonia.WebApp.Entities
{
    public class cnf_CustomerData
    {
        public required string PayrollNumber { get; set; }
        public required string Name { get; set; }
        public string SecondName { get; set; }
        public required string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string PhoneNumber { get; set; }
        public required string Department { get; set; }
        public required string CECOS { get; set; }
        public required string LeaderShip { get; set; }
    }
}
