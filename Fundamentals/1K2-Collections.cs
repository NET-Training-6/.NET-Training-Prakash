using System.Collections.Generic;

class Country1
{
List<Country> countries = new()
{
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "India", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "UK", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344},
new Country {Name = "Nepal", Continent = "Asia", Area = 1323434.34, GDP = 2344}
};
}

public class Country 
{
    public string Name{get; set;}
    public double Area{get; set;}
    public string Continent{get; set;}
    public double GDP{get; set;}

}