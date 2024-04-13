public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(int productId, string productName, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }

    public override string ToString()
    {
        return $"Product ID: {ProductId}, Product Name: {ProductName}, Price: {Price}";
    }
}
