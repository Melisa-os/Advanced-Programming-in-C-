using System;
using System.Reflection;

class Program
{
    static void Main()
    {
       
        IspitajOsobineKlase(typeof(string));
        KreirajIProveriCountry();
    }

    static void IspitajOsobineKlase(Type type)
    {
        Console.WriteLine("Naziv klase: {type.Name}");
        Console.WriteLine("Prostor imena: {type.Namespace}");
        Console.WriteLine("Naziv sklopa: {type.FullName}");
        Console.WriteLine("Tip koji nasleđuje: {type.BaseType}");
        Console.WriteLine("Interfejsi koje implementira:");
        foreach (var iface in type.GetInterfaces())
        {
            Console.WriteLine("  - {iface}");
        }
        Console.WriteLine("Apstraktna klasa: {type.IsAbstract}");
        Console.WriteLine("Zapečaćena klasa: {type.IsSealed}");
        Console.WriteLine("Generička klasa: {type.IsGenericType}");
        Console.WriteLine();
    }

    static void KreirajIProveriCountry()
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

