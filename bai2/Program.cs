using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        List<NhanVien> danhSachNV = new List<NhanVien>();

        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Nhập vào N nhân viên");
            Console.WriteLine("2. Tính toán lương tương ứng cho mỗi loại nhân viên");
            Console.WriteLine("3. Thoát");

            int chon;
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui lòng nhập một số từ 1 đến 3.");
                continue;
            }

            switch (chon)
            {
                case 1:
                    Console.WriteLine("Nhập số lượng nhân viên:");
                    int n;
                    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    {
                        Console.WriteLine("Số lượng nhân viên không hợp lệ, vui lòng nhập lại:");
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Nhập thông tin nhân viên {i + 1}:");
                        Console.WriteLine("1. Nhân viên toàn thời gian");
                        Console.WriteLine("2. Nhân viên bán thời gian");
                        Console.WriteLine("3. Nhân viên thực tập");
                        int loaiNV;
                        while (!int.TryParse(Console.ReadLine(), out loaiNV) || loaiNV < 1 || loaiNV > 3)
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại:");
                        }

                        Console.WriteLine("Nhập tên nhân viên:");
                        string hoTen = Console.ReadLine();
                        while (!NhanVien.KiemTraDuLieu(hoTen))
                        {
                            Console.WriteLine("Tên không hợp lệ, vui lòng nhập lại:");
                            hoTen = Console.ReadLine();
                        }

                        Console.WriteLine("Nhập mã nhân viên:");
                        string maNV = Console.ReadLine();
                        while (!NhanVien.KiemTraDuLieu(maNV))
                        {
                            Console.WriteLine("Mã nhân viên không hợp lệ, vui lòng nhập lại:");
                            maNV = Console.ReadLine();
                        }

                        switch (loaiNV)
                        {
                            case 1:
                                Console.WriteLine("Nhập lương cơ bản:");
                                double luongCoBan;
                                while (!double.TryParse(Console.ReadLine(), out luongCoBan) || luongCoBan < 0)
                                {
                                    Console.WriteLine("Lương cơ bản không hợp lệ, vui lòng nhập lại:");
                                }

                                Console.WriteLine("Nhập hệ số lương:");
                                double heSoLuong;
                                while (!double.TryParse(Console.ReadLine(), out heSoLuong) || heSoLuong < 0)
                                {
                                    Console.WriteLine("Hệ số lương không hợp lệ, vui lòng nhập lại:");
                                }
                                danhSachNV.Add(new NhanVienToanThoiGian(hoTen, maNV, luongCoBan, heSoLuong));
                                break;
                            case 2:
                                Console.WriteLine("Nhập số giờ làm:");
                                int soGioLam;
                                while (!int.TryParse(Console.ReadLine(), out soGioLam) || soGioLam < 0)
                                {
                                    Console.WriteLine("Số giờ làm không hợp lệ, vui lòng nhập lại:");
                                }

                                Console.WriteLine("Nhập lương theo giờ:");
                                double luongGio;
                                while (!double.TryParse(Console.ReadLine(), out luongGio) || luongGio < 0)
                                {
                                    Console.WriteLine("Lương theo giờ không hợp lệ, vui lòng nhập lại:");
                                }
                                danhSachNV.Add(new NhanVienBanThoiGian(hoTen, maNV, soGioLam, luongGio));
                                break;
                            case 3:
                                Console.WriteLine("Nhập số ngày thực tập:");
                                int soNgayThucTap;
                                while (!int.TryParse(Console.ReadLine(), out soNgayThucTap) || soNgayThucTap < 0)
                                {
                                    Console.WriteLine("Số ngày thực tập không hợp lệ, vui lòng nhập lại:");
                                }

                                Console.WriteLine("Nhập lương theo ngày:");
                                double luongNgay;
                                while (!double.TryParse(Console.ReadLine(), out luongNgay) || luongNgay < 0)
                                {
                                    Console.WriteLine("Lương theo ngày không hợp lệ, vui lòng nhập lại:");
                                }
                                danhSachNV.Add(new NhanVienThucTap(hoTen, maNV, soNgayThucTap, luongNgay));
                                break;
                            default:
                                Console.WriteLine("Không hợp lệ.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Danh sách nhân viên và lương tương ứng:");
                    foreach (var nv in danhSachNV)
                    {
                        nv.HienThiThongTin();
                    }
                    break;
                case 3:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Chức năng không tồn tại.");
                    break;
            }
        }
    }
}
