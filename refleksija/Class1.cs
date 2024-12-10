using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        
        Type countryType = typeof(Country);
        ConstructorInfo constructor = countryType.GetConstructor(new[] { typeof(string), typeof(int) });
        object countryInstance = constructor.Invoke(new object[] { "CountryName", 1000000 });

        MethodInfo methodInfo = countryType.GetMethod("GetCountryInfo");
        string countryInfo = (string)methodInfo.Invoke(countryInstance, null);

        Console.WriteLine(countryInfo);
    }
}

class Country
{
    public string Name { get; set; }
    public int Population { get; set; }

    public Country(string name, int population)
    {
        Name = name;
        Population = population;
    }

    public string GetCountryInfo()
    {
        return "Country {Name} has the population of {Population}.";
    }
}

