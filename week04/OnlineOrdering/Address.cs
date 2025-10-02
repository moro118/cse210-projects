using System.Runtime.CompilerServices;

public class Address
{
  private  string _streetAddress;

   private string _city;

    private string _stateOrProvince;

   private string _country;

    public Address(string streetAdress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAdress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
         return _country.Equals("USA", StringComparison.OrdinalIgnoreCase) ||
               _country.Equals("United States", StringComparison.OrdinalIgnoreCase) ||
               _country.Equals("United States of America", StringComparison.OrdinalIgnoreCase);
    }
    public string GetFullAddress()
    {
           return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

 }