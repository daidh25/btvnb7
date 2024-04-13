public class NhanVienThucTap : NhanVien
{
    public int SoNgayThucTap { get; set; }
    public double LuongNgay { get; set; }

    public NhanVienThucTap(string hoTen, string maNV, int soNgayThucTap, double luongNgay) : base(hoTen, maNV)
    {
        SoNgayThucTap = soNgayThucTap;
        LuongNgay = luongNgay;
    }

    public override double TinhLuong()
    {
        return SoNgayThucTap * LuongNgay;
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Nhân viên thực tập: {HoTen}, Mã NV: {MaNV}, Lương: {TinhLuong()}");
    }
}
