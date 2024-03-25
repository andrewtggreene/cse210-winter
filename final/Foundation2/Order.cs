class Order{
    private List<Product> _listOfProducts= new List<Product>{};
    private Customer _customer;
    public Order(Customer customer){
        _customer = customer;
    }
    public void AddProduct(Product product){
        _listOfProducts.Add(product);
    }
    public double CalculateCost(){
        double cost = 0;
        foreach(Product product in _listOfProducts){
            cost += product.CalculateCost();
        }
        cost += GetShippingCost();
        return Math.Round(cost,2);
    }
    public string CreateShippingLabel(){
        string ShippingLabel = "";
        ShippingLabel += $"{_customer.GetAddress()}\n{_customer.GetName()}";
        return ShippingLabel;
    }
    public string CreatePackingLabel(){
        string PackingLabel = "";
        foreach(Product product in _listOfProducts){
            PackingLabel += $"Name: {product.GetName()} \nId:{product.GetProductId()}\n";
        }
        PackingLabel += $"Total Cost: {CalculateCost()}";
        return PackingLabel;
    }
    public int GetShippingCost(){
        if (_customer.InUSA() == true){
            return 5;
        } else {
            return 35;
        }
    }
}