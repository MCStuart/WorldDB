using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WorldDB.Models
{
 public class Country
 {
   private string _name;
   private string _continent;
   private int _population;
   private int _capital;
   //private List<Country> _countries;

   public string Name { get => _name; set => _name = value; }
   public string Continent { get => _continent; set => _continent = value; }
   public int Population { get => _population; set => _population = value; }
   public int Capital { get => _capital; set => _capital = value; }
   //public List<Country> allCountries { get => _countries; set => _countries = value; }

   public Country(string name, string continent, int population, int capital)
   {
     Name = name;
     Continent = continent;
     Population = population;
     Capital = capital;
   }

   public Country(string name)
   {
     Name = name;
   }

   public static List<Country> GetCountries()
   {
     List<Country> allCountries = new List<Country> {};
     MySqlConnection conn = DB.Connection();
     conn.Open();
     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
     cmd.CommandText = @"SELECT name FROM country;";
     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;

     while(rdr.Read())
     {
       string countryName = rdr.GetString(0);
       // string countryContinent = rdr.GetString(2);
       // int countryPopulation = rdr.GetInt32(6);
       // int countryCapital = rdr.GetInt32(13);
       Country newCountry = new Country(countryName);
       allCountries.Add(newCountry);

     }

     conn.Close();
     if(conn != null)
     {
       conn.Dispose();
     }

     return allCountries;
   }

   // public static List<City> GetAll()
   // {
   //   List<City> allCities = new List<City> {};
   //   MySqlConnection conn = DB.Connection();
   //   conn.Open();
   //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
   //   cmd.CommandText = @"SELECT * FROM items;";
   //   MySqlDataReader rdr cmd.ExecuteReader() as MySqlDataReader;
   //
   //   while(rdr.Read())
   //   {
   //     int itemId = rdr.GetInt32(0);
   //     string itemDescription = rdr.GetString(1);
   //     Item newItem = new Item(itemDescription, itemId);
   //     allItems.Add(newItem);
   //   }
   //
   //   conn.Close();
   //   if(conn != null)
   //   {
   //     conn.Dispose();
   //   }
   //
   //   return allItems;
   // }

 }
}
