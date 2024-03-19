namespace DesignPatterns.Proxy;

public class ResponsiblePerson
{
    private Person _person;
    public ResponsiblePerson(Person person)
    {
        _person = person;
    }

    public int Age
    {
        get { return _person.Age; }
        set { _person.Age = value; }
    }

    public string Drink()
    {
        if (Age >= 18)
        {
            return _person.Drink();
        }
        else
        {
            return "too young";
        }
    }

    public string Drive()
    {
        if (Age >= 16)
        {
            return _person.Drive();
        }
        else
        {
            return "too young";
        }
    }

    public string DrinkAndDrive()
    {
        return "dead";
    }
}