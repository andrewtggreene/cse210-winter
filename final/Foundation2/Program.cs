using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
    }
}
/*
class Order{
- _listOfProducts: List<Product>
- _customer: Customer
+ Order()
+ CalculateCost(): double
+ CreateShippingLabel(): string
+ CreatePackingLabel(): string
- GetShippingCost(): int
}
class Product{
- _name: string
- _productId: string
- _pricePer: double
- _quantity: int
+ Product()
+ CalculateCost(): double
}
class Customer{
- _name: string
- _address: Address
+ Customer()
+ InUSA(): bool
}
class Address{
- _streetAddress: string
- _city: string
- _stateProvince: string
- _country: string
+ Address()
+ IsUSA(): bool
+ GetAddress(): string
}
*/