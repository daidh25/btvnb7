using System;
using System.Text;

public class Sach
{
    public string TieuDe { get; set; }
    public string TacGia { get; set; }
    public string ISBN { get; set; }
    public double Gia { get; set; }  

    public Sach(string tieuDe, string tacGia, string isbn, double gia)  
    {
        TieuDe = tieuDe;
        TacGia = tacGia;
        ISBN = isbn;
        Gia = gia;
    }

    public void HienThiChiTiet()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"Tiêu đề: {TieuDe}");
        Console.WriteLine($"Tác giả: {TacGia}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Giá: {Gia}");
    }
}
