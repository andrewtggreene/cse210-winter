class Address{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(){

    }
    public bool IsUSA(){
        return false;
    }
    public string GetAddress(){
        return "";
    }
}