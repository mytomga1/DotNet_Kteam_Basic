using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface.Interface
{
    internal class FPT : IRank
    {
        public string Ranking(float score)
        {
            if (score >= 4)
            {
                return "Giỏi";
            }
            else if (score >= 3)
            {
                return "Khá";
            }
            else if (score >= 2)
            {
                return "Hơi Non";
            }
            return "Tạch Tạch....";
        }
    }
}
