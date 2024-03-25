class Order{
    private List<Product> _listOfProducts= new List<Product>{};
    private Customer _customer;
    public Order(){

    }
    public double CalculateCost(){
        return 0.1;
    }
    public string CreateShippingLabel(){
        return "";
    }
    public string CreatePackingLabel(){
        return "";
    }
    public int GetShippingCost(){
        return 1;
    }
}