﻿namespace Core.Entities
{
    public class Pharmacy
    {
        public Pharmacy()
        {
            Name = String.Empty;
            Address = String.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Medicament> Medicaments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
