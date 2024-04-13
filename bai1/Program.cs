using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var thuVien = new ThuVien();
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Thêm sách mới");
            Console.WriteLine("2. Hiển thị danh sách sách");
            Console.WriteLine("3. Mượn sách theo ISBN");
            Console.WriteLine("4. Trả sách");
            Console.WriteLine("5. Tìm sách theo tác giả ");
            Console.WriteLine("6. Thoát");

            int chon;
                ;
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui lòng nhập một số từ 1 đến 6.");
                continue;
            }

            switch (chon)
            {
                case 1:
                    thuVien.ThemSachMoi();
                    thuVien.HienThiSach(); 
                    break;
                case 2:
                    thuVien.HienThiSach();
                    break;
                case 3:
                    thuVien.TimSachTheoTacGia();
                    break;
                case 4:
                    thuVien.MuonSachTheoISBN();
                    break;
                case 5:
                    thuVien.TraSach();
                    break;
                
                case 6:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Chức năng không tồn tại.");
                    break;
            }
        }
    }
}
