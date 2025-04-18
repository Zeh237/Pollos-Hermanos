using Los_Pollos_Hermanos.Models;
using Microsoft.AspNetCore.Mvc;

public class OrderItem{
    private int Id {get; set;}
    private int OrderId {get; set;}
    private Order? Order {get; set;}
    private int ProductId {get; set;}
    
}