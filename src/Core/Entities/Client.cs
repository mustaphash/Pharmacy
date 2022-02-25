namespace Core.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Points { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
