using DesignPatterns.Proxy;

var person = new ResponsiblePerson(new Person(15));
Console.WriteLine(person.Drive());
Console.WriteLine(person.Drink());
Console.WriteLine(person.DrinkAndDrive());