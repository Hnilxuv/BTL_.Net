using BTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms.Main.DatHang
{
    public partial class XemPhieuDatHang : Form
    {
        QLBanMyPhamContext db = new QLBanMyPhamContext();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public XemPhieuDatHang()
        {
            InitializeComponent();
        }
        public XemPhieuDatHang(QLBanMyPhamContext currentDb)
        {
            InitializeComponent();
            db = currentDb;
        }

        public void exportExcelFile()
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excelApp.Application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excelApp.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Phiếu đặt hàng";
            worksheet.get_Range("A1", "A1").Cells.Font.Size = 14;
            worksheet.Cells[rowIndex, 1] = labelTenCH.Text;
            rowIndex++;
            worksheet.get_Range("A2", "A2").Cells.Font.Size = 14;
            excelApp.Cells[rowIndex, 1] = labelDiaChiCH.Text;
            rowIndex++;

            worksheet.get_Range("A3", "A3").Cells.Font.Size = 14;
            excelApp.Cells[rowIndex, 1] = labelSoDienThoaiCH.Text;
            rowIndex++;

            Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("D4", "D4");
            head.Value2 = "PHIẾU ĐẶT HÀNG";
            head.Font.Size = 18;
            head.Font.Bold = true;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowIndex++;

            Microsoft.Office.Interop.Excel.Range lableMaDH = worksheet.get_Range("D5", "D5");
            lableMaDH.MergeCells = true;
            lableMaDH.Value2 = labelMaPhieuDH.Text;
            lableMaDH.Font.Bold = true;
            lableMaDH.Font.Size = 14;
            lableMaDH.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowIndex++;

            excelApp.Cells[rowIndex, 2] = "Tên nhà cung cấp: ";
            excelApp.Cells[rowIndex, 3] = labelTenNCC.Text;
            excelApp.Cells[rowIndex, 5] = "Người lập phiếu: ";
            excelApp.Cells[rowIndex, 6] = labelTenNV.Text;
            rowIndex++;

            excelApp.Cells[rowIndex, 2] = "Địa chỉ: ";
            excelApp.Cells[rowIndex, 3] = labelDiaChiCH.Text;
            excelApp.Cells[rowIndex, 5] = "Ngày lập phiếu: ";
            excelApp.Cells[rowIndex, 6] = labelNgayTao.Text;
            rowIndex++;

            excelApp.Cells[rowIndex, 2] = "Số điện thoại: ";
            excelApp.Cells[rowIndex, 3] = labelSDTNCC.Text;
            rowIndex++;

            rowIndex++;

            Microsoft.Office.Interop.Excel.Range tieude = worksheet.Cells[rowIndex, 2];
            tieude.MergeCells = true;
            tieude.Font.Bold = true;
            tieude.Value2 = "Danh sách sản phẩm:";
            rowIndex++;

            Microsoft.Office.Interop.Excel.Range oRange = null;
            for (int i = 0; i < dgvSPDat.Columns.Count; i++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, i + 2];
                oRange.Value2 = dgvSPDat.Columns[i].HeaderText;
                oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                oRange.Interior.ColorIndex = 6;
            }
            rowIndex++;

            for (int i = 0; i < dgvSPDat.Rows.Count; i++)
            {

                for (int j = 0; j < dgvSPDat.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, j + 2];
                    oRange.NumberFormat = "@";
                    oRange.Value2 = dgvSPDat[j, i].Value.ToString();
                    oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                }
                rowIndex++;
            }
            Microsoft.Office.Interop.Excel.Range tdtTien = worksheet.Cells[rowIndex + 1, 5];
            tdtTien.MergeCells = true;
            tdtTien.Font.Bold = true;
            tdtTien.Value2 = "Tổng tiền:";
            tdtTien.Font.Bold = true;

            Microsoft.Office.Interop.Excel.Range tongT = worksheet.Cells[rowIndex + 1, 6];
            tongT.MergeCells = true;
            tongT.Value2 = labelTongTien.Text;
            tongT.Font.Bold = true;
            tongT.Font.Bold = true;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

        }

        private void xuatPDHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportExcelFile();
        }

        private void XemPhieuDatHang_Load(object sender, EventArgs e)
        {
            try
            {
                string maPDH = (string)this.Tag;
                PhieuDatHang pdh = db.PhieuDatHangs.Find(maPDH);
                var ch = db.CuaHangs.Find(pdh.MaCuaHang);
                var nv = db.NhanViens.Find(pdh.MaNv);
                var ncc = db.NhaCcs.Find(pdh.MaNcc);

                labelMaPhieuDH.Text = maPDH;
                labelTenCH.Text = ch.TenCuaHang;
                labelDiaChiCH.Text = ch.DiaChi;
                labelSoDienThoaiCH.Text = ch.DienThoai;
                labelTenNCC.Text = ncc.TenNcc;
                labelDiaChiNCC.Text = ncc.DiaChi;
                labelSDTNCC.Text = ncc.DienThoai;
                labelTenNV.Text = nv.TenNv;
                labelNgayTao.Text = pdh.NgayDat.ToString("dd-MM-yyyy HH:mm:ss");

                var dpdh = db.DongPhieuDats.Where(s => s.MaPhieuDat == maPDH).ToList();
                foreach (var item in dpdh)
                {
                    SanPham sp = db.SanPhams.Find(item.MaSp);
                    dgvSPDat.Rows.Add(item.MaSp, sp.TenSp, item.SoLuongDat, ((decimal)item.GiaDat).ToString("#,###", cul.NumberFormat), ((decimal)(item.SoLuongDat * item.GiaDat)).ToString("#,###", cul.NumberFormat));
                }
                decimal tongTien = 0;
                for (int i = 0; i < dgvSPDat.Rows.Count; i++)
                {
                    tongTien += decimal.Parse(dgvSPDat.Rows[i].Cells[4].Value.ToString(), cul);
                }
                labelTongTien.Text = tongTien.ToString("#,###", cul.NumberFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
