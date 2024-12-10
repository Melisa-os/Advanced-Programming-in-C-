using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Country[] countryCollection = {
            new Country("Afghanistan", 3465032),
            new Country("Austria", 8857960),
            new Country("Brazil", 210147125),
            new Country("Denmark", 5789957),
            new Country("Russia", 144526636),
            new Country("China", 1403500365),
            new Country("Turkey", 80810525),
            new Country("Serbia", 7001444),
            new Country("Iraq", 37202572),
            new Country("San Marino", 3334)
        };

        var sortedCountries = countryCollection.OrderByDescending(country => country.Population);

        foreach (var country in sortedCountries)
        {
            Console.WriteLine($"Country: {country.Name} Population: {country.Population:N0}");
        }
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
}
