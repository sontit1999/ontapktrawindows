using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2
{
    class Hinh3D
    {
        private string _loaihinh;
        public string loaihinh
        {
            get { return _loaihinh; }
            set { _loaihinh = value; }
        }
        public Hinh3D()
        {

        }
        public Hinh3D(string lh)
        {
            _loaihinh = lh;
        }
        public virtual double tinhTheTich() {
            return 0;
        }
        public virtual double tinhDienTichXQ()
        {
            return 0;
        }
    }
}
