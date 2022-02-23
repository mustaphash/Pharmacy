using Core.Entities;

namespace Pharmacy.Models
{
    public class CreateClientModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double Points { get; set; }

        public Client ToClient()
        {
            return new Client()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Points = this.Points,
            };
        }
    }
}
