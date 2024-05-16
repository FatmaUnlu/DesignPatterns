using SingletonDesignPatern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatern
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;
        private new List<Country> countryList;

        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();
            countryList = new List<Country>(){
                    new Country(){Name="Türkiye"},
                    new Country(){Name="Almanya"},
                    new Country(){Name="Bulgaristan"},
            };
        }
        //public static CountryProvider Instance
        //{
        //    //get
        //    //{
        //    //if (instance == null)
        //    //{
        //    //    instance = new CountryProvider();

        //    //}                
        //    //return instance;

        //    //}
        //    get => instance = instance ?? (instance = new CountryProvider());
        //    set => instance = value;
        //}

        //şu şekilde de yazabilirim:

        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
       
        public async Task<List<Country>> GetCountries() => countryList;
        public int CountryCount => countryList.Count();
   
    }
}
