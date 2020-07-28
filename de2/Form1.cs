using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de2
{ 
    public partial class Form1 : Form
    {
        List<Hinh3D> list = new List<Hinh3D>();
        public Form1()
        {
            InitializeComponent();
            rbNon.Checked = true;
            comboBox1.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selected index " + comboBox1.SelectedIndex + " selected item :" + comboBox1.SelectedItem.ToString());
            if (rbLangtru.Checked)
            {
                // thêm hình lăng trụ
                HinhTruTron hinhTruTron = new HinhTruTron("langtru", double.Parse( txtBanKinh.Text), double.Parse(txtCHieucao.Text));
                list.Add(hinhTruTron);
            }
            else
            {
                Hinhnon hinhnon = new Hinhnon("non", double.Parse(txtBanKinh.Text), double.Parse(txtCHieucao.Text), double.Parse(txtDuongsinh.Text));
                list.Add(hinhnon);
            }
            hienthi();
        }

        private void hienthi()
        {
            listView1.Items.Clear();
            foreach(Hinh3D i in list)
            {
                if (i.loaihinh.Equals("non"))
                {
                    Hinhnon x = (Hinhnon)i;
                    String[] arr = new String[6] { x.loaihinh ,", chiều cao: " + x.chieucao, ",bán kính:" + x.bankinh , "đường sinh: " + x.duongsinh , "DTXQ: " + x.tinhDienTichXQ() , ", Thể tích: " + x.tinhTheTich() };
                    listView1.Items.Add(new ListViewItem(arr));
                }
                else
                {
                    HinhTruTron x = (HinhTruTron)i;
                    String[] arr = new String[6] { x.loaihinh, ", chiều cao: " + x.chieucao, ",bán kính:" + x.bankinh, "đường sinh: null ", "DTXQ: " + x.tinhDienTichXQ(), ", Thể tích: " + x.tinhTheTich() };
                    listView1.Items.Add(new ListViewItem(arr));
                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtBanKinh.Text = "";
            txtCHieucao.Text = "";
            txtDuongsinh.Text = "";
            comboBox1.SelectedIndex = 0;
            rbNon.Checked = true;
        }

        private void btnDsnon_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Hinh3D i in list)
            {
                if (i.loaihinh.Equals("non"))
                {
                    Hinhnon x = (Hinhnon)i;
                    String[] arr = new String[6] { x.loaihinh, ", chiều cao: " + x.chieucao, ",bán kính:" + x.bankinh, "đường sinh: " + x.duongsinh, "DTXQ: " + x.tinhDienTichXQ(), ", Thể tích: " + x.tinhTheTich() };
                    listView1.Items.Add(new ListViewItem(arr));
                }
                

            }
        }

        private void rbNon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLangtru.Checked)
            {
                txtDuongsinh.Enabled = false;
            }
            else
            {
                txtDuongsinh.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
