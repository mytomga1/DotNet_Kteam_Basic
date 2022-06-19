using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface
{
    internal class Cat : Aminal
    {
        public override void Eat() 
        {
            Console.WriteLine("Con Mều Ăn Cá (Do con Mều sài tính trừu tượng virtual-override nên nó dc ăn cá )");
        }
        public override void Sound() 
        {

            Console.WriteLine("\n Con Mều kêu mew mew");
        }
    }
}
