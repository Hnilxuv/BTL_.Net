using BTL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms.Main.HoaDons
{
    public partial class XemTTHDForm : Form
    {
        Models.QLBanMyPhamContext db;
        public XemTTHDForm()
        {
            InitializeComponent();
        }
        public XemTTHDForm(Models.QLBanMyPhamContext dt)
        {
            db = dt;
            InitializeComponent();
        }
        private void XemTTHDForm_Load(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                #region hien thi hoa don
                string maHD = (string)this.Tag;
                var hoadon = (from hd in db.HoaDons
                             where hd.MaHd == maHD
                             join kh in db.KhachHangs on hd.MaKh equals kh.MaKh
                             join nv in db.NhanViens on hd.MaNv equals nv.MaNv
                             join cuah in db.CuaHangs on nv.MaCuaHang equals cuah.MaCuaHang
                             select new
                             {
                                 mahd = hd.MaHd,
                                 tenkh=kh.TenKh,
                                 sdt=kh.Sdt,
                                 tichdiem=hd.TichDiemHt,
                                 tennv=nv.TenNv,
                                 ngaylap=hd.NgayLap,
                                 tongtien=(int)hd.TongTien,
                                 tench = cuah.TenCuaHang,
                                 diachich = cuah.DiaChi,
                                 sdtcuah = cuah.DienThoai
                             }).FirstOrDefault();
                labTench.Text = hoadon.tench;
                labSdtCh.Text = hoadon.sdtcuah;
                labDiachich.Text = hoadon.diachich;
                labMaHD.Text = "[" + hoadon.mahd + "]";
                labKH.Text = hoadon.tenkh;
                labSDT.Text = hoadon.sdt;
                labTD.Text = hoadon.tichdiem.ToString();
                labNV.Text = hoadon.tennv;
                labNgayThang.Text = hoadon.ngaylap.ToString("dd-MM-yyyy HH:mm:ss");
                #endregion
                var Tthds = from s in db.ThongTinHds
                            where s.MaHd == maHD
                            select new
                            {
                                masp = s.MaSp,
                                tensp = s.MaSpNavigation.TenSp,
                                solm = s.SoLuongMua,
                                dongia=(int)s.DonGiaHt,
                            };
                int Tong = 0;//Tong tien da co chiet khau
                foreach (var item in Tthds)
                {
                    dataViewSP.Rows.Add(item.masp, item.tensp, item.solm, item.dongia.ToString("#,###",cul.NumberFormat),(item.solm*item.dongia).ToString("#,###", cul.NumberFormat));
                    Tong +=item.solm * item.dongia;
                }
                string total = (Tong-hoadon.tongtien).ToString("#,###", cul.NumberFormat);
                string total1 = hoadon.tongtien.ToString("#,###", cul.NumberFormat);
                labChietKhau.Text = total + " VNĐ";
                labTongTien.Text = total1 + " VNĐ";
                if(Tong - hoadon.tongtien==0)
                    labChietKhau.Text = "0 VNĐ";
                if(hoadon.tongtien==0)
                    labTongTien.Text = "0 VNĐ";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Print(Panel pnl)
        {
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
            memoryimg = new Bitmap(pnl.Width,pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void printDocumentHD_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryimg, 0, 0,850,1123);
        }

        private void xuatHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoatToolStripMenuItem_Click(sender, e);
            Print(panelPrint);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xuatExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoatToolStripMenuItem_Click(sender, e);
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excelApp.Application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            excelApp.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1] = labTench.Text+"-"+labSdtCh.Text;
            worksheet.Cells[2, 1] = labDiachich.Text;
            Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("B3", "F4");
            head.MergeCells = true;
            head.Value2 = label1.Text;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            Microsoft.Office.Interop.Excel.Range lableMaHD = worksheet.get_Range("B5", "F5");
            lableMaHD.MergeCells = true;
            lableMaHD.Value2 = labMaHD.Text;
            lableMaHD.Font.Bold = true;
            lableMaHD.Font.Name = "Tahoma";
            lableMaHD.Font.Size = "11";
            lableMaHD.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            Microsoft.Office.Interop.Excel.Range lbKhach = worksheet.get_Range("B7", "B7");
            lbKhach.MergeCells = true;
            lbKhach.Value2 = "Khách hàng";
            lbKhach.Font.Name = "Tahoma";
            lbKhach.Font.Size = "11";



            Microsoft.Office.Interop.Excel.Range lbKH = worksheet.get_Range("C7", "C7");
            lbKH.MergeCells = true;
            lbKH.Value2 = labKH.Text;
            lbKH.Font.Name = "Tahoma";
            lbKH.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbThuN = worksheet.get_Range("E7", "E7");
            lbThuN.MergeCells = true;
            lbThuN.Value2 = "Thu ngân";
            lbThuN.Font.Name = "Tahoma";
            lbThuN.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbTN = worksheet.get_Range("F7", "F7");
            lbTN.MergeCells = true;
            lbTN.Value2 = labNV.Text;
            lbTN.Font.Name = "Tahoma";
            lbTN.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbSdt = worksheet.get_Range("B9", "B9");
            lbSdt.MergeCells = true;
            lbSdt.Value2 = "Số điện thoại";
            lbSdt.Font.Name = "Tahoma";
            lbSdt.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbSodt = worksheet.get_Range("C9", "C9");
            lbSodt.MergeCells = true;
            lbSodt.NumberFormat = "@";
            lbSodt.Value2 = labSDT.Text;
            lbSodt.Font.Name = "Tahoma";
            lbSodt.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbNx = worksheet.get_Range("E9", "E9");
            lbNx.MergeCells = true;
            lbNx.Value2 = "Ngày xuất HD";
            lbNx.Font.Name = "Tahoma";
            lbNx.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbNgayx = worksheet.get_Range("F9", "F9");
            lbNgayx.MergeCells = true;
            lbNgayx.Value2 = labNgayThang.Text;
            lbNgayx.Font.Name = "Tahoma";
            lbNgayx.Font.Size = "11";
            lbNgayx.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;


            Microsoft.Office.Interop.Excel.Range lbdtl = worksheet.get_Range("B11", "B11");
            lbdtl.MergeCells = true;
            lbdtl.Value2 = "Tích điểm";
            lbdtl.Font.Name = "Tahoma";
            lbdtl.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range lbTichd = worksheet.get_Range("C11", "C11");
            lbTichd.MergeCells = true;
            lbTichd.Value2 = labTD.Text;
            lbTichd.Font.Name = "Tahoma";
            lbTichd.Font.Size = "11";
            lbTichd.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            int rowIndex = 13;
            Microsoft.Office.Interop.Excel.Range tieude = worksheet.Cells[rowIndex, 2];
            tieude.MergeCells = true;
            tieude.Value2 = "Danh sách sản phẩm:";
            tieude.Font.Name = "Tahoma";
            tieude.Font.Size = "11";
            rowIndex++;
            Microsoft.Office.Interop.Excel.Range oRange = null;
            for (int i = 0; i < dataViewSP.Columns.Count; i++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, i + 2];

                oRange.Value2 = dataViewSP.Columns[i].HeaderText;
                oRange.Font.Name = "Tahoma";
                oRange.Font.Size = "11";
                oRange.Borders.LineStyle= Microsoft.Office.Interop.Excel.Constants.xlSolid;
                oRange.Interior.ColorIndex = 6;
            }
            rowIndex++;

            for (int i = 0; i < dataViewSP.Rows.Count; i++)
            {

                for (int j = 0; j < dataViewSP.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, j + 2];
                    oRange.NumberFormat= "@";
                    oRange.Value2 = dataViewSP[j, i].Value.ToString();
                    oRange.Font.Name = "Tahoma";
                    oRange.Font.Size = "11";
                    oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                }
                rowIndex++;
            }

            Microsoft.Office.Interop.Excel.Range tdchietKhau = worksheet.Cells[rowIndex+1, 5];
            tdchietKhau.MergeCells = true;
            tdchietKhau.Value2 = "Chiết khấu";
            tdchietKhau.Font.Name = "Tahoma";
            tdchietKhau.Font.Size = "11";
            tdchietKhau.Font.Bold=true;

            Microsoft.Office.Interop.Excel.Range chieuKhau = worksheet.Cells[rowIndex+1, 6];
            chieuKhau.MergeCells = true;
            chieuKhau.Value2 = labChietKhau.Text;
            chieuKhau.Font.Name = "Tahoma";
            chieuKhau.Font.Size = "11";
            chieuKhau.Font.Bold = true;
            rowIndex++;
            Microsoft.Office.Interop.Excel.Range tdtTien = worksheet.Cells[rowIndex + 1, 5];
            tdtTien.MergeCells = true;
            tdtTien.Value2 = "Tổng tiền";
            tdtTien.Font.Name = "Tahoma";
            tdtTien.Font.Size = "11";
            tdtTien.Font.Bold = true;

            Microsoft.Office.Interop.Excel.Range tongT = worksheet.Cells[rowIndex + 1, 6];
            tongT.MergeCells = true;
            tongT.Value2 = labTongTien.Text;
            tongT.Font.Name = "Tahoma";
            tongT.Font.Size = "11";
            tongT.Font.Bold = true;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
    }
    }
}
