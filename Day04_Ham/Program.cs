using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Ham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool checkTuoi;

            string str = "";
            int i;
            
            Console.Write("Tên Gì ? : ");
            str = Console.ReadLine();
            str = str.ToUpper();

            Nhaplai:
            Console.Write("Bao Nhiêu Tuổi ? : ");
            //i = Convert.ToInt32(Console.ReadLine());
            checkTuoi = int.TryParse(Console.ReadLine(), out i);

            if (checkTuoi==false) { // sử dụng hàm tryparse để check lỗi kiểu dữ liệu

                Console.WriteLine("Tuổi sai kiểu dữ liệu, yêu cầu nhập đúng !!");
                goto Nhaplai;

            }else


            Console.Write("\n");

            indaicaigido(str, i);

            Console.ReadLine();
        }
        static void indaicaigido(string name, int age)
        {
            string testchu = "test";

            if (age == 1 || age == 0)
            {

                Console.WriteLine("Name : {0}, Year old: {1}", name, age);
            }
            else if (age < 0)
            {
                Console.WriteLine("Nhập Lại tuổi đi, để số âm mà dc à @@ !!!");
            }
            else if (age.GetType() == testchu.GetType())
            {
                Console.WriteLine("Nhập Lại tuổi đi @@ !!!");
            }
            else if (name.Length < 2) {

                Console.WriteLine("Nhập Lại Tên đi, Tên ngắn quá @@ !!!");
            }
            else Console.WriteLine("Name : {0}, Years old: {1}", name, age);
        }

        
    }
}
