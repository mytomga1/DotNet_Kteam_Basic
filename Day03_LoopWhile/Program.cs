using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region VD đơn giản Loop While
            //int count = 0;

            //while (count < 10) { 
            //    Console.WriteLine(count);
            //    count++;
            //}
            #endregion

            #region VD Ma trận số
            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;


            //// Vẽ từ trên xuống LoopTime lần
            //while (countLoopTime < loopTime)
            //{
            //    // reset lại biến countLoop về 0 để viết lại từ đầu
            //    countLoop = 0;


            //    // vẽ từ trái qua valueNum lần
            //    while (countLoop < valueNum)
            //    {

            //        // in ra giá trị của countLoop trong 8 vị trí
            //        Console.Write("{0,3}", countLoop);


            //        // tăng giá trị của biến countLoop lên một đơn vị
            //        countLoop++;
            //    }


            //    // Mỗi khi hoàn thành một vòng lặp nhỏ thì lại xuống dòng chuẩn vị vẽ lần tiếp theo
            //    Console.WriteLine();


            //    // tăng giá trị countLoopTime lên một đơn vị
            //    countLoopTime++;
            //}
            #endregion

            #region Vẽ hình chữ nhật
            //int n = 10; // dai
            //int m = 20; // rong
            //char inchar = '*';
            //char nochar = ' ';
            //int i = 0;
            //int j = 0;

            //while (i < n)
            //{
            //    j = 0;
            //    while (j < m)
            //    {
            //        if (i % (n - 1) == 0 || j % (m - 1) == 0)
            //        { Console.Write(inchar); }
            //        else
            //        { Console.Write(nochar); }
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            #endregion

            Console.ReadLine();
        }

        
    }
}
