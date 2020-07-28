using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1
{
    public partial class Form1 : Form
    {   
        List<ThuocTroGia> list = new List<ThuocTroGia>();
       
        public Form1()
        {
            InitializeComponent();
           
        }

       

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            list.Sort(new ThuocComparator());
            list.Reverse();
            hienthi();       
        }
        public void hienthi()
        {
            listView1.Items.Clear();
            foreach (ThuocTroGia i in list)
            {
                 String[] arr = new string[7] { i.mathuoc, i.tenthuoc, i.tenbietduoc,i.dovitinh,i.soluong.ToString(),i.dongia.ToString(),i.Tinhtien().ToString()};
                 listView1.Items.Add(new ListViewItem(arr));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            
            listView1.View = View.Details;
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThuocTroGia thuocTroGia;
            if (radioButton1.Checked)
            {
                thuocTroGia = new ThuocTroGia(txtMathuoc.Text, txtTenthuoc.Text, txtTenbietduoc.Text, txtDonvitinh.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDongia.Text), "Lung cancer");
                list.Add(thuocTroGia);
            }
            if (radioButton2.Checked)
            {
                thuocTroGia = new ThuocTroGia(txtMathuoc.Text, txtTenthuoc.Text, txtTenbietduoc.Text, txtDonvitinh.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDongia.Text), "Acute lenkenmia");
                list.Add(thuocTroGia);
            }
            if (radioButton3.Checked)
            {
                thuocTroGia = new ThuocTroGia(txtMathuoc.Text, txtTenthuoc.Text, txtTenbietduoc.Text, txtDonvitinh.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDongia.Text), "Lymphorna leukemia");
                list.Add(thuocTroGia);
            }
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         
            txtMathuoc.Text = "";
            txtTenthuoc.Text = "";
            txtTenbietduoc.Text = "";
            txtSoLuong.Text = "";
            txtDongia.Text = "";
            txtDonvitinh.Text = "";
            radioButton1.Checked = true;
        }
    }
}
