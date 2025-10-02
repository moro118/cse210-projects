public class Product
{
    string _name;
    string _productID;
    decimal _price;
    int _quantity;
    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
         return _name; 
    }
    public string GetProductID()
    {
         return _productID; 
    }
    public decimal GetPrice()
    {
         return _price; 
    }
    public int GetQuantity()
    {
        return _quantity; 
    }
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {_name}, ID: {_productID}, Price: {_price}, Quantity: {_quantity}, Total Price: {GetTotalCost()}");
    }


}