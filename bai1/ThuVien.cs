using System;
using System.Collections.Generic;
using System.Linq;

public class ThuVien
{

    private List<Sach> danhMuc;

    public ThuVien()
    {
        danhMuc = new List<Sach>();
    }

    public void ThemSachMoi()
    {
        Console.WriteLine("Nhập tiêu đề sách:");
        string tieuDe = Console.ReadLine();

        Console.WriteLine("Nhập tác giả:");
        string tacGia = Console.ReadLine();

        Console.WriteLine("Nhập ISBN:");
        string isbn = Console.ReadLine();

        Console.WriteLine("Nhập giá:");
        double gia = double.Parse(Console.ReadLine());

        var sach = new Sach(tieuDe, tacGia, isbn, gia);
        danhMuc.Add(sach);
        Console.WriteLine($"Đã thêm: {sach.TieuDe}");
    }
    public void HienThiSach()
    {
        if (danhMuc.Count == 0)
        {
            Console.WriteLine("Thư viện chưa có sách nào.");
            return;
        }

        Console.WriteLine("Danh sách sách trong thư viện:");
        for (int i = 0; i < danhMuc.Count; i++)
        {
            danhMuc[i].HienThiChiTiet();
            Console.WriteLine("-------------");
        }
    }

    public void TimSachTheoTacGia()
    {
        Console.WriteLine("Nhập tên tác giả:");
        string tacGia = Console.ReadLine();

        var sachTheoTacGia = danhMuc.Where(s => s.TacGia.ToLower().Contains(tacGia.ToLower())).ToList();

        if (sachTheoTacGia.Count == 0)
        {
            Console.WriteLine("Không tìm thấy sách của tác giả này.");
            return;
        }

        foreach (var sach in sachTheoTacGia)
        {
            sach.HienThiChiTiet();
            Console.WriteLine("-------------");
        }
    }

    public void MuonSachTheoISBN()
    {
        Console.WriteLine("Nhập ISBN của sách muốn mượn:");
        string isbn = Console.ReadLine();

        var sach = danhMuc.FirstOrDefault(s => s.ISBN == isbn);

        if (sach != null)
        {
            Console.WriteLine($"Đã mượn: {sach.TieuDe}");
            danhMuc.Remove(sach);
        }
        else
        {
            Console.WriteLine("Không tìm thấy sách.");
        }
    }

    public void TraSach()
    {
        Console.WriteLine("Nhập tiêu đề sách cần trả:");
        string tieuDe = Console.ReadLine();

        Console.WriteLine("Nhập tác giả:");
        string tacGia = Console.ReadLine();

        Console.WriteLine("Nhập ISBN:");
        string isbn = Console.ReadLine();

        Console.WriteLine("Nhập giá:");
        double gia = double.Parse(Console.ReadLine());

        var sach = new Sach(tieuDe, tacGia, isbn, gia);
        danhMuc.Add(sach);
        Console.WriteLine($"Đã trả: {sach.TieuDe}");
    }
}
