using System;
using System.IO;
using System;
//a class called demonstratingclass is defined and it implements the IDidposable interface
public class demonstratingclass : IDisposable
{
    //the dispose() method is defined to to perform the release of the required resources
    public void Dispose()
    {
        Console.WriteLine("The dispose() function has been called and the resources have been released!");
    }
}
//another class called demofordispose is defined
public class demofordispose
{
    //main method is called
    public static void Main()
    {
        //an instance of the demonstratingclass is created
        var result = new demonstratingclass();
        //the dispose() method is called on the instance of the demonstratingclass to release it from the memory
        result.Dispose();
    }
}
