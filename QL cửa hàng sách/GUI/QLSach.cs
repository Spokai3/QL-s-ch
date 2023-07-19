using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_sách
{
    public partial class QLSach : Form
    {
        public QLSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DienThongTin();
        }

        public void DienThongTin()
        {
            if (txtBookID.Text != "")
            {
                if (txtISBN.Text != "")
                {
                    if (txtTenSach.Text != "")
                    {
                        if (txtTacGia.Text != "")
                        {
                            if (cbNgonNgu.Text != "")
                            {
                                if (txtNXB.Text != "")
                                {
                                    if (Date.Text != "")
                                    {
                                        dataGridViewThongTin.Rows.Add(txtBookID.Text, txtISBN.Text, txtTenSach.Text, txtTacGia.Text, cbNgonNgu.Text, txtNXB.Text, Date.Text);
                                        MessageBox.Show("Thêm thành công");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Chưa chọn ngày công bố");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Chưa nhập nhà xuất bản");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chưa chọn ngôn ngữ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập tên tác giả");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập tên sách");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mã ISBN");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã ID sách");
            }
        }

        public void SuaThongTin()
        {
            if (dataGridViewThongTin.SelectedCells.Count > 0)
            {
                int vitri = dataGridViewThongTin.CurrentCell.RowIndex;
                dataGridViewThongTin[0, vitri].Value = txtBookID.Text;
                dataGridViewThongTin[1, vitri].Value = txtISBN.Text;
                dataGridViewThongTin[2, vitri].Value = txtTenSach.Text;
                dataGridViewThongTin[3, vitri].Value = txtTacGia.Text;
                dataGridViewThongTin[4, vitri].Value = cbNgonNgu.Text;
                dataGridViewThongTin[5, vitri].Value = txtNXB.Text;
                dataGridViewThongTin[6, vitri].Value = Date.Text;
            }
            else
            {
                MessageBox.Show("Không có gì để sửa");
            }
        }

        private void dataGridViewTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

        private void dataGridViewThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewThongTin.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewThongTin.Rows[dataGridViewThongTin.CurrentCell.RowIndex];
                txtBookID.Text = row.Cells[0].Value.ToString();
                txtISBN.Text = row.Cells[1].Value.ToString();
                txtTenSach.Text = row.Cells[2].Value.ToString();
                txtTacGia.Text = row.Cells[3].Value.ToString();
                cbNgonNgu.Text = row.Cells[4].Value.ToString();
                txtNXB.Text = row.Cells[5].Value.ToString(); 
                Date.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewThongTin.CurrentCell.RowIndex;
                dataGridViewThongTin.Rows.RemoveAt(index);
            }
        }
    }
}
