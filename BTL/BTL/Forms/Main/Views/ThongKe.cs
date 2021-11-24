using BTL.Models;
using BTL.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms.Main.Views
{
    public partial class ThongKe : Form
    {
        QLBanMyPhamContext db = new QLBanMyPhamContext();
        TaiKhoan user;
        Form parent;
        DateTime start, end;
        
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

        

        public ThongKe(Form p, TaiKhoan x)
        {
            user = x;
            parent = p;
            InitializeComponent();
            
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            start = DateTime.Today;
            end = DateTime.Today.AddHours(24);
            hienThiData();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            DateTime timebd = ngaybd.Value;
            DateTime timekt = ngaykt.Value;
            start = timebd;
            end = timekt.AddHours(24);
            if (ngaybd.Value.Date.CompareTo(ngaykt.Value.Date) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hienThiData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            start = DateTime.Today;
            end = DateTime.Today.AddHours(24);
            hienThiData();
            ngaybd.Value = ngaykt.Value = DateTime.Today;
        }

        private void btnxuatf_Click(object sender, EventArgs e)
        {
            exportExcelFile();
        }

        private void hienThiData()
        {
            
            dataspban.Rows.Clear();

            int shd = 0;
            var hd = db.HoaDons.Select(s => s);// lấy ra tất cả hóa đơn
            var li = new List<string>();
            foreach (var s in hd) // duyệt danh sách các hóa đơn
            {
                DateTime ngaylap = s.NgayLap;
                if (DateTime.Compare(ngaylap, start) >= 0 &&
                    DateTime.Compare(ngaylap, end) <= 0)
                {//kiểm tra hóa đơn có ngày lập là date
                    var lskh = db.KhachHangs.Select(kh => kh);
                    foreach (var kh in lskh)
                    {
                        if (s.MaKh.Equals(kh.MaKh))
                            li.Add(s.MaKh);
                    }
                }
            }
            for (int i = 0; i < li.Distinct().Count(); i++)
            {
                shd++;
            }

            foreach (var s in hd) // duyệt danh sách các hóa đơn
            {
                DateTime ngaylap = s.NgayLap;
                if (DateTime.Compare(ngaylap, start) >= 0 &&
                    DateTime.Compare(ngaylap, end) <= 0)
                {//kiểm tra hóa đơn có ngày lập là date



                    var ds = (from cthd in db.ThongTinHds
                              join sp in db.SanPhams on cthd.MaSp equals sp.MaSp
                              join h in db.HoaDons on cthd.MaHd equals h.MaHd
                              where h.MaHd.Equals(s.MaHd)
                              select new
                              {
                                  masp = cthd.MaSp,
                                  tensp = cthd.MaSpNavigation.TenSp,
                                  gia = cthd.DonGiaHt,
                                  slban = cthd.SoLuongMua
                              }).ToList();

                    foreach (var item in ds)
                    {
                        bool isOK = false;
                        if (dataspban.Rows.Count > 0)
                        {

                            for (int i = 0; i < dataspban.Rows.Count; i++)
                            {
                                if (dataspban.Rows[i].Cells[0].Value.ToString().Equals(item.masp))
                                {
                                    if (dataspban.Rows[i].Cells[2].Value.ToString().Equals(item.gia.ToString()))
                                    {
                                        dataspban.Rows[i].Cells[3].Value = Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString()) + Int32.Parse(item.slban.ToString());
                                        isOK = true;
                                    }
                                }
                            }
                        }
                        if (!isOK)
                            dataspban.Rows.Add(item.masp, item.tensp, item.gia, item.slban);

                        int slmax = Int32.Parse(dataspban.Rows[0].Cells[3].Value.ToString());
                        int slmin = Int32.Parse(dataspban.Rows[0].Cells[3].Value.ToString());
                        string tenspmax = dataspban.Rows[0].Cells[1].Value.ToString();
                        string tenspmin = dataspban.Rows[0].Cells[1].Value.ToString();
                        for (int i = 0; i < dataspban.Rows.Count; i++)
                        {

                            if (Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString()) > slmax)
                            {
                                slmax = Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString());
                                tenspmax = dataspban.Rows[i].Cells[1].Value.ToString();
                            }
                            if (Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString()) < slmin)
                            {
                                slmin = Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString());
                                tenspmin = dataspban.Rows[i].Cells[1].Value.ToString(); ;
                            }
                        }
                        int tongban = 0;
                        double tongdt = 0;
                        for (int i = 0; i < dataspban.Rows.Count; i++)
                        {
                            tongban += Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString());
                            tongdt += double.Parse(dataspban.Rows[i].Cells[2].Value.ToString()) * Int32.Parse(dataspban.Rows[i].Cells[3].Value.ToString());

                        }

                        lbdoanhthu.Text = tongdt.ToString("#,###.###", cul.NumberFormat) + " VNĐ";
                        lbtonghangban.Text = tongban.ToString();
                        lbspbc.Text = tenspmax + " - số lượng:" + slmax.ToString();
                        lbspin.Text = tenspmin + " - số lượng:" + slmin.ToString();
                    }
                }
            }
            lbkhachhang.Text = shd.ToString();
            var ls = db.PhieuDoiTras.Select(dt => dt);
            int sdt = 0;
            foreach (var dt in ls)
            {
                DateTime ngaylapdt = (DateTime)dt.NgayLap;
                if (DateTime.Compare(ngaylapdt, start) >= 0 &&
                    DateTime.Compare(ngaylapdt, end) <= 0) { sdt++; }
            }
            lbdoitra.Text = sdt.ToString();

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


            worksheet.Name = "Báo Cáo Thống Kê";
            worksheet.get_Range("A1", "A1").Cells.Font.Size = 16;
            worksheet.Cells[rowIndex, 1] = "CoCoShop";
            rowIndex++;
            worksheet.get_Range("A2", "A2").Cells.Font.Size = 16;
            excelApp.Cells[rowIndex, 1] = "Beauty & Comestic";

            rowIndex++;
            Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("B3", "F4");
            head.MergeCells = true;
            head.Value2 = "Báo Cáo Thống Kê";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            rowIndex++;
            rowIndex++;
            rowIndex++;
            if (DateTime.Compare(ngaybd.Value.Date, ngaykt.Value.Date) == 0)
            {
                worksheet.Cells[rowIndex, 3] = "Thời gian bán: ";
                worksheet.Cells[rowIndex, 4] = ngaybd.Value.ToShortDateString();
                rowIndex++;

            }
            else
            {
                worksheet.Cells[rowIndex, 3] = "Thời gian bắt đầu: ";
                worksheet.Cells[rowIndex, 4] = ngaybd.Value.ToShortDateString();
                rowIndex++;
                worksheet.Cells[rowIndex, 3] = "Thời gian kết thúc: ";
                worksheet.Cells[rowIndex, 4] = ngaykt.Value.ToShortDateString();
                rowIndex++;
            }

            rowIndex++;
            Microsoft.Office.Interop.Excel.Range tieude = worksheet.Cells[rowIndex, 3];
            tieude.MergeCells = true;
            tieude.Value2 = "Danh sách sản phẩm đã bán:";
            tieude.Font.Name = "Tahoma";
            tieude.Font.Size = "11";
            rowIndex++;

            /*   //header table
               worksheet.Cells[rowIndex, 2] = "STT";
               for (int i = 1; i < dataspban.Columns.Count + 1; i++)
               {
                   worksheet.Cells[rowIndex, i + 2] = dataspban.Columns[i - 1].HeaderText;
               }
               rowIndex++;
               //data table
               int count = 1;
               for (int i = 0; i < dataspban.Rows.Count; i++)
               {
                   worksheet.Cells[i + rowIndex, 2] = count;
                   for (int j = 0; j < dataspban.Columns.Count; j++)
                   {
                       worksheet.Cells[i + rowIndex, j + 3] = dataspban.Rows[i].Cells[j].Value + "";
                   }
                   count++;
               }*/
            Microsoft.Office.Interop.Excel.Range oRange = null;
            oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, 2];
            oRange.Value2 = "STT";
            oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oRange.Interior.ColorIndex = 38;
            for (int i = 0; i < dataspban.Columns.Count; i++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowIndex, i + 3];

                oRange.Value2 = dataspban.Columns[i].HeaderText;
                oRange.Font.Name = "Tahoma";
                oRange.Font.Size = "11";
                oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                oRange.Interior.ColorIndex = 38;
            }
            rowIndex++;
            int count = 1;
            for (int i = 0; i < dataspban.Rows.Count; i++)
            {
                oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + rowIndex, 2];
                oRange.Value2 = count;
                oRange.Font.Name = "Tahoma";
                oRange.Font.Size = "11";
                oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                for (int j = 0; j < dataspban.Columns.Count; j++)
                {
                    oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + rowIndex, j + 3];
                    oRange.Value2 = dataspban.Rows[i].Cells[j].Value + "";
                    oRange.Font.Name = "Tahoma";
                    oRange.Font.Size = "11";
                    oRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                }
                count++;
            }
            rowIndex += count + 2;
            //doanh thu
            worksheet.Cells[rowIndex, 3] = "Doanh thu: ";
            worksheet.Cells[rowIndex, 4] = lbdoanhthu.Text;
            //số phiếu trả
            worksheet.Cells[rowIndex, 5] = "Số phiếu đổi trả: ";
            worksheet.Cells[rowIndex, 6] = lbdoitra.Text;


            rowIndex += 2;


            worksheet.Cells[rowIndex, 3] = "Sản phẩm bán chạy: ";
            worksheet.Cells[rowIndex, 4] = lbspbc.Text;
            //số khách hàng
            worksheet.Cells[rowIndex, 5] = "Số khách hàng: ";
            worksheet.Cells[rowIndex, 6] = lbkhachhang.Text;
            rowIndex += 2;
            //số sản phẩm bán chạy
            worksheet.Cells[rowIndex, 3] = "Sản phẩm bán chạy: ";
            worksheet.Cells[rowIndex, 4] = lbspin.Text;
            //tổng sản phẩm đã bán
            worksheet.Cells[rowIndex, 5] = "Tổng sản phẩm đã bán: ";
            worksheet.Cells[rowIndex, 6] = lbtonghangban.Text;
            rowIndex += 2;
            worksheet.Cells[rowIndex, 5] = "Người Lập: ";
            worksheet.Cells[rowIndex, 6] = "Trần Chiến Công";
            rowIndex++;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

        }

    }
}
