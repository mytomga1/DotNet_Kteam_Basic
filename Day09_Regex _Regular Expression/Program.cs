using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day09_Regex__Regular_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Match và MatchCollection:

            //Regex reg = new Regex(@"\d");
            //Match result = reg.Match("-howkteam.com 10092016-"); // Một đối tượng kiểu Match sẽ chứa 1 chuỗi con kết quả
            //Console.WriteLine(result.ToString());


            Regex reg = new Regex(@"\d"); // Tạo 1 đối tượng Regex chứa pattern của mình
            Match result = reg.Match("-howkteam.com 10092016-"); // Tạo 1 đối tượng Match để chứa kết quả.

            do
            {
                Console.Write(result.ToString());
                result = result.NextMatch(); // Chuyển qua kết quả trùng khớp kế tiếp
            }
            while (result != Match.Empty); // Kiểm tra xem đã hết kết quả trùng khớp chưa

            #endregion

            #region Group và GroupCollection
            /*
                Group trong Regular Expression là chỉ cách ta gom nhóm các biểu thức lại thành cụm và có thể đặt tên cho nhóm để dễ quản lý và thao tác.
                Lớp Group là 1 lớp đại diện cho 1 gom nhóm trong biểu thức. Có 1 điểm chúng ta nên biết là lớp Group là lớp cha của lớp Match!

            */

            // Tạo 1 biểu thức
            //Regex re = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)"); // Trong đó “hours”, “minutes”, “seconds” là tên do mình đặt cho 3 group.

            ///*
            // * Duyệt qua các kết quả trùng khớp
            // * Lấy ra giá trị của các group thông qua chỉ số phần tử là tên các group đã đặt trong biểu thức
            // */
            //foreach (Match item in re.Matches("30/04/2017 10:15:12 192.168.1.2"))
            //{
            //    Console.WriteLine(" Match: " + item.ToString());
            //    Console.WriteLine(" Hours: " + item.Groups["hours"]);
            //    Console.WriteLine(" Minutes: " + item.Groups["minutes"]);
            //    Console.WriteLine(" Seconds: " + item.Groups["seconds"]);
            //}


            #endregion

            #region Capture và CaptureCollection
            // Mỗi khi tìm thấy bất kỳ 1 chuỗi con nào (bao gồm cả các group) thì C# sẽ bắt nó lại và lưu vào 1 đối tượng có kiểu Capture. Và danh sách tất cả các Capture chính là 1 CaptureCollection.
            // Một điểm cần biết nữa là Capture là lớp cha của lớp Group!

            // Ở đây mình có 2 tên công ty bên trong nên mình đặt chung 1 tên group là company với mong muốn lấy ra 2 tên công ty từ group.
            //Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");

            //foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            //{
            //    Console.WriteLine(" time: " + item.Groups["times"]);
            //    Console.WriteLine(" company: " + item.Groups["company"]);
            //    Console.WriteLine(" ip: " + item.Groups["ip"]);
            //    Console.WriteLine(" company: " + item.Groups["company"]);
            //}


            Regex RE = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine(" time: " + item.Groups["times"]);
                Console.WriteLine(" ip: " + item.Groups["ip"]);
                Console.Write(" company: ");
                /*
                    Lấy ra tất cả các capture bắt được trong group company và duyệt lần lượt chúng
                 * Sau đó ta có thể sử dụng hàm ToString() hoặc thuộc tính Value để lấy giá trị của Capture
                 */
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }

            }

            #endregion




            Console.ReadLine();
        }
    }
}
