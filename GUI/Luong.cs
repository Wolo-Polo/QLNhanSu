//using DAL;
using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace QLNhanSu
{
    public partial class Luong : Form
    {
        private Luong_BUL lb = new Luong_BUL();
        public Luong()
        {
            InitializeComponent();
            hienthi();
        }

        void hienthi()
        {
            dtgrvtongluong.DataSource = lb.getLuong();
        }

        void isDigit(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e) {
            isDigit(sender, e);
        }

        private void txtthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(sender, e);
        }

        private void txtsocong_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(sender, e);
        }
        private void txttongluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigit(sender, e);
        }
        private void btnhienthi_Click_1(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string manv = txtmanv.Text;
                string tennv = txttennv.Text;
                string nam = txtnam.Text;
                string thang = txtthang.Text;
                string socong = txtsocong.Text;
                string tongluong = txttongluong.Text;
                dtgrvtongluong.DataSource = lb.findLuong(manv, tennv, nam, thang, socong, tongluong);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai định dạng Năm, Tháng, Số công hoặc Tổng lương", "Thông báo");
            }
        }

        private void btnxuatfile_Click_1(object sender, EventArgs e)
        {
            if (dtgrvtongluong.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Tongluong.pdf"
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
                            PdfPTable pdfTable = new PdfPTable(dtgrvtongluong.Columns.Count);
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

                            Chunk c1 = new Chunk("BÁO CÁO THỐNG KÊ CHỨC VỤ \n", fonttitle);
                            Chunk c2 = new Chunk(DateTime.Now.ToShortDateString() + "\n\n", font);
                            header.Add(c1);
                            header.Add(c2);

                            foreach (DataGridViewColumn column in dtgrvtongluong.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrvtongluong.Rows)
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

        private void btndong_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtnam.Text = "";
            txtthang.Text = "";
            txtsocong.Text = "";
            txttongluong.Text = "";
        }

        int row;
        private void dtgrvtongluong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmanv.Text = dtgrvtongluong.Rows[row].Cells[0].Value.ToString();
                txttennv.Text = dtgrvtongluong.Rows[row].Cells[1].Value.ToString();
                txtnam.Text = dtgrvtongluong.Rows[row].Cells[2].Value.ToString();
                txtthang.Text = dtgrvtongluong.Rows[row].Cells[3].Value.ToString();
                txtsocong.Text = dtgrvtongluong.Rows[row].Cells[4].Value.ToString();
                txttongluong.Text = dtgrvtongluong.Rows[row].Cells[5].Value.ToString();
            }
        }
    }
}