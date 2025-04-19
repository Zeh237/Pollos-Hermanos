namespace Los_Pollos_Hermanos.Models
{
    public class Order{
        public int Id {get; set;}
        public DateTime CreatedAt {get; set;}
        public string? UserId {get; set;}
        public User User {get; set;}
        public int Amount {get; set;}
        public ICollection<OrderItem> OrderItems {get; set;}
    }
    
}