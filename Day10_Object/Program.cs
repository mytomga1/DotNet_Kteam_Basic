using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region aaa
            // Khởi tạo biến Value kiểu int (kiểu dữ liệu giá trị)
            string Value = 109;



            /* thực hiện boxing bằng cách:
             * Khởi tạo đối tượng ObjectValue kiểu object 
             * Gán giá trị của biến Value vào ObjectValue */
            object ObjectValue = Value;

            #endregion

        }
    }
}
