using System;

namespace SOLID_Exploration.Interface_Segregation_Principle;

public class Printer : IPrinter
{
    public void Fax(int telNum)
    {
        Console.WriteLine($"Sent textfile to {telNum}");
    }

    public void Print(string Text)
    {
        Console.WriteLine(Text);
    }

    public string Scan()
    {
        return "Hello, world!";
    }
}

public class SimpleLaserPrinter : IPrintable
{

    public void Print(string Text)
    {
        Console.WriteLine(Text);
    }

}

public interface IPrinter: IPrintable, IScannable, IFaxable;

public interface IPrintable
{
    void Print(string Text);
}

public interface IScannable
{
    string Scan();
}

public interface IFaxable
{
    void Fax(int telNum);
}
