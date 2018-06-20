# enums

A enum is a set of name value pairs (constants). Use Enum when you have a number of related constants e.g.

```
const int RegularAirMail = 1;
const int RegisteredAirMail = 2;
const int Express = 3;

// Instead use Enum

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3;
}
class Program
{
    static void Main(string[] args)
    {
       var method = ShippingMethod.Express;
       Console.WriteLine((int)method) // 3

       var methodId = 3;
       Console.WriteLine((ShippingMethod)methoId); // Express

       Console.WriteLine(method.ToString()); // Express
       Console.WriteLine(method); // Same as above

       var methodName = "Express";
       // Parsing - take a string and convert it to a different type
       var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
       
    }
}

