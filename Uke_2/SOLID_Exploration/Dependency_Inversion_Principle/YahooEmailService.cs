using System;
using SOLID_Exploration.SingleResponsibillityPrinciple;

namespace SOLID_Exploration.Dependency_Inversion_Principle;

public class YahooEmailService : IEpostService
{
    public string SendEmail(Order order)
    {
        return $"Sending email via Yahoomail! {order.OrderId}";
    }
}
