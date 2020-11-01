using BUL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.UserControls
{
    public partial class ThongKeTheoPhongBan : Form
    {
        private NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        private PhongBan_BUL phongBan_BUL = new PhongBan_BUL();
        public ThongKeTheoPhongBan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongKeTheoPhongBan_Load(object sender, EventArgs e)
        {
            DataTable dt = phongBan_BUL.getAllPhongBan();
            cbbMaPB.DataSource = dt;
            cbbMaPB.ValueMember = "MaPB";
            cbbMaPB.DisplayMember = "TenPB";
            HienThi();
        }
        private void HienThi()
        {
            DataTable dt = nhanVien_BUL.getNhanVienbyPhongBan(cbbMaPB.SelectedValue.ToString());
            dtgNhanVien.DataSource = dt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = nhanVien_BUL.getNhanVienbyPhongBan(cbbMaPB.SelectedValue.ToString());
            dtgNhanVien.DataSource = dt;
            HienThi();
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "nhanvien-phongban.pdf"
                };
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException)
                        {
                            fileError = true;
                            MessageBox.Show("Đang có chương trình mở file này!!!");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgNhanVien.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\TIMES.TTF", BaseFont.IDENTITY_H, true);
                            iTextSharp.text.Font fonttitle = new iTextSharp.text.Font(bf, 15);
                            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10);
                            iTextSharp.text.Font fonttext = new iTextSharp.text.Font(bf, 12);

                            Paragraph header = new Paragraph
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            Paragraph text = new Paragraph();

                            Chunk c1 = new Chunk("BÁO CÁO THỐNG KÊ NHÂN VIÊN THEO PHÒNG BAN \n", fonttitle);
                            Chunk c2 = new Chunk(DateTime.Now.ToShortDateString() + "\n\n", font);
                            header.Add(c1);
                            header.Add(c2);

                            foreach (DataGridViewColumn column in dtgNhanVien.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgNhanVien.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {

                                    PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value?.ToString(), fonttext));
                                    pdfTable.AddCell(cell1);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(header);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Xuất dữ liệu thành công!!!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Có lỗi xảy ra!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được xuất!!!");
                }
            }
        }
    }
}
