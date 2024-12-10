using System;

class Program
{
    static void Main()
    {
        Func<double, string> povrsinaKruga = (r) =>
        {
            double povrsina = Math.PI * r * r;
            return $"Površina kruga je {povrsina}.";
        };
        double poluprecnik = 5.0;
        string rezultat = povrsinaKruga(poluprecnik);
        Console.WriteLine(rezultat);
    }
}
