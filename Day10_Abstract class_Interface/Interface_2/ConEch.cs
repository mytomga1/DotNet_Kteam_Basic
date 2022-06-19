using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface.Interface_2
{
    internal class ConEch : IWaterAnimal, IlandAnimal
    {
        public void Swin() 
        {
            Console.WriteLine("Con ếch kế thừa từ InterFace WaterAnimal nên nó học dc khả năng bơi.");
        }
        public void Jumps()
        {
            Console.WriteLine("Con ếch kế thừa từ InterFace IlandAnimal nên nó học dc khả năng nhảy.");
        }

        // Nếu gặp trường hợp đa kế thừa có 2 interface có cùng 1 method Moved() thì ta phải loại bỏ phạm vi truy cập đi, để có thể khai báo.
        void IWaterAnimal.Moved()
        {
            Console.WriteLine("Con ếch kế thừa từ InterFace WaterAnimal nên nó học dc khả năng đi dưới nước.");
        }

        void IlandAnimal.Moved()
        {
            Console.WriteLine("Con ếch kế thừa từ InterFace IlandAnimal nên nó học dc khả năng đi trên bờ.");
        }

    }
}

