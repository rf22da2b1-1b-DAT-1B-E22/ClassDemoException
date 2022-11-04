// See https://aka.ms/new-console-template for more information
using ClassDemoException.kataloger;
using ClassDemoException.model;

Console.WriteLine("Hello, World!");


Vare defaultVare = new Vare(); // brug af default konstruktør
Vare cola = new Vare("Cola", 13.50, 55);

Console.WriteLine(defaultVare);
Console.WriteLine(cola);

/*
 * Exception
 */
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

/*
 * Kataloger
 */
PersonKatalog personer = new PersonKatalog();
personer.Add(new Person("Peter", "66778899"));
personer.Add(new Person("Jakob", "12345678"));

List<Person> personListe = personer.GetAll();
foreach(Person p in personListe)
{
    Console.WriteLine(p);
}
personListe.RemoveAt(0);
Console.WriteLine("Efter sletning");
foreach (Person p in personListe)
{
    Console.WriteLine(p);
}
Console.WriteLine("efter sletning i katalog");
foreach (Person p in personer.GetAll())
{
    Console.WriteLine(p);
}


VareKatalog varer = new VareKatalog();
varer.Add(defaultVare);
varer.Add(cola);

foreach(Vare v in varer.GetAll())
{
    Console.WriteLine(v);
}

/*
 * gør brug af det generiske
 */
Katalog<Person> generiskListe = new Katalog<Person>();
generiskListe.Add(new Person("Peter", "66778899"));
generiskListe.Add(new Person("Jakob", "12345678"));
foreach(Person p in generiskListe.GetAll())
{
    Console.WriteLine(p);
}


Katalog<int> heltal = new Katalog<int>();
heltal.Add(5);
heltal.Add(10);

foreach(int i in heltal.GetAll())
{
    Console.WriteLine(i);
}


















