using SingletonDesignPatern;
//1.

//CountryProvider countryProvider = new();
//var listOfCountries = await countryProvider.GetCountries();

Console.WriteLine(DateTime.Now.ToLongTimeString());
var listOfCountries = await CountryProvider.Instance.GetCountries();

foreach (var country in listOfCountries)
{
    Console.WriteLine(country.Name);
}


//2.

var listOfCountries1 = await CountryProvider.Instance.GetCountries(); //daha önce üretilmiş olan instance ı kullanır.
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(CountryProvider.Instance.CountryCount);
Console.ReadKey();