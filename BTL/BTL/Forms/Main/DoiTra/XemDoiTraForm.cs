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

namespace BTL.Forms.Main.DoiTra
{
    public partial class XemDoiTraForm : Form
    {

        QLBanMyPhamContext db = new QLBanMyPhamContext();
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public XemDoiTraForm()
        {
            InitializeComponent();
        }

        public XemDoiTraForm(QLBanMyPhamContext currentDb)
        {
            InitializeComponent();
            db = currentDb;
        }

        private void tinhTienKhachTra()
        {
            decimal tongTienDoi = 0m;
            for (int i = 0; i < dataViewSPTra.Rows.Count; i++)
            {
                tongTienDoi += decimal.Parse(dataViewSPTra.Rows[i].Cells[4].Value.ToString(), cul);
            }

            decimal tongTienCanDoi = 0m;
            for (int i = 0; i < dataViewSPDoi.Rows.Count; i++)
            {
                tongTienCanDoi += decimal.Parse(dataViewSPDoi.Rows[i].Cells[4].Value.ToString(), cul);
            }

            if (tongTienDoi >= tongTienCanDoi)
            {
                labelTienKhachTra.Text = "0 VND";
            }
            else
            {
                labelTienKhachTra.Text = (tongTienCanDoi - tongTienDoi).ToString("#,###", cul.NumberFormat) + " VND";
            }
        }

        private void XemDoiTraForm_Load(object sender, EventArgs e)
        {
            try
            {
                string maPDT = (string)this.Tag;
                PhieuDoiTra pdt = db.PhieuDoiTras.Find(maPDT);
                string maKH = db.HoaDons.Find(pdt.MaHd).MaKh;
                var kh = db.KhachHangs.Find(maKH);
                var nv = db.NhanViens.Find(pdt.MaNv);
                var ch = db.CuaHangs.Find(nv.MaCuaHang);

                labelTenCH.Text = ch.TenCuaHang;
                labelDiaChiCH.Text = ch.DiaChi;
                labelSdtCH.Text = ch.DienThoai;
                labelMaPhieu.Text = maPDT;
                labelKH.Text = kh.TenKh;
                labelSDT.Text = kh.Sdt;
                labelNV.Text = nv.TenNv;
                labelNgayTao.Text = pdt.NgayLap.Value.ToString("dd-MM-yyyy HH:mm:ss");

                var ttpdt = db.ThongTinSpdts.Where(s => s.MaPhieuDt == maPDT).ToList();
                foreach (var item in ttpdt)
                {
                    SanPham sp = db.SanPhams.Find(item.MaSp);
                    if(item.PhanLoai==false)
                    {
                        dataViewSPTra.Rows.Add(item.MaSp, sp.TenSp, item.SoLuongDt, ((decimal)item.DonGiaHt).ToString("#,###", cul.NumberFormat), ((decimal)(item.SoLuongDt * item.DonGiaHt)).ToString("#,###", cul.NumberFormat));
                    } else
                    {
                        dataViewSPDoi.Rows.Add(item.MaSp, sp.TenSp, item.SoLuongDt, ((decimal)item.DonGiaHt).ToString("#,###", cul.NumberFormat), ((decimal)(item.SoLuongDt * item.DonGiaHt)).ToString("#,###", cul.NumberFormat));
                    }  
                }
                txtLyDo.Text = pdt.LyDoDt;
                tinhTienKhachTra();
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

        private void Print(Panel pnl)
        {
            this.Close();
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog.Document = printDocumentHD;
            printDocumentHD.PrintPage += new PrintPageEventHandler(printDocumentHD_PrintPage);
            printPreviewDialog.TopMost = true;
            printPreviewDialog.WindowState = FormWindowState.Maximized;
            printPreviewDialog.ShowDialog();

        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void printDocumentHD_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimg, 0, 0, 850, 1123);
        }

        private void xuat2PDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print(panelPrint);
        }

        private void xuatPDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            thoatToolStripMenuItem_Click(sender, e);
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excelApp.Application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            excelApp.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = labelTenCH.Text + " - " + labelSdtCH.Text;
            worksheet.Cells[2, 1] = labelDiaChiCH.Text;
            Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("B3", "F4");
            head.MergeCells = true;
            head.Value2 = label1.Text;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            Microsoft.Office.Interop.Excel.Range labelMPD = worksheet.get_Range("D5", "D5");
            labelMPD.MergeCells = true;
            labelMPD.Value2 = labelMaPhieu.Text;
            labelMPD.Font.Bold = true;
            labelMPD.Font.Name = "Tahoma";
            labelMPD.Font.Size = "11";
            labelMPD.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            Microsoft.Office.Interop.Excel.Range lbKhach = worksheet.get_Range("B7", "B7");
            lbKhach.MergeCells = true;
            lbKhach.Value2 = "Tên khách hàng";
            lbKhach.Font.Name = "Tahoma";
            lbKhach.Font.Size = "11";



            Microsoft.Office.Interop.Excel.Range lbKH = worksheet.get_Range("C7", "C7");
            lbKH.MergeCells = true;
            lbKH.Value2 = labelKH.Text;
            lbKH.Font.Name = "Tahoma";
            lbKH.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbThuN = worksheet.get_Range("E7", "E7");
            lbThuN.MergeCells = true;
            lbThuN.Value2 = "Thu ngân";
            lbThuN.Font.Name = "Tahoma";
            lbThuN.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbTN = worksheet.get_Range("F7", "F7");
            lbTN.MergeCells = true;
            lbTN.Value2 = labelNV.Text;
            lbTN.Font.Name = "Tahoma";
            lbTN.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbSdt = worksheet.get_Range("B9", "B9");
            lbSdt.MergeCells = true;
            lbSdt.Value2 = "Số điện thoại";
            lbSdt.Font.Name = "Tahoma";
            lbSdt.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbSodt = worksheet.get_Range("C9", "C9");
            lbSodt.MergeCells = true;
            lbSodt.Value2 = "(+84)" + labelSDT.Text;
            lbSodt.Font.Name = "Tahoma";
            lbSodt.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbNx = worksheet.get_Range("E9", "E9");
            lbNx.MergeCells = true;
            lbNx.Value2 = "Ngày xuất HD";
            lbNx.Font.Name = "Tahoma";
            lbNx.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbNgayx = worksheet.get_Range("F9", "F9");
            lbNgayx.MergeCells = true;
            lbNgayx.Value2 = labelNgayTao.Text;
            lbNgayx.Font.Name = "Tahoma";
            lbNgayx.Font.Size = "11";
            lbNgayx.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            // Danh sach san pham tra
            int rowIndex = 13;
            Microsoft.Office.Interop.Excel.Range tieude = worksheet.Cells[rowIndex, 2];
            tieude.MergeCells = true;
            tieude.Value2 = "Danh sách sản phẩm trả:";
            tieude.Font.Name = "Tahoma";
            tieude.Font.Size = "11";

            rowIndex++;
            Microsoft.Office.Interop.Excel.Range oRange = null;
            for (int i = 0; i < dataViewSPTra.Columns.Count; i++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, i + 2];

                oRange.Value2 = dataViewSPTra.Columns[i].HeaderText;
                oRange.Font.Name = "Tahoma";
                oRange.Font.Size = "11";
                oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                oRange.Interior.ColorIndex = 6;
            }

            rowIndex++;
            for (int i = 0; i < dataViewSPTra.Rows.Count; i++)
            {

                for (int j = 0; j < dataViewSPTra.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, j + 2];
                    oRange.NumberFormat = "@";
                    oRange.Value2 = dataViewSPTra[j, i].Value.ToString();
                    oRange.Font.Name = "Tahoma";
                    oRange.Font.Size = "11";
                    oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                }
                rowIndex++;
            }

            //San pham doi
            rowIndex++;
            Microsoft.Office.Interop.Excel.Range tieude2 = worksheet.Cells[rowIndex, 2];
            tieude2.MergeCells = true;
            tieude2.Value2 = "Danh sách sản phẩm đổi:";
            tieude2.Font.Name = "Tahoma";
            tieude2.Font.Size = "11";

            rowIndex++;
            Microsoft.Office.Interop.Excel.Range oRange2 = null;
            for (int i = 0; i < dataViewSPDoi.Columns.Count; i++)
            {
                oRange2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, i + 2];

                oRange2.Value2 = dataViewSPDoi.Columns[i].HeaderText;
                oRange2.Font.Name = "Tahoma";
                oRange2.Font.Size = "11";
                oRange2.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                oRange2.Interior.ColorIndex = 6;
            }

            rowIndex++;
            for (int i = 0; i < dataViewSPDoi.Rows.Count; i++)
            {

                for (int j = 0; j < dataViewSPDoi.Columns.Count; j++)
                {
                    oRange2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, j + 2];
                    oRange2.NumberFormat = "@";
                    oRange2.Value2 = dataViewSPDoi[j, i].Value.ToString();
                    oRange2.Font.Name = "Tahoma";
                    oRange2.Font.Size = "11";
                    oRange2.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                }
                rowIndex++;
            }
            ////////

            rowIndex++;
            Microsoft.Office.Interop.Excel.Range tdtTien = worksheet.Cells[rowIndex + 1, 5];
            tdtTien.MergeCells = true;
            tdtTien.Value2 = "Tổng tiền";
            tdtTien.Font.Name = "Tahoma";
            tdtTien.Font.Size = "11";
            tdtTien.Font.Bold = true;

            Microsoft.Office.Interop.Excel.Range tongT = worksheet.Cells[rowIndex + 1, 6];
            tongT.MergeCells = true;
            tongT.Value2 = labelTienKhachTra.Text;
            tongT.Font.Name = "Tahoma";
            tongT.Font.Size = "11";
            tongT.Font.Bold = true;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }

      
    }
}
