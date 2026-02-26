using System;
using System.Dynamic;

namespace SOLID_Exploration.SingleResponsibillityPrinciple;

public class OrderRespository(string connectionString)
{
    public List<Order> Orders => new ();
    public void SaveOrderToDatabase(Order order)
    {
        Orders.Add(order);
    }
}
