using Microsoft.AspNetCore.Mvc;

namespace Los_Pollos_Hermanos.Models
{
    public class Order{
        private int Id {get; set;}
        private DateTime CreatedAt {get; set;}
        private string? UserId {get; set;}
        private User User {get; set;}
        private int Amount {get; set;}
        private ICollection<OrderItem> OrderItems {get; set;}
    }
    
}