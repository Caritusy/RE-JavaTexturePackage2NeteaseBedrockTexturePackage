using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE_JavaTexturePackage2NBTP.SDK
{
    public static class ListExtend
    {
        public static void Swap<T>(this List<T> list, int index1, int index2)
        {
            if (index1 < 0 || index1 >= list.Count || index2 < 0 || index2 >= list.Count)
            {
                throw new ArgumentOutOfRangeException("index1 和 index2 必须在列表的有效索引范围内");
            }

            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
