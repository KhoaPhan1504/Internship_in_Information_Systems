using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);
            double delta = b * b - 4 * a * c;
            string nghiem = "";
            if (a != 0)
            {
                if (delta < 0)
                    nghiem = "pt vô nghiệm";
                else if (delta == 0)
                    nghiem = "x1 = x2 = " + (-b / (2 * a)).ToString();
                else
                {
                    double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                    double x2 = (-b - Math.Sqrt(delta) / (2 * a));
                    nghiem = "x1 = " + x1.ToString() + "\t\t x2 = " + x2.ToString();
                }
            }
            if  ( a == 0)
            {
                if (b != 0)
                    nghiem = "x = " + (-c / b).ToString();
                else if (c == 0)
                    nghiem = "pt vô số nghiệm";
                else
                    nghiem = " pt vô nghiệm";
            }
            txtnghiem.Text = nghiem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
