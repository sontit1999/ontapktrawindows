using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1
{
    class Thuoc
    {
         string _mathuoc;
         string _tenthuoc;
         string _tenbietduoc;
         string _dovitinh;
         int _soluong;
         int _dongia;
        public string mathuoc{
            get{ return _mathuoc;}
            set{ _mathuoc = value; }
        }
        public string tenthuoc
        {
            get { return _tenthuoc; }
            set { _tenthuoc = value; }
        }
        public string tenbietduoc
        {
            get { return _tenbietduoc; }
            set { _tenbietduoc = value; }
        }
        public string dovitinh
        {
            get { return _dovitinh; }
            set { _dovitinh = value; }
        }
        public int soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public int dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        public Thuoc()
        {

        }
        public Thuoc(string mt,string tt,string tbd,string dvt,int sl,int dg)
        {
            this._mathuoc = mt;
            this._tenthuoc = tt;
            this._tenbietduoc = tbd;
            this._dovitinh = dvt;
            this._soluong = sl;
            this._dongia = dg;
        }
        public virtual double Tinhtien()
        {
            return _soluong * _dongia;
        }
    }
}
