using Core.Entities;

namespace Pharmacy.Models.ClientModels
{
    public class UpdateClientModel
    {
        public UpdateClientModel()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public double Points { get; set; }

        public Client ToUpdate()
        {
            return new Client();
        }
    }
}
