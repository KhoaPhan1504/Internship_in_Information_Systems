using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2_linq
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void Load_SanPham()
		{
			QLBanHangDataContext data = new QLBanHangDataContext();
			var sp = from p in data.SanPhams
					 select p;
			dataGridView1.DataSource = sp;
		}

		public void Load_ComboLoaiSP()
		{
			QLBanHangDataContext data = new QLBanHangDataContext();
			var lsp = from p in data.LoaiSPs
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

        private void button1_Click(object sender, EventArgs e)
        {
			QLBanHangDataContext data = new QLBanHangDataContext();
			SanPham them = new SanPham();
			them.MaSP = textBox1.Text.Trim();
			them.TenSP = textBox2.Text;
			them.MaLoai = comboBox1.SelectedValue.ToString();
			them.DonGia = Convert.ToInt32(textBox3.Text);
			data.SanPhams.InsertOnSubmit(them);
			data.SubmitChanges();
			Load_SanPham();
		}

		private void button2_Click(object sender, EventArgs e)
        {
			QLBanHangDataContext data = new QLBanHangDataContext();
			var capnhat = data.SanPhams.Single(sp => sp.MaSP == textBox1.Text);
			capnhat.TenSP = textBox2.Text;
			capnhat.MaLoai = comboBox1.SelectedValue.ToString();
			capnhat.DonGia = Convert.ToInt32(textBox3.Text);
			data.SubmitChanges();
			Load_SanPham();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Ban Co Chac Muon Xoa ! ", "Confirm", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				QLBanHangDataContext data = new QLBanHangDataContext();
				var xoa = from sp in data.SanPhams
						  where sp.MaSP == textBox1.Text
						  select sp;
				foreach (var i in xoa)
				{
					data.SanPhams.DeleteOnSubmit(i);
					data.SubmitChanges();
				}
				Load_SanPham();
			}
			else
			{
				MessageBox.Show("Ai Cho Xoa . AHihi Do Nghoc");
			}
		}
		int d;
		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			QLBanHangDataContext data = new QLBanHangDataContext();
			d = e.RowIndex;
			string masp = dataGridView1.Rows[d].Cells[0].Value.ToString();
			var sanPham = data.SanPhams.Where(s => s.MaSP == masp).FirstOrDefault();

			var LoaiSP = data.LoaiSPs.Where(s => s.MaLoai == sanPham.MaLoai).FirstOrDefault();

			textBox1.Text = sanPham.MaSP;
			textBox2.Text = sanPham.TenSP;

			comboBox1.SelectedItem = LoaiSP.MaLoai.ToString();
			comboBox1.Text = LoaiSP.TenLoai.ToString();
			textBox3.Text = Convert.ToInt32(sanPham.DonGia).ToString();
		}
		private void button4_Click(object sender, EventArgs e)
		{

			var cbBoxValue = comboBox1.SelectedValue.ToString();
			QLBanHangDataContext data = new QLBanHangDataContext();
			var lstSinhVien = data.SanPhams.Where(s => s.MaLoai == cbBoxValue).ToList();
			dataGridView1.DataSource = lstSinhVien;
		}

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
