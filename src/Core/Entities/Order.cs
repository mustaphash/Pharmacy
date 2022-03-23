﻿namespace Core.Entities
{
    public class Order
    {
        public Order()
        {
            ClientName = String.Empty;
            PharmacyName = String.Empty;
            MedicamentName = String.Empty;
        }
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string PharmacyName { get; set; }
        public string MedicamentName { get; set; }
        public DateTime CreateDate { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medicament Medicament { get; set; }
        public Client Client { get; set; }
    }
}
