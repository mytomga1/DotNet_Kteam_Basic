using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Abstract_class_Interface.Interface
{
    /*
     * interface dc coi nhưng là 1 nền móng dc quy ước để cái class khác HIỆN THỰC mà áp dụng xây dựng & triển khai theo.
     * kế thừa là sử những cái có sẵn từ thằng cha mà áp dụng hay phát triển thêm.
     * HIỆN THỰC [Interface] là 1 nền móng dc quy ước sẳn các lớp khác chỉ cần kế thừa mà làm theo cái quy ước ấy.
    */
    internal interface IRank
    {
        string Ranking(float score); // tạo 1 phương thức xếp loại.
    }
}
