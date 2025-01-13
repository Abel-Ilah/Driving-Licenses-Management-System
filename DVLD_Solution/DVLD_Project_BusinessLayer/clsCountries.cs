using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;
namespace BusinessLayer
{
    public class clsCountries
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        private clsCountries(int ID,string Name)
        { 
            this.ID = ID;
            this.Name = Name;
        }

        public static clsCountries Find(string CountryName)
        {
            int ID;
            ID=clsCountriesDataAccessLayer.GetCountryID(CountryName);
            if (ID!=-1)
            {
                return new clsCountries(ID, CountryName);
            }
            return null;
        }
        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";
            CountryName = clsCountriesDataAccessLayer.GetCountryName(CountryID);
            if (CountryName!="")
            {
                return new clsCountries(CountryID, CountryName);
            }
            return null;
        }
        public static DataTable GetCountriesList()
        {
            return clsCountriesDataAccessLayer.GetCountriesList();
        }

    }
}
