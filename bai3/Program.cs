using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        IProduct productManager = new ProductManager();

        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Nhập vào N Sản phẩm");
            Console.WriteLine("2. Xóa sản phẩm theo id hoặc tên");
            Console.WriteLine("3. Update sản phẩm");
            Console.WriteLine("4. Xóa nhiều sản phẩm cùng lúc");
            Console.WriteLine("5. Thoát");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Vui lòng nhập một số từ 1 đến 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhập số lượng sản phẩm:");
                    int n;
                    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    {
                        Console.WriteLine("Số lượng sản phẩm không hợp lệ, vui lòng nhập lại:");
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Nhập thông tin sản phẩm {i + 1}:");

                        int productId;
                        while (true)
                        {
                            Console.WriteLine("Nhập ProductId:");
                            if (int.TryParse(Console.ReadLine(), out productId))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ProductId không hợp lệ, vui lòng nhập lại:");
                            }
                        }

                        Console.WriteLine("Nhập ProductName:");
                        string productName;
                        while (true)
                        {
                            productName = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(productName))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ProductName không được để trống, vui lòng nhập lại:");
                            }
                        }

                        double price;
                        while (true)
                        {
                            Console.WriteLine("Nhập Price:");
                            if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Price không hợp lệ, vui lòng nhập lại:");
                            }
                        }

                        productManager.Insert(new Product(productId, productName, price));
                    }
                    break;

                case 2:
                    Console.WriteLine("Nhập id hoặc tên sản phẩm để xóa:");
                    string input = Console.ReadLine();
                    List<Product> deletedProducts;
                    if (int.TryParse(input, out int id))
                    {
                        deletedProducts = productManager.DeleteByIdAndGetDeleted(id);
                    }
                    else
                    {
                        deletedProducts = productManager.DeleteByNameAndGetDeleted(input);
                    }

                    if (deletedProducts.Count > 0)
                    {
                        Console.WriteLine("Danh sách sản phẩm đã xóa thành công:");
                        foreach (var product in deletedProducts)
                        {
                            Console.WriteLine(product.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy sản phẩm để xóa.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Nhập ProductId muốn update:");
                    int updateId;
                    while (!int.TryParse(Console.ReadLine(), out updateId))
                    {
                        Console.WriteLine("ProductId không hợp lệ, vui lòng nhập lại:");
                    }

                    Console.WriteLine("Nhập thông tin mới:");
                    Console.WriteLine("Nhập ProductName:");
                    string updatedProductName;
                    while (true)
                    {
                        updatedProductName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(updatedProductName))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("ProductName không được để trống, vui lòng nhập lại:");
                        }
                    }

                    double updatedPrice;
                    while (true)
                    {
                        Console.WriteLine("Nhập Price:");
                        if (double.TryParse(Console.ReadLine(), out updatedPrice) && updatedPrice >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Price không hợp lệ, vui lòng nhập lại:");
                        }
                    }

                    productManager.Update(updateId, new Product(updateId, updatedProductName, updatedPrice));
                    break;

                case 4:
                    Console.WriteLine("Nhập số lượng sản phẩm muốn xóa:");
                    int deleteCount;
                    while (!int.TryParse(Console.ReadLine(), out deleteCount) || deleteCount <= 0)
                    {
                        Console.WriteLine("Số lượng sản phẩm không hợp lệ, vui lòng nhập lại:");
                    }

                    for (int i = 0; i < deleteCount; i++)
                    {
                        Console.WriteLine($"Nhập thông tin sản phẩm {i + 1} muốn xóa:");
                        Console.WriteLine("Nhập ProductId hoặc ProductName:");
                        string deleteInput = Console.ReadLine();
                        if (int.TryParse(deleteInput, out int deleteId))
                        {
                            productManager.DeleteById(deleteId);
                        }
                        else
                        {
                            productManager.DeleteByName(deleteInput);
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;

                default:
                    Console.WriteLine("Chức năng không tồn tại.");
                    break;
            }
        }
    }
}
