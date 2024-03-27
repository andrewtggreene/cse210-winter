class Address{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string streetAddress, string city, string state, string country){
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public bool IsUSA(){
        if (_country == "US"){
            return true;
        } else {
            return false;
        }
    }
    public string GetAddress(){
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}