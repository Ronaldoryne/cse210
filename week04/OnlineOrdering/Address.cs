public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetAddressString()
    {
        return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
    }
}

