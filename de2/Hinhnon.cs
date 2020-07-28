using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2
{
    class Hinhnon : Hinh3D
    {
        double _r;
        double _h;
        double _l;
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
            public double duongsinh
        {
            get { return _l; }
            set { _l = value; }
        }
        public Hinhnon()
        {
           
        }
        public Hinhnon(string lh,double bk,double ck,double ds) : base(lh)
        {
            this._r = bk;
            this._h = ck;
            this._l = ds;
        }
        public override double tinhDienTichXQ()
        {
            return Math.PI * _r * _l ;
        }
        public override double tinhTheTich()
        {
            return (Math.PI * _r * _r * _h) / 3;
        }
    }
}
