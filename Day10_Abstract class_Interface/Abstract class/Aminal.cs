using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface
{
    abstract class Aminal
    {  
        public virtual void Eat() 
        {
            Console.WriteLine("Tất Cả các động vật điều ăn cỏ nếu thằng đó ko khai báo tính chất trừ tượng virtual-override thì ăn cỏ");
        }

        public abstract void Sound();
    }
}
