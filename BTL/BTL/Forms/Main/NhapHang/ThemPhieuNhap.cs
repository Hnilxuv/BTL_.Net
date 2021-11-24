using BTL.Models;
using BTL.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms.Main.NhapHang
{
    public partial class ThemPhieuNhap : Form
    {
        QLBanMyPhamContext db = new QLBanMyPhamContext();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        TaiKhoan currentUser;
        int rowIndex;
        public ThemPhieuNhap(TaiKhoan user)
        {
            InitializeComponent();
            currentUser = user;
        }

     
        

      

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text.Trim().Length == 0)
                {
                    throw new Exception("Không được để trống keywords");
                }
                // lấy phiếu đặt hàng không có ở nhập hàng
                List<PhieuDatHang> pdh = (from c in db.PhieuDatHangs 
                           where !((from o in db.PhieuNhaps select o.MaPhieuDat).Contains(c.MaPhieuDat))
                           && c.MaPhieuDat == txtTimKiem.Text.Trim()
                           select c).ToList();
                
                if(pdh.Count != 0)
                {
                   
                    var dpdh = db.DongPhieuDats.Where(s => s.MaPhieuDat == txtTimKiem.Text.Trim()).ToList();
                    foreach (var item in dpdh)
                    {
                        SanPham sp = db.SanPhams.Find(item.MaSp);
                        dataGridView1.Rows.Add(item.MaSp, sp.TenSp, item.SoLuongDat, item.SoLuongDat, ((decimal)item.GiaDat).ToString("#,###", cul.NumberFormat));
                    }
                }
                else
                {
                    throw new Exception("Phiếu không hợp lệ");
                }
                     
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtMaSP.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtSL.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //DongPhieuDat dpd = db.DongPhieuDats.FirstOrDefault(s => s.MaSp == txtMaSP.Text.Trim() && s.MaPhieuDat == txtTimKiem.Text.Trim());
                //dpd.SoLuongDat = Int32.Parse(txtSL.Text);
                //db.SaveChanges();
                //dataGridView1.Rows.Clear();
                //var dpdh = db.DongPhieuDats.Where(s => s.MaPhieuDat == txtTimKiem.Text.Trim()).ToList();
                //foreach (var item in dpdh)
                //{
                //    SanPham sp = db.SanPhams.Find(item.MaSp);
                //    dataGridView1.Rows.Add(item.MaSp, sp.TenSp, item.SoLuongDat, item.SoLuongDat, ((decimal)item.GiaDat).ToString("#,###", cul.NumberFormat));
                //}
                String maSp = txtMaSP.Text;
                int slSp = int.Parse(txtSL.Text);
                if (maSp == "")
                    throw new Exception("Mã sản phẩm không được để trống!");
                if (slSp < 0)
                    throw new Exception("Số lượng sản phẩm phải lớn hơn 0!");
                dataGridView1.Rows[rowIndex].Cells[3].Value = txtSL.Text.Trim();
             
            }
            catch (FormatException ex2)
            {
                MessageBox.Show("Số lượng không đúng định dạng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {
            
            //cbxNguoiNhap.DataSource = (from em in db.NhanViens
            //                           select new { em.MaNv, em.TenNv }).ToList();
            //cbxNguoiNhap.ValueMember = "MaNV";
            //cbxNguoiNhap.DisplayMember = "TenNV";
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "") throw new Exception("Bạn cần tìm phiếu đặt trước");
                if (txtMaSP.Text == "") throw new Exception("Bạn chưa nhập mã sản phẩm");
                else if (txtSL.Text == "") throw new Exception("Bạn chưa nhập số lượng");
                else if(int.Parse(txtSL.Text)<0)
                    throw new Exception("Số lượng phải >0");


                PhieuNhap pn = new PhieuNhap();
                pn.MaPhieuNhap = Ultility.generateId("PN");
                pn.ThanhToan = "Chuyển khoản";
                pn.NgayNhap = DateTime.Now;
                pn.MaNv = currentUser.MaNv;
                pn.MaPhieuDat = txtTimKiem.Text.Trim();
                db.PhieuNhaps.Add(pn);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DongPhieuNhap dpnh = new DongPhieuNhap();
                    dpnh.MaPhieuNhap = pn.MaPhieuNhap;
                    dpnh.MaSp = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    dpnh.SoLuong = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    dpnh.GiaNhap = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString(), cul);

                    var sp = db.SanPhams.Find(dpnh.MaSp);
                    sp.Slton += (int)dpnh.SoLuong;

                    db.DongPhieuNhaps.Add(dpnh);
                }

                db.SaveChanges();
                Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(/*ex.InnerException.ToString()*/ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
