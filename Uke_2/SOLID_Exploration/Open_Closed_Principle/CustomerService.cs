using System;

namespace SOLID_Exploration.Open_Closed_Principle;

public class CustomerService
{
    public decimal CalculateDiscountForCustomerType(CustomerType type, decimal amount) => amount * ((decimal)type / 100);
}

