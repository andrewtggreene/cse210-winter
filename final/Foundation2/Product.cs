class Product{
    private string _name;
    private string _productId;
    private double _pricePer;
    private int _quantity;
    public Product(string name, string productId, double price, int quantity){
        _name = name;
        _productId = productId;
        _pricePer = price;
        _quantity = quantity;
    }
    public string GetName(){
        return _name;
    }
    public string GetProductId(){
        return _productId;
    }
    public double CalculateCost(){
        return _pricePer * _quantity;
    }
}