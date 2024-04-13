using System;
using System.Collections.Generic;
using System.Linq;

public class ProductManager : IProduct
{
    private List<Product> products = new List<Product>();

    public void Insert(Product product)
    {
        products.Add(product);
    }

    public void Update(int productId, Product product)
    {
        Product existingProduct = products.FirstOrDefault(p => p.ProductId == productId);
        if (existingProduct != null)
        {
            existingProduct.ProductName = product.ProductName;
            existingProduct.Price = product.Price;
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    public void DeleteById(int productId)
    {
        Product product = products.FirstOrDefault(p => p.ProductId == productId);
        if (product != null)
        {
            products.Remove(product);
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    public void DeleteByName(string productName)
    {
        Product product = products.FirstOrDefault(p => p.ProductName == productName);
        if (product != null)
        {
            products.Remove(product);
        }
        else
        {
            Console.WriteLine("Product không có sẵn");
        }
    }
    public List<Product> DeleteByIdAndGetDeleted(int productId)
    {
        List<Product> deletedProducts = new List<Product>();
        Product product = products.FirstOrDefault(p => p.ProductId == productId);
        if (product != null)
        {
            products.Remove(product);
            deletedProducts.Add(product);
        }
        return deletedProducts;
    }

    public List<Product> DeleteByNameAndGetDeleted(string productName)
    {
        List<Product> deletedProducts = new List<Product>();
        Product product = products.FirstOrDefault(p => p.ProductName == productName);
        if (product != null)
        {
            products.Remove(product);
            deletedProducts.Add(product);
        }
        return deletedProducts;
    }


    public List<Product> Search(string keyword)
    {
        return products.Where(p => p.ProductName.Contains(keyword)).ToList();
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

}
