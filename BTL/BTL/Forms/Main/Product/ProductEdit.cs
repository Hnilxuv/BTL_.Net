using BTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms.Main.Product
{
    public partial class ProductEdit : Form
    {
        QLBanMyPhamContext db;
        SanPham sp = new SanPham();
        string maSP;
        public ProductEdit()
        {
            InitializeComponent();
        }
        public ProductEdit(string s, QLBanMyPhamContext dt)
        {
            maSP = s;
            db = dt;
            InitializeComponent();
        }

        private void comboBoxTenDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxTenDanhMuc.SelectedIndex;
            if (index == -1)
            {
                comboBoxTenDanhMuc.Text = "";
                labelMaDanhMuc.Text = "";
            }
            else
            {
                string selectedItem = comboBoxTenDanhMuc.Items[index].ToString();
                var ten = db.DanhMucs.Where(s => s.TenDm == selectedItem).Select(s => new { tenDM = s.TenDm, maDM = s.MaDm }).FirstOrDefault();
                labelMaDanhMuc.Text = ten.maDM;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            sp = db.SanPhams.Find(maSP);

            //load thông tin san pham
            txtDonGia.Text = sp.DonGia.ToString();
            txtDonViTinh.Text = sp.DonViTinh.ToString();
            txtTenSanPham.Text = sp.TenSp;
            txtThuongHieu.Text = sp.ThuongHieu;
            txtXuatXu.Text = sp.XuatXu;
            labelMaDanhMuc.Text = sp.MaDm;
            string maDM = labelMaDanhMuc.Text;
            var DM = db.DanhMucs.Where(s => s.MaDm == maDM).FirstOrDefault();
            comboBoxTenDanhMuc.Text = DM.TenDm;

            //load ten danh muc
            List<DanhMuc> dsDM = new List<DanhMuc>();
            dsDM = db.DanhMucs.Select(s => s).ToList();
            foreach (var item in dsDM)
            {
                comboBoxTenDanhMuc.Items.Add(item.TenDm);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSanPham.Text.Trim() == "") throw new Exception("Tên sản phẩm không được để trống!");
                if (txtDonViTinh.Text.Trim() == "") throw new Exception("Đơn vị tính không được để trống!");
                if (txtDonGia.Text.Trim() == "") throw new Exception("Đơn giá không được để trống!");
                if (decimal.Parse(txtDonGia.Text.Trim()) < 0) throw new Exception("Đơn giá > 0");
                if (txtXuatXu.Text.Trim() == "") throw new Exception("Xuất xứ không được để trống!");
                if (txtThuongHieu.Text.Trim() == "") throw new Exception("Thương hiệu không được để trống!");
                if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal check)) throw new Exception("Đơn giá phải là số");
                if (comboBoxTenDanhMuc.Text.Trim() == "") throw new Exception("Vui lòng chọn danh mục!");

                string tenCheck = txtTenSanPham.Text.Trim();
                var check1 = db.SanPhams.Where(s => s.TenSp == tenCheck).FirstOrDefault();
                if (check1 != null)
                {
                    if (check1.TenSp == sp.TenSp)
                    {
                        sp.TenSp = txtTenSanPham.Text.Trim();
                        sp.DonGia = decimal.Parse(txtDonGia.Text.Trim());
                        sp.DonViTinh = txtDonViTinh.Text.Trim();
                        sp.XuatXu = txtXuatXu.Text.Trim();
                        sp.ThuongHieu = txtThuongHieu.Text.Trim();
                        sp.MaDm = labelMaDanhMuc.Text;
                        //Lưu db
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Tên sản phẩm này đã tồn tại");
                    }

                }
                else
                {
                    sp.TenSp = txtTenSanPham.Text.Trim();
                    sp.DonGia = decimal.Parse(txtDonGia.Text.Trim());
                    sp.DonViTinh = txtDonViTinh.Text.Trim();
                    sp.XuatXu = txtXuatXu.Text.Trim();
                    sp.ThuongHieu = txtThuongHieu.Text.Trim();
                    sp.MaDm = labelMaDanhMuc.Text;
                    //Lưu db
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
