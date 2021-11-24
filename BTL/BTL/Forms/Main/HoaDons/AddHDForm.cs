using BTL.Forms.Main.Customer;
using BTL.Forms.Main.HoaDons;
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

namespace BTL.Forms.Main.HoaDon
{
    public partial class AddHDForm : Form
    {
        
        Models.QLBanMyPhamContext db;
        KhachHang kh = new KhachHang();
        SanPham sp = new SanPham();
        Models.HoaDon hd = new Models.HoaDon();
        TaiKhoan user;
        CultureInfo cul;
        public AddHDForm(Models.QLBanMyPhamContext dt, TaiKhoan x)
        {
            db = dt;
            user = x;
            InitializeComponent();
        }
        private void IbtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text.Trim() == "") throw new Exception("SĐT không được để trống!");
                kh = db.KhachHangs.Where(s => s.Sdt == txtSDT.Text.Trim()).SingleOrDefault();
                if (kh != null)
                {
                    txtSDT.ReadOnly = true;
                    txtHoTen.Text = kh.TenKh;
                    txtTichDiem.Text = kh.TichDiem.ToString();
                }
                else
                {
                    if (MessageBox.Show("Không tìm thấy khách hàng nào có số điện thoại này!\nBạn muốn thêm khách hàng mới không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AddFormKH khForm = new AddFormKH(db);
                        khForm.StartPosition = FormStartPosition.CenterScreen;
                        khForm.Tag = txtSDT.Text;
                        khForm.ShowDialog();
                        khForm.TopMost = true;
                        if (khForm.Tag == null) throw new Exception("Lỗi nhập dữ liệu khách hàng");
                        kh = (KhachHang)khForm.Tag;
                        txtSDT.ReadOnly = true;
                        txtHoTen.Text = kh.TenKh;
                        txtTichDiem.Text = kh.TichDiem.ToString();
                    }
                }  
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void iBtnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(dataSP.Rows.Count>0)
                    {
                        for (int i = 0; i < dataSP.Rows.Count; i++)
                        {
                            sp = db.SanPhams.Find(dataSP.Rows[i].Cells[0].Value.ToString());
                            sp.Slton += (int)dataSP.Rows[i].Cells[2].Value;
                        }

                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iBtnLoadKH_Click(object sender, EventArgs e)
        {
            txtSDT.ReadOnly = false;
            txtSDT.Clear();
            txtHoTen.Clear();
            txtTichDiem.Text = "0";
            kh = null;
        }
        private void loadSP()
        {
            txtMaSP.ReadOnly = false;
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSLTon.Clear();
            txtDG.Clear();
            txtGKM.Clear();
            sp = null;
        }
        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp == null) throw new Exception("Không được bỏ trống thông tin sản phẩm!"); 
                AddSLForm slForm = new AddSLForm();
                slForm.TopMost = true;
                slForm.ShowDialog();
                if (slForm.Tag == null) throw new Exception("Lỗi nhập dữ liệu!!!");
                int soluongmua = (int)slForm.Tag;
                if (soluongmua > sp.Slton) throw new Exception("Số lượng tồn nhỏ hơn số lượng mua!");
                sp.Slton -= soluongmua;

                int index= 0;
                for (int i = 0; i < dataSP.Rows.Count; i++)
                {
                    if(dataSP.Rows[i].Cells[0].Value.ToString()==sp.MaSp)
                    {
                        index++;
                        dataSP.Rows[i].Cells[2].Value = int.Parse(dataSP.Rows[i].Cells[2].Value.ToString()) + soluongmua;
                        dataSP.Rows[i].Cells[4].Value = int.Parse(dataSP.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataSP.Rows[i].Cells[3].Value.ToString());
                        break;
                    }    
                }

                if(index == 0)
                {
                    int thanhTien = int.Parse(txtGKM.Text) * soluongmua;
                    dataSP.Rows.Add(sp.MaSp, sp.TenSp, soluongmua, txtGKM.Text, thanhTien);
                }
                loadSP();
                int Tong = 0;
                for (int i = 0; i < dataSP.Rows.Count; i++)
                {
                    Tong +=(int) dataSP.Rows[i].Cells[4].Value;
                }
                labTongTien.Text = Tong.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void iBtnLoadSP_Click(object sender, EventArgs e)
        {
            loadSP();
        }

        private void iBtnCheckSP_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSP.Text.Trim()=="") throw new Exception("Mã Sản Phẩm không được bỏ trống!");
                sp = db.SanPhams.Find(txtMaSP.Text); 
                if (sp == null) throw new Exception("Không tìm thấy sản phẩm có mã " + txtMaSP.Text);
                else
                {
                    txtMaSP.ReadOnly = true;
                    txtTenSP.Text = sp.TenSp;
                    txtSLTon.Text = sp.Slton.ToString();
                    txtDG.Text = ((int)sp.DonGia).ToString();
                    
                    SanPhamKm spkm = db.SanPhamKms.Where(s => s.MaSp == sp.MaSp).FirstOrDefault();
                    if (spkm == null)
                    {
                        txtGKM.Text = txtDG.Text;
                    }
                    else
                    {
                        KhuyenMai km = db.KhuyenMais.Find(spkm.MaKm);
                        spkm.GiaKm = (int)(sp.DonGia - km.GiamGia * sp.DonGia /100);
                        txtGKM.Text = spkm.GiaKm.ToString();
                    }
                    
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoaHang()
        {
            try
            {
                if (dataSP.Rows.Count == 0) throw new Exception("Không có hàng trong giỏ!");
                int indexOfRow = dataSP.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataSP.Rows[indexOfRow];
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm " + row.Cells[1].Value, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var sp1 = db.SanPhams.Find(row.Cells["MaSP"].Value.ToString());
                    sp1.Slton = sp1.Slton + int.Parse(row.Cells[2].Value.ToString());
                    int Tong = int.Parse(labTongTien.Text);
                    Tong -= int.Parse(row.Cells[4].Value.ToString());
                    labTongTien.Text = Tong.ToString();
                    dataSP.Rows.Remove(row);
                }
                db.SaveChanges();
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                xoaHang();
                if (dataSP.Rows.Count == 0)
                {
                    if (iBtnSdd.Text == "Bỏ Sử Dụng Điểm")
                    {
                        iBtnLoadKH.Visible = true;
                        labTongTien.Text = "0";
                        labChietKhau.Text = "0";
                        iBtnSdd.Text = "Sử Dụng Điểm";
                    }
                }   
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AddHDForm_Load(object sender, EventArgs e)
        {
            sp = null;
            kh = null;
        }

        private void iBtnSdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (kh == null) throw new Exception("Khách hàng không được bỏ trống!");
                int Tong;
                Tong = int.Parse(labTongTien.Text);
                if(iBtnSdd.Text== "Sử Dụng Điểm")
                {
                    iBtnLoadKH.Visible = true;
                    if (dataSP.Rows.Count == 0) throw new Exception("Chưa có hàng vào giỏ!");
                    int chietKhau;
                    chietKhau =(int)kh.TichDiem*20;
                    labChietKhau.Text = chietKhau.ToString();
                    if(chietKhau>Tong) 
                        Tong = 0;   
                    else
                        Tong -= chietKhau;
                    labTongTien.Text = Tong.ToString();
                    iBtnSdd.Text = "Bỏ Sử Dụng Điểm";
                    iBtnLoadKH.Visible = false;
                }    
                else
                {
                    iBtnLoadKH.Visible = true;
                    Tong += int.Parse(labChietKhau.Text);
                    labTongTien.Text = Tong.ToString();
                    labChietKhau.Text = "0";
                    iBtnSdd.Text = "Sử Dụng Điểm";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iBtnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (kh == null) throw new Exception("Khách hàng không được bỏ trống!");
                if (dataSP.Rows.Count == 0) throw new Exception("Chưa có hàng vào giỏ!");
                hd.MaHd = Ultility.generateId("HD");
                hd.MaKh = kh.MaKh;
                hd.NgayLap = DateTime.Now;
                hd.MaNv = user.MaNv;
                int ChietKhau = int.Parse(labChietKhau.Text);
                int TongTien = int.Parse(labTongTien.Text);
                if(ChietKhau==0) //khong su dung tich diem
                    kh.TichDiem += (int.Parse(labTongTien.Text) / 1000);
                else
                    kh.TichDiem= (int.Parse(labTongTien.Text) / 1000);
                hd.TichDiemHt = kh.TichDiem;
                hd.TongTien = TongTien; //Da co chiet khau
                db.HoaDons.Add(hd);
                for (int i = 0; i < dataSP.Rows.Count; i++)
                {
                    ThongTinHd tthd = new ThongTinHd();
                    tthd.MaHd = hd.MaHd;
                    tthd.MaSp = dataSP.Rows[i].Cells[0].Value.ToString();
                    tthd.SoLuongMua = int.Parse(dataSP.Rows[i].Cells[2].Value.ToString());
                    var sp = db.SanPhams.Find(tthd.MaSp);
                    tthd.DonGiaHt = int.Parse(dataSP.Rows[i].Cells[3].Value.ToString());
                    db.ThongTinHds.Add(tthd);
                }
                db.SaveChanges();
                Close();
                XemTTHDForm xem = new XemTTHDForm(db);
                xem.Tag = hd.MaHd;
                xem.StartPosition = FormStartPosition.CenterScreen;
                xem.TopMost = true;
                xem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
