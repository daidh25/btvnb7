public class NhanVienToanThoiGian : NhanVien
{
    public double LuongCoBan { get; set; }
    public double HeSoLuong { get; set; }

    public NhanVienToanThoiGian(string hoTen, string maNV, double luongCoBan, double heSoLuong) : base(hoTen, maNV)
    {
        LuongCoBan = luongCoBan;
        HeSoLuong = heSoLuong;
    }

    public override double TinhLuong()
    {
        return LuongCoBan * HeSoLuong;
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Nhân viên toàn thời gian: {HoTen}, Mã NV: {MaNV}, Lương: {TinhLuong()}");
    }
}
