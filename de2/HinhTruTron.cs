using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2
{
    class HinhTruTron : Hinh3D
    {
        double _r;
        double _h;
        public double bankinh
        {
            get { return _r; }
            set { _r = value; }
        }
        public double chieucao
        {
            get { return _h; }
            set { _h = value; }
        }
        public HinhTruTron()
        {
            
        }
        public HinhTruTron(string lh, double bk ,double ck) : base(lh)
        {
            this._r = bk;
            this._h = ck;
        }
        public override double tinhTheTich()
        {
            return Math.PI * _r * _r * _h;
        }
        public override double tinhDienTichXQ()
        {
            return 2* Math.PI * _r  * _h;
        }
    }
}
