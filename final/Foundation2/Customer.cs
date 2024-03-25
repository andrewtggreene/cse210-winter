class Customer{
    private string _name;
    private Address _address;
    public Customer(string name, Address address){
        _address = address;
        _name = name;
    }
    public bool InUSA(){
        return _address.IsUSA();
    }
    public string GetAddress(){
        return _address.GetAddress();
    }
    public string GetName(){
        return _name;
    }
}