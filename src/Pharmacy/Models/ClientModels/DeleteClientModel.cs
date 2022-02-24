using Core.Entities;

namespace Pharmacy.Models.ClientModels
{
    public class DeleteClientModel
    {
        public int Id { get; set; }

        public Client ToDelete()
        {
            return new Client()
            {
                Id = this.Id
            };
        }
    }
}
