using Day10_Abstract_class_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface
{
    internal class Greenwich : IRank
    {
        public string Ranking(float score)
        {
            if (score >=4.5)
            {
                return "Fisrt Class";
            }
            else if (score >= 3.5)
            {
                return "Second Class";
            }
            else if (score >= 2.5)
            {
                return "Third Class";
            }
            return "Fail";
        } 
    }
}
