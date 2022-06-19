using System;
using System.Text;

namespace Day02_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // dòng này sẽ giúp bạn viết dc tiếng việt trong Console.Write ko bị lỗi


            //int j = 0;

            //for (int i = 0 ; i < 10; i++, j +=2) { // mỗi lần i tăng 1 thì j tăng 2

            //    Console.WriteLine("{0} | {1}", i, j);
            //}

            //int n = 15;
            //for (int i = 0; i < n; i++, j += 3, Console.WriteLine("HowKTeam.com For Loop {0}", i)){

            //    Console.WriteLine("============================");
            //    Console.WriteLine("i: {0} | j: {1} | i * j: {2}", i, j, i*j);
            //}

            #region bài tập cữu chương

            //Console.Write("Bạn muốn nhập Bản Cữu Chương mấy : ");
            //int y = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= 10; i++){ 

            //    Console.WriteLine("{0} x {1} = {2}",y ,i, i*y);
            //}
            #endregion

            #region bài tập vẽ hình chữ nhật 

            //int ngang = 10;
            //int doc = 10;
            //char kytuve = '$';
            //char kytubentrong = ' ';

            //for (int i = 0; i < doc; i++)
            //{
            //    /*
            //        * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
            //        * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
            //        * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
            //        * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
            //        * thì vẽ ra ký tự của hình chữ nhật
            //        * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
            //     */

            //    for (int j = 0; j < ngang; j++){

            //        if (i % (doc - 1) == 0 || ((i % (doc - 1) != 0) && (j % (ngang - 1) == 0)))
            //        {

            //            Console.Write(kytuve);
            //        }
            //        else
            //        {

            //            Console.Write(kytubentrong);
            //        }
            //    }
            //    Console.WriteLine(); // mỗi lần vẽ xong thì xuống 1 hàng
            //}

            #endregion

            #region vẽ tam giácV1
            //Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) {

            //    for (int j = 1; j <= i; j++) { 

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region vẽ tam giácV2

            //Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = n; k > i; k--)
            //    {

            //        Console.Write("   ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {

            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            // --------------[ Cach 2]-----------------------

            // * * * *  n = 4 [j = 4; 4 > i = 1 ; j-- = 4]
            //   * * *        [j = 3; 3 > i = 2 ; j-- = 3]
            //     * *        [j = 2; 2 > i = 3 ; j-- = 2]
            //      *         [j = 1; 1 > i = 1 ; j-- = 1]


            //for (int i = 0; i <= n; i++) {

            //    for (int j = 0; j <= n; j++) {

            //        if (j <= n - i)
            //        {

            //            Console.Write("   ");

            //        }else Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region vẽ tam giác vuông ngược
            // * * * *  n = 4 [j = 4; 4 > i = 1 ; j-- = 4]
            // * * *          [j = 3; 3 > i = 2 ; j-- = 3]
            // * *            [j = 2; 2 > i = 3 ; j-- = 2]
            // *              [j = 1; 1 > i = 1 ; j-- = 1]

            //Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //    {

            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region vẽ tam giác vuông ngược V2

            //Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\n");

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {

            //        Console.Write("   ");
            //    }

            //    for (int k = n; k > i; k--)
            //    {

            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region vẽ tam giác Cân

            // - - - *   
            // - - * * *
            // - * * * * *
            // * * * * * * *

            //Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{

            //    // in ra tam giác - ngược để cân chỉnh tam giác *
            //    for (int k = n; k >  i ; k--) { 

            //        Console.Write(" - ");
            //    }

            //    int x = i * 2 - 1; // công thức vẽ tam giác cân
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region vẽ tam giác Cân rỗng

            // - - - *          i = 1
            // - - * . *        j = 0
            // - * . . . *      j = x
            // * * * * * * *    i = n

            Console.Write("Bạn Muốn Tam Giac mấy dòng : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                // in ra tam giác - ngược để cân chỉnh tam giác *
                for (int k = n; k > i; k--)
                {

                    Console.Write("   ");
                }

                int x = i * 2 - 1; // công thức vẽ tam giác cân
                for (int j = 1; j <= x; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == x)
                    {

                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write(" . ");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region Tam giác cân số
            //    1
            //   2 3 2
            //  3 4 5 4 3
            // 4 5 6 7 6 5 4

            //int i; // thu tu dong
            //int k; // thu tu number
            //int num; // number
            //int h; // chia lay du number

            //Console.Write("Nhap vao so dong cua tam giac can : ");
            //int soDong = Convert.ToInt32(Console.ReadLine());


            //for (i = 0; i < soDong; i++)
            //{
            //    for (k = 0; k <= soDong - i - 2; k++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (k = soDong - i - 1; k <= soDong - 1; k++)
            //    {
            //        num = 2 * i + k - soDong + 2;
            //        h = num % 10;
            //        Console.Write("{0} ", h);
            //    }
            //    for (k = soDong; k <= soDong + i - 1; k++)
            //    {
            //        num = 2 * i - k + soDong;
            //        h = num % 10;
            //        Console.Write("{0} ", h);
            //    }
            //    for (k = soDong + i; k <= 2 * soDong - 1; k++)
            //    {
            //        Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
