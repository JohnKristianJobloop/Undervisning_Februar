// See https://aka.ms/new-console-template for more information
using SOLID_Exploration.Dependency_Inversion_Principle;
using SOLID_Exploration.Interface_Segregation_Principle;
using SOLID_Exploration.Liskov_Substitution_Principle;
using SOLID_Exploration.Open_Closed_Principle;
using SOLID_Exploration.SingleResponsibillityPrinciple;

Console.WriteLine("Hello, World!");


//Printer Interface Segregation Example

IPrinter superPrinter = new Printer();

superPrinter.Fax(123123123);
var scanResult = superPrinter.Scan();
superPrinter.Print("HEllo!");

var simplePrinter = new SimpleLaserPrinter();

simplePrinter.Print("Hello!");
var epostService = new EpostService();
var logger = new LoggerService("./logfile.txt");
var repository = new OrderRespository("Data Source=./Data/order.db");

MultiplyTwoNumbersAndPrintResult(4,5, epostService, logger, repository);


//Open Closed example

var service = new CustomerService();

var customerPrice = service.CalculateDiscountForCustomerType(CustomerType.SuperDuperVIP, 199m);
Console.WriteLine(customerPrice);

var eagle = new Eagles();

var penguin = new Penguins();

BirdService.MakeBirdsFly(eagle);


void MultiplyTwoNumbersAndPrintResult(int x, int y, IEpostService eService, LoggerService logger, OrderRespository repo)
{
    var result = x * y;
    var controller = new OrderController(eService, logger, repo);
    Console.WriteLine(result);
}