namespace DesignPatterns.Proxy;

public class Person
{
    public int Age;

    public Person(int age)
    {
        Age = age;
    }

    public string Drink()
    {
        return "drinking";
    }

    public string Drive()
    {
        return "driving";
    }

    public string DrinkAndDrive()
    {
        return "driving while drunk";
    }
}
