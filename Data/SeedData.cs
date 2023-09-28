using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
public static class SeedData
{
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
    }
    public static List<City> GetCities()
    {
        List<City> cities = new List<City>() {
            new City() {    // 1
                CityId= 1,
                CityName="Kelowna",  
                Population=132000, 
                ProvinceCode="BC", 
            },
            new City() {    //2
                CityId=2,
                CityName="Tsawassen", // CHANGE
                Population=220000,
                ProvinceCode="BC",
            },
            new City() {    // 3
                CityId=3,
                CityName="New Westminster",
                Population=71000,
                ProvinceCode="BC",
            },
            //====
            new City() {    // 4
                CityId=4,
                CityName="Calgary",
                Population=250000,
                ProvinceCode="AB",
            },
            new City() {    // 5
                CityId=5,
                CityName="Red Deer",
                Population=103000,
                ProvinceCode="AB",
            },
            new City() {    // 6
                CityId=6,
                CityName="Banff",
                Population=7800,
                ProvinceCode="AB",
            },
             //====
            new City() {    // 7
                CityId=7,
                CityName="Brampton",
                Population=234320,
                ProvinceCode="ON",
            },
            new City() {    // 8
                CityId=8,
                CityName="Ottawa",
                Population=500000,
                ProvinceCode="ON",
            },
            new City() {    // 9
                CityId=9,
                CityName="Toronto",
                Population=800000,
                ProvinceCode="ON",
            },
        };

        return cities;
    }

    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>() {
            new Province {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
            },  new Province {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
            },  new Province {
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
            }

        };

        return provinces;
    }
}
}