public interface IProduct
{
    void Insert(Product product);
    void Update(int productId, Product product);
    void DeleteById(int productId);
    void DeleteByName(string productName);
    List<Product> Search(string keyword);
    List<Product> DeleteByIdAndGetDeleted(int productId);
    List<Product> DeleteByNameAndGetDeleted(string productName);

}
