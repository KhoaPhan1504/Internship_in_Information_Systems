using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        QLLUONGDataContext db = new QLLUONGDataContext(); //name của linq

        private void btncau1_Click(object sender, EventArgs e)
        {
            //hiển thị dữ liệu bảng NhanVien
            var listNhanVien = db.nhanviens.Select(nv => nv);
            dataGridView1.DataSource = listNhanVien;

            /*cách 2:
            var listNhanVien = from p in db.nhanviens
                               select p;*/

            //hiển thị dữ liệu bảng ChucVu
            var listChucVu = db.chucvus.Select(cv => cv);
            dataGridView1.DataSource = listChucVu;

            //hiển thị dữ liệu bảng DonVi
            var listDonVi = db.donvis.Select(dv => dv);
            dataGridView1.DataSource = listDonVi;
        }

        private void btncau2_Click(object sender, EventArgs e)
        {
            //đưa ra thông tin sau: manv, hoten, ngaysinh, hsluong
            var listNhanVien = db.nhanviens.Select(s => new { s.manv, s.hoten, s.ngaysinh, s.hsluong });
            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau3_Click(object sender, EventArgs e)
        {
            //đưa ra thông tin nhân viên có hệ số lương cao nhất
            var listNhanVien = db.nhanviens.OrderByDescending(s => s.hsluong).Skip(0).Take(1)
                .Select(s => new { s.manv, s.hoten, s.ngaysinh, s.hsluong });
            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau4_Click(object sender, EventArgs e)
        {
            //đưa ra thông tin: manv, hoten, ngaysinh, tendv
            var listNhanVien = db.nhanviens.Join(db.donvis,
                                                 nv => nv.madv,
                                                 dv => dv.madv,
                                                 (nv, dv) => new
                                                 {
                                                     nv.manv,
                                                     nv.hoten,
                                                     nv.ngaysinh,
                                                     dv.tendv
                                                 });
            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau5_Click(object sender, EventArgs e)
        {
            //Đưa ra các thông tin: manv, hoten, ngaysinh, hsluong, phucap, tendv
            var listNhanVien = db.nhanviens.Join(db.donvis,
                                                 nv => nv.madv,
                                                 dv => dv.madv,
                                                 (nv, dv) => new { nv, dv })
                                           .Join(db.chucvus,
                                                nvs => nvs.nv.macv,
                                                dv => dv.macv,
                                                (nvs, dv) => new { nvs, dv })
                                           .Select(s => new
                                           {
                                               s.nvs.nv.manv,
                                               s.nvs.nv.hoten,
                                               s.nvs.nv.ngaysinh,
                                               s.nvs.nv.hsluong,
                                               s.dv.phucap,
                                               s.nvs.dv.tendv,
                                           });
            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau6_Click(object sender, EventArgs e)
        {
            //đưa ra các thông tin: manv, hoten, ngaysinh, hsluong, luong = hsluong * 830000 + phucap
            var listNhanVien = db.nhanviens.Join(db.chucvus,
                                                nv => nv.macv,
                                                cv => cv.macv,
                                                (nv, cv) => new {
                                                    nv.manv,
                                                    nv.hoten,
                                                    nv.ngaysinh,
                                                    nv.hsluong,
                                                    luong = cv.phucap + nv.hsluong * 830000
                                                });
            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau7_Click(object sender, EventArgs e)
        {
            //Đưa ra các nhân viên có trình độ “Tiến sĩ‟ được sắp xếp giảm dần theo HSLuong gồm các thông tin: manv, hoten, gioitinh, hsluong, trinhdo, tendv
            var listNhanVien = db.nhanviens.Where(s => s.trinhdo == "tien si")
                                           .OrderByDescending(s => s.hsluong)
                                           .Join(db.donvis, 
                                                 nv => nv.madv, 
                                                 dv => dv.madv, 
                                                 (nv, dv) => new { nv.manv, nv.hoten, nv.hsluong, nv.trinhdo, dv.tendv });

            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau8_Click(object sender, EventArgs e)
        {
            //Thống kê số nhân viên trong từng đơn vị với các thông tin: madv, số người
            var listNhanVien = from nv in db.nhanviens
                              join dv in db.donvis
                              on nv.madv equals dv.madv
                              group dv by dv.madv into groupResult
                              select new
                              {
                                  MaDV = groupResult.Key,
                                  Soluong = groupResult.Count()
                              };


            dataGridView1.DataSource = listNhanVien;
        }

        private void btncau9_Click(object sender, EventArgs e)
        {
            //thống kê tổng lương trong từng đơn vị với các thông tin: madv, Tổng lương. 
            var listNhanVien = from nv in db.nhanviens
                               join dv in db.donvis
                               on nv.madv equals dv.madv
                               join cv in db.chucvus
                               on nv.macv equals cv.macv
                               let luong = nv.hsluong + cv.phucap
                               group new { nv, dv, cv } by new { dv.madv } into groupResult

                               select new
                               {
                                   MaDV = groupResult.First().dv.madv,
                                   TongLuong = groupResult.Sum(s => s.nv.hsluong * 8300)
                               };
            dataGridView1.DataSource = listNhanVien;
        }
    }
}
