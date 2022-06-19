using Day10_Abstract_class_Interface.Interface;
using Day10_Abstract_class_Interface.Interface_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Abstract class

            //Aminal cat = new Cat();
            //Aminal dog = new Dog();

            //cat.Eat();
            //dog.Eat();

            //cat.Sound();
            //dog.Sound();

            #endregion

            #region Interface VD 1

            //IRank fpt = new FPT();
            //IRank greenwich = new Greenwich();

            //Console.WriteLine("Sinh Viên A của trường FPT dc 3 điểm đạt loại : " + fpt.Ranking(3));
            //Console.WriteLine();
            //Console.WriteLine("Sinh Viên B của trường Greenwich dc 4 điểm đạt loại : " + greenwich.Ranking(4));

            #endregion

            #region Interface VD 2 Đa Kế Thừa khi sử dụng Interface

            ConEch ech = new ConEch();
            ech.Swin();
            ech.Jumps();
            Console.WriteLine();

            Console.WriteLine("Nếu trong trường hợp trong 2 Interface có trùng 1 method thì chúng ta phải chỉ rỏ ra con ech sài method đó từ Interface nào");
            (ech as IlandAnimal).Moved();
            (ech as IWaterAnimal).Moved();


            #endregion

            Console.ReadLine();
        }
    }
}
