using Core.Entities;

namespace Pharmacy.Models
{
    public class CreateClientModel
    {
        public CreateClientModel()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public double Points { get; set; }

        public Client ToClient()
        {
            return new Client()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                BirthDate = this.BirthDate,
                Points = this.Points,
            };
        }
    }
}
