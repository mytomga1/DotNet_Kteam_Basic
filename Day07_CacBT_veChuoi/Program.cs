using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_CacBT_veChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region VD Sử Dụng Hàm Trim() để cắt chuổi và Indexof để xác định chỗ cần cắt

            string FullName;
            

            Console.Write(" Moi ban nhap ho va ten: ");
            FullName = Console.ReadLine();

            /* Cắt các khoảng trắng dư ở đầu và cuối chuỗi */
            FullName = FullName.Trim();

            /* 
             * Trong khi còn tìm thấy 2 khoảng trắng
             * thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng
             */
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
            }


            /*
             * Cắt chuỗi họ tên ra thành mảng các từ.
             * Sau đó duyệt mảng để chuẩn hoá từng từ một.
             * Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu trên và lưu trong biến FirstChar
             * Cắt các chữ cái còn lại và lưu trong biến OtherChar.
             * Thực hiện viết hoa chữ cái đầu và viết thường các chữ cái còn lại.
             * Cuối cùng là lưu chữ vừa chuẩn hoá vào biến Result.
             */

            string[] arrA = FullName.Split(' ');
            string Result = "";

            for (int i = 0; i < arrA.Length; i++) { 
            
                string firstChar = arrA[i].Substring(0,1);
                string second = arrA[i].Substring(1);
                arrA[i] = firstChar.ToUpper() + second.ToLower();
                Result = Result + arrA[i] + " ";
            }

            Console.WriteLine(Result);

            #endregion
            Console.ReadLine();            
        }
    }
}
