using System;
using SOLID_Exploration.Dependency_Inversion_Principle;

namespace SOLID_Exploration.SingleResponsibillityPrinciple;

public class EpostService : IEpostService
{
    public string EmailTemplate = "Thanks for ordering the product with order Id {0}";
    public string SendEmail(Order order)
    {
        return string.Format(EmailTemplate, order.OrderId);
    }
}
