// See https://aka.ms/new-console-template for more information
using ClassDemoException.model;

Console.WriteLine("Hello, World!");


Vare defaultVare = new Vare(); // brug af default konstruktør
Vare cola = new Vare("Cola", 13.50, 55);

Console.WriteLine(defaultVare);
Console.WriteLine(cola);

try
{
    cola.Pris = -10;
}catch(ArgumentException ae)
{
    // behandle fejl
    Console.WriteLine("Der er en fejl: " + ae.Message);
}


try
{
    cola.Navn = null;
}
catch(ArgumentException ae)
{
    Console.WriteLine("Der er en fejl: " + ae.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

