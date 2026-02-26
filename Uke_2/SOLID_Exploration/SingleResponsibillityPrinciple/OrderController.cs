using System;
using SOLID_Exploration.Dependency_Inversion_Principle;

namespace SOLID_Exploration.SingleResponsibillityPrinciple;

public class OrderController(IEpostService epostService, LoggerService loggerService, OrderRespository respository)
{
    public void Handle(Order order)
    {
        epostService.SendEmail(order);
        loggerService.AppendOrderToLogfile(order);
        respository.SaveOrderToDatabase(order);
    }
}
