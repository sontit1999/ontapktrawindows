using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    class ThuocTroGia : Thuoc
    {
        string _loaibenh;
        public string loaibenh
        {
            get { return _loaibenh; }
            set { _loaibenh = value; }
        }
        public ThuocTroGia() : base()
        {

        }
        public ThuocTroGia(string mt, string tt, string tbd, string dvt, int sl, int dg,string lb) : base(mt, tt, tbd, dvt, sl, dg)
        {
            this._loaibenh = lb;
        }
        public override double Tinhtien()
        {    
            if(loaibenh.Equals("Lung cancer"))
            {
                return soluong * dongia * 0.9;
            }
            else if (loaibenh.Equals("Lymphorna leukemia"))
            {
                return soluong * dongia * 0.8;
            }
            else if(loaibenh.Equals("Acute leukemia"))
            {
                return soluong * dongia * 0.7;
            }
            return soluong * dongia;
            //return soluong * dongia;
        }
    }
}
