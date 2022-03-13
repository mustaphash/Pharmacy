using Core.Entities;

namespace Pharmacy.Models.ClientModels
{
    public class ClientResponseModel
    {
        public ClientResponseModel(Client client)
        {
            Id = client.Id;
            FirstName = client.FirstName;
            LastName = client.LastName;
            BirthDate = client.BirthDate;
            Points = client.Points;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Points { get; set; }
    }
}
