using System;
using SOLID_Exploration.SingleResponsibillityPrinciple;

namespace SOLID_Exploration.Dependency_Inversion_Principle;

public interface IEpostService
{
    string SendEmail(Order order);
}
