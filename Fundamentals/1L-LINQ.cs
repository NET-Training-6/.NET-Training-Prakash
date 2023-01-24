using System;

//Language Integrated Query - LINQ
//way/technique to query collections

using System;
using System.Collections.Generic;
using System.Linq;
class linq
{
    int[] numbers = { 2, 3, 4, 5, 23, 45, 56, 89 };
    List<string> names = new() { "Bishnu", "Akash", "Prakash", "Harish", "Bom", "Hari" };

    List<Employee> employees = new()
    {
new Employee() { Name = "Prakash Saud", Age = 23, Department = "HR", Designation = "Software Engineer"},
new Employee() { Name = "Hari", Age = 20, Department = "R&D", Designation = "QA"},
new Employee() { Name = "Bom Karki", Age = 19, Department = "R&D", Designation = "QA"},
new Employee() { Name = "Badri Giri", Age = 25, Department = "HR", Designation = "Software Engineer"},
new Employee() { Name = "Voj Joshi", Age = 22, Department = "HR", Designation = "Software Engineer"}
    };
    public void Test2()
    {
        // Filters
        //1. Get all even numbers in "numbers"
        var evenNums = numbers.Where(num => num % 2 == 0); // Method Syntax

        evenNums = from num in numbers // Expression Syntax
                   where num % 2 == 0
                   select num;
        foreach (var n in evenNums)
        {
            Console.WriteLine(n);
        }
        // 2. Get all odd numbers in "numbers"
        var oddNums = numbers.Where(num => num % 2 != 0);

        oddNums = from num in numbers
                  where num % 2 != 0
                  select num;

        foreach (var n in oddNums)
        {
            Console.WriteLine(n);
        }

        // 3. Get all numbers which ends with "5"
        var numsEnding5 = numbers.Where(num => num.ToString().EndsWith("5"));

        numsEnding5 = from num in numbers
                      where num.ToString().EndsWith("5")
                      select num;

        foreach (var n in numsEnding5)
        {
            Console.WriteLine(n);
        }
        // Projections
        // 4. Get squares of all numbers in "numbers" array
        var squares = numbers.Select(num => num * num);
        foreach (var n in squares)
        {
            Console.WriteLine(n);
        }

        // 5. Get squares of elements which are greater than 50
        var squares1 = numbers.Where(num => num > 50).Select(num => num * num);
        foreach (var n in squares1)
        {
            Console.WriteLine(n);
        }

        //  6. Get all person names which starts with letter 'A' in "names" List

        var namesStartingA = names.Where(n => n.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
        foreach (var n in namesStartingA)
        {
            Console.WriteLine(n);
        }

        //7. From "names" list, get all person names with less than 4 characters 
        // and convert them to uppercase
        var person = names.Where(n => n.Length < 4).Select(n => n.ToUpper());
        foreach (var n in person)
        {
            Console.WriteLine(n);
        }
    }

    public void LINQ2()
    {
        // 1. Find if "numbers" array contain any even numbers

        var hasEven = numbers.Any(n => n % 2 == 0);

        // 2. Find if "numbers" array has all even numbers

        var allEven = numbers.All(n => n % 2 == 0);

        // 3. Get first 5 elements from numbers

        var firstFive = numbers.Take(5);

        // 4. Take 5 elements skipping first 2 from numbers

        var skipping2 = numbers.Skip(2).Take(5);



    }

    public void LearnToQueryComplexCollection()
    {
        // 1. Get all employees in HR department
        var x = employees.Where(e => e.Department == "HR");

        // 2. Get names of employee in HR department
        var x1 = employees.Where(e => e.Department == "HR").Select(e => e.Name);

        x1 = from e in employees
             where e.Department == "HR"
             select e.Name;


        // 3. Get all software engineers under age of 22
        var x3 = employees.Where(e => e.Designation == "Software Engineer" && e.Age < 24);

        x3 = from e in employees
             where e.Designation == "Software Engineer" && e.Age < 24
             select e;


        foreach (var e in x3)
        {
            Console.WriteLine($"{e.Name}");
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }

}

