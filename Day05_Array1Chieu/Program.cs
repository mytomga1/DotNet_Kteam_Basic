using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Array1Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Nhapab:
            Console.ForegroundColor = ConsoleColor.Blue;

            #region VD Mảng 1 chiều

            // int Year; // Biến chứa giá trị năm cần tính.
            // Mảng Can chứa các giá trị can tương ứng theo bảng can
            // string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            // Mảng Chi chứa các giá trị chi tương ứng theo bảng chi
            // string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };


            // Console.Write(" Moi ban nhap mot nam bat ky: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            //Year = Int32.Parse(Console.ReadLine());


            // /*
            //  * Vì kết quả phép chia lấy dư của Year%10 hoặc Year%12 sẽ cho ra số nguyên
            //  * Nên ta sẽ dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương ứng. Thay vì dùng cách cũ là switch case
            //  * Như vậy cách này vừa đơn giản vừa dễ hiểu, code rất ít sẽ với cách dùng switch case
            //  */
            // Console.WriteLine("Year :{0} % 10 = {1}", Year, Year % 10);
            // Console.WriteLine("Year :{0} % 12 = {1}", Year, Year % 12);
            // Console.WriteLine();
            // Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12]); // Nối Can và Chi lại để được năm âm lịch

            // Console.ReadLine();

            #endregion

            #region Mảng 2 Chiều
            //string[,] arrA = { {"nd01", "nd02", "nd03" },
            //                   {"nd11", "nd12", "nd13" },
            //                   {"nd21", "nd22", "nd23" }
            //};

            //int[,] arrB = {
            //                {1, 2, 3},
            //                {4, 5, 6},
            //                {5, 6, 7}
            //};

            //for (int i = 0; i < arrB.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arrB.GetLength(1); j++)
            //    {
            //        Console.Write("[ {0,0} ]", arrB[i, j]);

            //        //Console.Write("ArrA[{0},{1}]=[{2}] || ", i, j, arrA[i, j]);

            //        //Console.Write(" [{0}] ",arrA[0, 0]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(arrA[2, 0]);
            #endregion

            #region BT mảng 2 chiều

            bool checka;
            int a,b;

            

            Console.Write("Bạn muốn mấy hàng trong mảng ArrC[a, ] : ");
            checka = int.TryParse(Console.ReadLine(), out a);

            Console.Write("Bạn muốn mấy dòng trong mảng ArrC[ , b] : ");
            bool checkb = int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine();

            if (checka == false || checkb == false) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" a và b bắt buộc phải kiểu số, vui lòng nhập lại :");
                Console.WriteLine();
                goto Nhapab;
            }


            Console.WriteLine("\n");

            // Tạo 1 mảng 2 chiều với số dòng và cột đã nhập
            int[,] ArrC = new int[a, b];

            for (int i = 0; i < ArrC.GetLength(0); i++) {

                for (int j = 0; j < ArrC.GetLength(1); j++) {

                    bool checkij;
                    Nhaplaiij:
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write("Mời Bạn Nhập Phần tử trong mảng ArrC[{0},{1}] = ", i, j); 
                    
                    checkij = int.TryParse(Console.ReadLine(), out ArrC[i, j]);
                    if (checkij == false) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Nhập lại element theo kiểu int ");
                        Console.WriteLine();
                        goto Nhaplaiij;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("========[Hiển Thị Mảng ArrC]==========");
            int sum = 0;

            for (int i = 0; i < ArrC.GetLength(0); i++) {

                for (int j = 0; j < ArrC.GetLength(1); j++) {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[ {0} ] ",ArrC[i,j]);
                    sum = sum + ArrC[i,j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========[Tổng các Phần tử trong mảng ArrC[{0},{1}] = {2} ]==========",a,b,sum);
            #endregion

            Console.ReadLine();
        }
    }
}
