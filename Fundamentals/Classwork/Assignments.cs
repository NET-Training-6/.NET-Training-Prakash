using System;
using System.Collections.Generic;

class CollectionSolution
{
    //  1.Create list of at least 10 numbers and print in console only the numbers multiple of 3 an 5.
    public void listNumbers()
    {
        List<long> numbers = new List<long>() { 122, 2324525, 30, 1323, 15, 688, 56657, 46646, 46467, 2343553, 778 };

        foreach (long num in numbers)
        {
            if (num % 3 == 0 && num % 5 == 0)
                Console.Write($" {num} ");
        }
    }
    //  2.Create list of date of births of 8 people.Print those dobs in console oldest first.
    public void ListDobs()
    {
        // 1999/10/1
        List<DateTime> dobs = new List<DateTime>
{
    new DateTime(1999, 1, 1),
    new DateTime(1990, 10, 2),
    new DateTime(1954, 6, 9),
    new DateTime(1980, 10, 5),
    new DateTime(1999, 10, 1),
    new DateTime(2005, 12, 6),
    new DateTime(2010, 7, 12),
    new DateTime(1999, 9, 19),

};
        dobs.Sort();
        foreach (DateTime dob in dobs)
        {
            Console.WriteLine(dob.ToString("dd-MM-yyyy"));
        }
    }
    public void LearnDictionary()
    {

        // key-value pairs
        Dictionary<string, byte> people = new();
        people.Add("Prakash", 23);
        people.Add("Haris", 35);
        people.Add("Pari", 43);
        people.Add("Bam", 60);
        people.Add("Prem", 73);
        people.Add("Bom", 80);
        people.Add("Gopi", 100);
        people.Add("Sankar", 45);
        people.Add("Santosh", 87);

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Key} => {person.Value}");
        }
    }

    public void TupleList()
    {
        // List<>
        (string cName, long population, double Area) = ("Nepal", 233445533, 12233424.24);
        List<(string, long, double)> countries = new();
        countries.Add(("Nepal", 12434545, 12332344.355));
        countries.Add(("Nepal", 12434545, 12332344.355));
        countries.Add(("Nepal", 12434545, 12332344.355));
        countries.Add(("Nepal", 12434545, 12332344.355));

        Console.WriteLine();
    }
}
