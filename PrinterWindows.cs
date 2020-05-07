using System;

public class PrinterWindows
{
    public string name { get; set; }

    public virtual void Show()
    {
        Console.WriteLine("Printer Windows");
    }
    public virtual void Print()
    {
        Console.WriteLine("Windows printer printing...");
    }
}
