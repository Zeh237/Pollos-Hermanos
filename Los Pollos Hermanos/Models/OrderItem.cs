namespace Los_Pollos_Hermanos.Models{
    public class OrderItem{
        public int Id {get; set;}
        public int OrderId {get; set;}
        public Order? Order {get; set;}
        public int ProductId {get; set;}
        public Product? product {get; set;}
        public int Quantity {get; set;}
        public decimal price {get; set;}
    }
}