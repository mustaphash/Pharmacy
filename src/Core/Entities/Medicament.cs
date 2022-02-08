﻿namespace Core.Entities
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ICollection<Pharmacy> PharmacyId { get; set; }
        public ICollection<Client> ClientId { get; set; }
    }
}
