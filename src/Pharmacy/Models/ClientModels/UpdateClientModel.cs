using Core.Entities;

namespace Pharmacy.Models.ClientModels
{
    public class UpdateClientModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public double Points { get; set; }

        public Client NewClient()
        {
            return new Client()
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = BirthDate,
                Points = Points,
            };
        }
    }
}
