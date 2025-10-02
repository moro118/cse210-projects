public class Order
{

   private List<Product> _products = new List<Product>();
   private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalprice()
    {
        decimal totalCost = 0;
        decimal shippingCost = _customer.IsResidentOfUSA() ? 5 : 35;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost(); 
        }
        return  totalCost+ shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"Product: {product.GetName()}, ID: {product.GetProductID()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetFullAddress()}";
    }
}