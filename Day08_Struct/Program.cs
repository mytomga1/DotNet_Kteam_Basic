using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Struct
{
    internal class Program
    {
        /*
             * Struct là một kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thuỷ
               do người lập trình định nghĩa để thuận tiện trong việc quản lý dữ liệu và lập trình.

             * Là một kiểu dữ liệu tham trị (kiểu dữ liệu tham trị đã được trình bày trong bài KIỂU DỮ LIỆU )
             * Dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau.
             * Bên trong struct ngoài các biến có kiểu dữ liệu cơ bản còn có các phương thức, các struct khác.
             * Muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán tử new.
             * Struct không được phép kế thừa (khái niệm về kế thừa sẽ trình bày trong bài KẾ THỪA TRONG C# ).

        */

        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo);
            Console.WriteLine(" Ho ten: " + SV.HoTen);
            Console.WriteLine(" Diem toan: " + SV.DiemToan);
            Console.WriteLine(" Diem ly: " + SV.DiemLy);
            Console.WriteLine(" Diem van: " + SV.DiemVan);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }

        static void Main(string[] args)
        {
            /*
             * Khai báo 1 kiểu dữ liệu SinhVien với các trường thông tin như đề bài.
             * Khai báo và khởi tạo 1 đối tượng SV1 kiểu SinhVien.
             */
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            /*
             * Đây là hàm hỗ trợ nhập thông tin sinh viên.
             * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
             * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
             */
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }


    }
}
