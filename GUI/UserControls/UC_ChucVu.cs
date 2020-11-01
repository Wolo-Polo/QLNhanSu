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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.SqlClient;

namespace QLNhanSu.UserControls
{
    public partial class UC_ChucVu : UserControl
    {
        private ChucVu_BUL chucVu_BUL = new ChucVu_BUL();
        public UC_ChucVu()
        {
            InitializeComponent();
        }
        #region load 
        void hienthi()
        {
            dtgrvchucvu.DataSource = chucVu_BUL.getAllChucVu();
        }

        private void UC_ChucVu_Load_1(object sender, EventArgs e)
        {
            hienthi();
        }

        int row;
        private void dtgrvchucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmacv.Text = dtgrvchucvu.Rows[row].Cells[0].Value.ToString().Trim();
                txttencv.Text = dtgrvchucvu.Rows[row].Cells[1].Value.ToString();
                txthesopc.Text = dtgrvchucvu.Rows[row].Cells[2].Value.ToString();
            }
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmacv.Text.Equals(""))
            {
                MessageBox.Show("Mã chức vụ trống dữ liệu");
            }
            else if (txtmacv.Text.Length>5)
            {
                MessageBox.Show("Mã chức vụ không dài quá 5 ký tự");
            }
            else if (txttencv.Text.Equals(""))
            {
                MessageBox.Show("Tên chức vụ trống dữ liệu");
            }
            else if (txttencv.Text.Length > 20)
            {
                MessageBox.Show("Tên chức vụ không dài quá 20 ký tự");
            }
            else if (txthesopc.Text.Equals(""))
            {
                MessageBox.Show("Hệ số phụ cấp trống dữ liệu");
            }
            else {
                try
                {
                    ChucVu_DTO chucVu = new ChucVu_DTO();
                    chucVu.Macv = txtmacv.Text;
                    chucVu.Tencv = txttencv.Text;
                    chucVu.Hesopc = float.Parse(txthesopc.Text);
                    if (chucVu_BUL.insertChucVu(chucVu))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hệ số phụ cấp sai định dạng");
                }
            }
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmacv.Text.Equals(""))
            {
                MessageBox.Show("Mã chức vụ trống dữ liệu");
            }
            else if (txtmacv.Text.Length > 5)
            {
                MessageBox.Show("Mã chức vụ không dài quá 5 ký tự");
            }
            else if (txttencv.Text.Equals(""))
            {
                MessageBox.Show("Tên chức vụ trống dữ liệu");
            }
            else if (txttencv.Text.Length > 20)
            {
                MessageBox.Show("Tên chức vụ không dài quá 20 ký tự");
            }
            else if (txthesopc.Text.Equals(""))
            {
                MessageBox.Show("Hệ số phụ cấp trống dữ liệu");
            }
            else
            {
                try
                {
                    ChucVu_DTO chucVu = new ChucVu_DTO();
                    chucVu.Macv = txtmacv.Text;
                    chucVu.Tencv = txttencv.Text;
                    chucVu.Hesopc = float.Parse(txthesopc.Text);
                    if (chucVu_BUL.updateChucVu(chucVu))
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hệ số phụ cấp sai định dạng");
                }
            }
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChucVu_DTO chucVu = new ChucVu_DTO();
            if (txtmacv.Text.Equals(""))
            {
                MessageBox.Show("Mã chức vụ trống dữ liệu");
            }
            else if (txtmacv.Text.Length > 5)
            {
                MessageBox.Show("Mã chức vụ không tồn tại");
            }
            else
            {
                chucVu.Macv = txtmacv.Text;
                if (chucVu_BUL.deleteChucVu(chucVu))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            hienthi();
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            if (dtgrvchucvu.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "ChucVu.pdf"
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
                            PdfPTable pdfTable = new PdfPTable(dtgrvchucvu.Columns.Count);
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

                            foreach (DataGridViewColumn column in dtgrvchucvu.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgrvchucvu.Rows)
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
                        catch (Exception )
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

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string macv = txtmacv.Text;
            string tencv = txttencv.Text;
            string hesopc = txthesopc.Text;
            dtgrvchucvu.DataSource = chucVu_BUL.findChucVu(macv,tencv,hesopc);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmacv.Text = "";
            txttencv.Text = "";
            txthesopc.Text = "";
        }
        private void txthesopc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
