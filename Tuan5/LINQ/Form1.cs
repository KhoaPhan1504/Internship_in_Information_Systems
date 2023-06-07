using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        /*string strConnectionString = @"Data Source=PCLAP\SQLEXPRESS; Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;*/
        public Form1()
        {
            InitializeComponent();
        }

        dbContext db = new dbContext();//Name của Linq
        public void Load_SanPham()
        {
            
            var sp = from p in data.SanPham
                     select p;
            dataGridView1.DataSource = sp;

            

            /*dbDataContext data = new dbDataContext();
            SanPham them = new SanPham();
            them.MaSP = textBox1.Text.Trim();
            them.TenSP = textBox2.Text;
            them.MaLoai = comboBox1.SelectedValue.ToString();*/
        }
        public void Load_ComboLoaiSP()
        {
            dbDataContext data = new dbDataContext();
            var lsp = from p in data.LoaiSP
                      select p;
            comboBox1.DataSource = lsp;
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";  
        }

        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_SanPham();
            Load_ComboLoaiSP();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            SanPham them = new SanPham();
            them.MaSP = textBox1.Text.Trim();
            them.TenSP = textBox2.Text;
            them.MaLoai = comboBox1.SelectedValue.ToString();
            them.DonGia = Convert.ToInt32(textBox3.Text);
            data.SanPham.InsertOnSubmit(them);
            data.SubmitChanges();
            Load_SanPham();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var capnhat = data.SanPham.Single(sp => sp.MaSP == textBox1.Text);
            capnhat.TenSP = textBox2.Text;
            capnhat.MaLoai = comboBox1.SelectedValue.ToString();
            capnhat.DonGia = Convert.ToInt32(textBox3.Text);
            SanPham them = new SanPham();
            data.SubmitChanges();
            Load_SanPham();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbDataContext data = new dbDataContext();
            var xoa = from sp in data.SanPham
                      where sp.MaSP == textBox1.Text
                      select sp;
            foreach (var i in xoa)
            {
                data.SanPham.DeleteOnSubmit(i);
                data.SubmitChanges();
            }
            Load_SanPham();
        }
    }
}
