using System;
using System.Text.RegularExpressions;

public abstract class NhanVien
{
    public string HoTen { get; set; }
    public string MaNV { get; set; }

    public NhanVien(string hoTen, string maNV)
    {
        if (!KiemTraDuLieu(hoTen) || !KiemTraDuLieu(maNV))
        {
            throw new ArgumentException("Dữ liệu nhập không hợp lệ.");
        }

        HoTen = hoTen;
        MaNV = maNV;
    }

    public abstract double TinhLuong();
    public abstract void HienThiThongTin();

    public static bool KiemTraDuLieu(string input)
    {
        if (Regex.IsMatch(input, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
        {
            return false;
        }
        if (Regex.IsMatch(input, @"<[^>]*>") || Regex.IsMatch(input, @"<style[^>]*>.*</style>") || Regex.IsMatch(input, @"<script[^>]*>.*</script>"))
        {
            return false;
        }

        return true;
    }
}
