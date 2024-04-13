public class NhanVienBanThoiGian : NhanVien
{
    public int SoGioLam { get; set; }
    public double LuongGio { get; set; }

    public NhanVienBanThoiGian(string hoTen, string maNV, int soGioLam, double luongGio) : base(hoTen, maNV)
    {
        SoGioLam = soGioLam;
        LuongGio = luongGio;
    }

    public override double TinhLuong()
    {
        return SoGioLam * LuongGio;
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Nhân viên bán thời gian: {HoTen}, Mã NV: {MaNV}, Lương: {TinhLuong()}");
    }
}
