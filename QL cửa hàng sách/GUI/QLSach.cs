using MongoDB.Bson;
using MongoDB.Driver;
using QL_cửa_hàng_sách;
using System;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;

namespace QL_sách
{
    public partial class QLSach : Form
    {
        IMongoCollection<Book> bookCollection;        
        public QLSach()
        {
            InitializeComponent();                       
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DienThongTin();
        }

        public void DienThongTin()
        {
            var filter = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
            var update = Builders<Book>.Update.SetOnInsert(a => a.BookID, Int32.Parse(txtBookID.Text));
            var option = new FindOneAndUpdateOptions<Book>
            {
                IsUpsert = true,
            };
            var result = bookCollection.FindOneAndUpdate(filter, update, option);
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
                                        if (result == null)
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
                                            MessageBox.Show("Thêm thành công");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Dữ liệu đã tồn tại không thể thêm");
                                        }                                        
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

        /** Sửa dữ liệu trong DataBase **/

        public void SuaThongTin()
        {
            var filter = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
            var option = new UpdateOptions
            {
                IsUpsert = true,
            };            
            var update = Builders<Book>.Update
                .Set(a => a.ISBN, txtISBN.Text)
                .Set(a => a.Tên_Sách, txtTenSach.Text)
                .Set(a => a.Tác_Giả, txtTacGia.Text)
                .Set(a => a.Ngôn_Ngữ, cbNgonNgu.Text)
                .Set(a => a.Nhà_Xuất_Bản, txtNXB.Text)
                .Set(a => a.Ngày_Công_Bố, Date.Text);
            var result = bookCollection.UpdateOne(filter, update, option);
            
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
                                        if (result.IsModifiedCountAvailable && result.ModifiedCount == 0)
                                        {
                                            LoadBookData();
                                            MessageBox.Show("Thêm thành công");
                                        }
                                        else
                                        {
                                            LoadBookData();
                                            MessageBox.Show("Sửa thành công");
                                        }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

        /** Click vào trong Cell để hiển thị thông tin lên các ô TextBox **/

        private void dataGridViewThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewThongTin.SelectedCells.Count > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewThongTin.Rows[e.RowIndex];
                txtBookID.Text = Convert.ToString(row.Cells[1].Value);
                txtISBN.Text = Convert.ToString(row.Cells[2].Value);
                txtTenSach.Text = Convert.ToString(row.Cells[3].Value);
                txtTacGia.Text = Convert.ToString(row.Cells[4].Value);
                cbNgonNgu.Text = Convert.ToString(row.Cells[5].Value);
                txtNXB.Text = Convert.ToString(row.Cells[6].Value);
                Date.Text = Convert.ToString(row.Cells[7].Value);
            }
        }

        /** Xóa Dữ liệu trong DataBase **/

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var filter = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
                bookCollection.DeleteOne(filter);
                LoadBookData();
                MessageBox.Show("Xóa thành công");
            }
            
        }

        /** Làm mới hết chữ trong TextBox trong Tab Thông Tin **/
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtISBN.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            cbNgonNgu.Text = "";
            txtNXB.Text = "";
            Date.Text = "";
        }

        /** Hien Thi DataBase Len DataGridView **/
        public void LoadBookData()
        {
            var filterDefinition = Builders<Book>.Filter.Empty;
            var sort = Builders<Book>.Sort.Ascending("bookID");
            var books = bookCollection.Find(filterDefinition).Sort(sort).ToList();
            dataGridViewThongTin.DataSource = books;            
        }

        /** Ket Noi DataBase **/
        private void QLSach_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            bookCollection = database.GetCollection<Book>("book");
            LoadBookData();
        }

/* Tab Tim Kiem */

        /** Kết nối TextBox với CheckBox**/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            int TextBoxNumber = Convert.ToInt32(checkBox.Tag);

            TextBox textBox = Controls.Find("textBox" + TextBoxNumber, true)[0] as TextBox;
            if (textBox != null)
            {
                textBox.Enabled = checkBox.Checked;

                if (!textBox.Enabled)
                {
                    textBox.Text = "";
                }
            }
        }

        private void ForcomboBox_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = checkBox5.Checked;
            if (!textBox5.Enabled)
                textBox5.Text = "";
        }

        private void ForDate_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = checkBox7.Checked;
            if (!textBox7.Enabled)
                textBox7.Text = "";
        }

        /** Làm mới hết chữ trong ô TextBox bên Tab Tìm kiếm **/
        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        /** Chỉ được viết số trong TextBox BookID**/
        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        /** Nút tìm kiếm **/
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Timkiem();
        }

        public void Timkiem()
        {
            var filterBuilder = Builders<Book>.Filter;
            var filter = filterBuilder.Empty;
            var sort = Builders<Book>.Sort.Ascending("bookID");
            var isbnFilter = new BsonRegularExpression($".*{textBox2.Text}.*", "i");
            var nameFilter = new BsonRegularExpression($".*{textBox3.Text}.*", "i");
            var authorFilter = new BsonRegularExpression($".*{textBox4.Text}.*", "i");
            var nxbFilter = new BsonRegularExpression($".*{textBox6.Text}.*", "i");
            
            if (textBox1.Enabled)
            {
                if (textBox1.Text != "")               
                    filter &= filterBuilder.Eq(a => a.BookID, Int32.Parse(textBox1.Text));                
                else
                {
                    MessageBox.Show("Chưa nhập mã ID sách");
                    return;
                }
            }            

            if (textBox2.Enabled)
            {
                if (textBox2.Text != "")                
                    filter &= filterBuilder.Regex(a => a.ISBN, isbnFilter.ToString());                
                else
                {
                    MessageBox.Show("Chưa nhập mã ISBN");
                    return;
                }
            }            

            if (textBox3.Enabled)
            {
                if (textBox3.Text != "")                
                    filter &= filterBuilder.Regex(a => a.Tên_Sách, nameFilter.ToString());                
                else
                {
                    MessageBox.Show("Chưa nhập tên sách");
                    return;
                }
            }            

            if (textBox4.Enabled)
            {
                if (textBox4.Text != "")
                    filter &= filterBuilder.Regex(a => a.Tác_Giả, authorFilter.ToString());
                else
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    return;
                }
            }            

            if (textBox5.Enabled)
            {
                if (textBox5.Text != "")
                    filter &= filterBuilder.Eq(a => a.Ngôn_Ngữ, textBox5.Text);
                else
                {
                    MessageBox.Show("Chưa chọn ngôn ngữ");
                    return;
                }
            }            

            if (textBox6.Enabled)
            {
                if (textBox6.Text != "")
                    filter &= filterBuilder.Regex(a => a.Nhà_Xuất_Bản, nxbFilter.ToString());
                else
                {
                    MessageBox.Show("Chưa nhập nhà xuất bản");
                    return;
                }                    
            }            

            if (textBox7.Enabled)
            {                
                    filter &= filterBuilder.Regex(a => a.Ngày_Công_Bố, textBox7.Text);                
            }            

            var results = bookCollection.Find(filter).Sort(sort).ToList();

            if (results.Count > 0)
            {
                dataGridViewTimKiem.DataSource = results;
            }
            else
            {
                dataGridViewTimKiem.DataSource = results;
                MessageBox.Show("Không tìm thấy dữ liệu");                
            }
        }
        

    }
}
