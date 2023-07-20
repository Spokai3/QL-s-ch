using MongoDB.Bson;
using MongoDB.Driver;
using QL_cửa_hàng_sách;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace QL_sách
{
    public partial class QLSach : Form
    {
        IMongoCollection<Book> bookCollection;
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
                                        var book = new Book
                                        {
                                            BookID = Int32.Parse(txtBookID.Text),
                                            ISBN = txtISBN.Text,
                                            Tên_Sách = txtTenSach.Text,
                                            Tác_Giả = txtTacGia.Text,
                                            Ngôn_Ngữ = cbNgonNgu.Text,
                                            Nhà_Xuất_Bản = txtNXB.Text,
                                            Ngày_Công_Bố = Date.Text
                                        };
                                        bookCollection.InsertOne(book);
                                        LoadBookData();
                                        /*dataGridViewThongTin.Rows.Add(txtBookID.Text, txtISBN.Text, txtTenSach.Text, txtTacGia.Text, cbNgonNgu.Text, txtNXB.Text, Date.Text);*/
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
            var filterDefinition = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
            var updateDefinition = Builders<Book>.Update
                .Set(a => a.ISBN, txtISBN.Text)
                .Set(a => a.Tên_Sách, txtTenSach.Text)
                .Set(a => a.Tác_Giả, txtTacGia.Text)
                .Set(a => a.Ngôn_Ngữ, cbNgonNgu.Text)
                .Set(a => a.Nhà_Xuất_Bản, txtNXB.Text)
                .Set(a => a.Ngày_Công_Bố, Date.Text);
            bookCollection.UpdateOne(filterDefinition, updateDefinition);
            LoadBookData();
        }

        private void dataGridViewTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

       /* private void dataGridViewThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
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
        }*/

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridViewThongTin.CurrentCell.RowIndex;
                dataGridViewThongTin.Rows.RemoveAt(index);
                
            }
        }

        public void LoadBookData()
        {
            var filterDefinition = Builders<Book>.Filter.Empty;
            var books = bookCollection.Find(filterDefinition).ToList();
            dataGridViewThongTin.DataSource = books;
            dataGridViewTimKiem.DataSource = books;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void QLSach_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            bookCollection = database.GetCollection<Book>("book");

            LoadBookData();
        }

        private void dataGridViewTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
