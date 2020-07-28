using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    class ThuocComparator : IComparer<ThuocTroGia>
    {
        public int Compare(ThuocTroGia x, ThuocTroGia y)
        {
            return x.Tinhtien().CompareTo(y.Tinhtien());
        }
    }
}
