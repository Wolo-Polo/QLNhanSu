using DTO;
//using DAL;
using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace QLNhanSu.UserControls
{
    public partial class UC_ChamCong : UserControl
    {
        private ChamCong_BUL chamCong_BUL = new ChamCong_BUL();
        private NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        public UC_ChamCong()
        {
            InitializeComponent();
        }
        void hienthi() {
            dtgrvchamcong.DataSource = chamCong_BUL.getAllChamcong();
        }

        private void UC_ChamCong_Load(object sender, EventArgs e)
        {
            hienthi();
            DataTable tb = nhanVien_BUL.getAllNhanVien();
            cbbmanv.DataSource = tb;
            cbbmanv.DisplayMember = "Mã nhân viên";
            
        }
        int row;
        private void dtgrvchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                cbbmanv.Text = dtgrvchamcong.Rows[row].Cells[0].Value.ToString();
                dtpngaycong.Text = dtgrvchamcong.Rows[row].Cells[2].Value.ToString();
                txtghichu.Text = dtgrvchamcong.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ChamCong_DTO chamCong = new ChamCong_DTO();
            chamCong.Manv = cbbmanv.Text;
            chamCong.Ngaycong = dtpngaycong.Text;
            chamCong.Ghichu = txtghichu.Text;
            if (chamCong_BUL.insertChamcong(chamCong))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChamCong_DTO chamCong = new ChamCong_DTO();
            chamCong.Manv = cbbmanv.Text;
            chamCong.Ngaycong = dtpngaycong.Text;
            chamCong.Ghichu = txtghichu.Text;
            if (chamCong_BUL.updateChamcong(chamCong))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChamCong_DTO chamCong = new ChamCong_DTO();
            chamCong.Manv = cbbmanv.Text;
            chamCong.Ngaycong = dtpngaycong.Text;
            if (chamCong_BUL.deleteChamcong(chamCong))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
            hienthi();
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            if (dtgrvchamcong.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "ChamCong.pdf"
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
                            PdfPTable pdfTable = new PdfPTable(dtgrvchamcong.Columns.Count);
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

                            foreach (DataGridViewColumn column in dtgrvchamcong.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrvchamcong.Rows)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ChamCong_DTO cc = new ChamCong_DTO();
            cc.Manv = cbbmanv.Text;
            cc.Ngaycong = dtpngaycong.Text;
            cc.Ghichu = txtghichu.Text;
            dtgrvchamcong.DataSource = chamCong_BUL.findChamCong(cc);
        }

        private void btnxuatluong_Click(object sender, EventArgs e)
        {
            Luong frmLuong = new Luong();
            frmLuong.ShowDialog();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtghichu.Text = "";
        }
    }
}
