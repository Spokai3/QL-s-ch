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
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace QL_sách
{
    public partial class QLSach : Form
    {
        IMongoCollection<Book> bookCollection;
        private Dictionary<string, Control> fieldControlMap;
        public QLSach()
        {
            InitializeComponent();

            string field1 = $"bookID";
            string field2 = $"isbn";
            string field3 = $"title";
            string field4 = $"authors";
            string field5 = $"language_code";
            string field6 = $"publisher";
            string field7 = $"publication_date";
            
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
            var filter = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
            var update = Builders<Book>.Update
                .Set(a => a.ISBN, txtISBN.Text)
                .Set(a => a.Tên_Sách, txtTenSach.Text)
                .Set(a => a.Tác_Giả, txtTacGia.Text)
                .Set(a => a.Ngôn_Ngữ, cbNgonNgu.Text)
                .Set(a => a.Nhà_Xuất_Bản, txtNXB.Text)
                .Set(a => a.Ngày_Công_Bố, Date.Text);
            bookCollection.UpdateOne(filter, update);
            LoadBookData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaThongTin();
        }

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

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var filter = Builders<Book>.Filter.Eq(a => a.BookID, Int32.Parse(txtBookID.Text));
                bookCollection.DeleteOne(filter);
            }
            LoadBookData();
            MessageBox.Show("Xóa thành công");
        }

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

        /**Hien Thi Len DataGrid*/
        public void LoadBookData()
        {
            var filterDefinition = Builders<Book>.Filter.Empty;
            var sort = Builders<Book>.Sort.Ascending("bookID");
            var books = bookCollection.Find(filterDefinition).Sort(sort).ToList();
            dataGridViewThongTin.DataSource = books;
            /*dataGridViewTimKiem.DataSource = books;*/
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

        /** Tab Tim Kiem **/
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            int TextBoxNumber = Convert.ToInt32(checkBox.Tag);

            ComboBox textBox = Controls.Find("textBox" + TextBoxNumber, true)[0] as ComboBox;
            if (textBox != null)
            {
                textBox.Enabled = checkBox.Checked;

                if (!textBox.Enabled)
                {
                    textBox.Text = "";
                }
            }
        }

        private void checkBox6_CheckedChangedd(object sender, EventArgs e)
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

        private void checkBox7_CheckedChangedd(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            int TextBoxNumber = Convert.ToInt32(checkBox.Tag);

            DateTimePicker textBox = Controls.Find("textBox" + TextBoxNumber, true)[0] as DateTimePicker;
            if (textBox != null)
            {
                textBox.Enabled = checkBox.Checked;

                if (!textBox.Enabled)
                {
                    textBox.Text = "";
                }
            }
        }

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

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fieldNameMapping.Clear();
            var filterBuilder = Builders<Book>.Filter;
            var filter = filterBuilder.Empty;
            

            for (int i=7; i <= 7; i++)
            {
                TextBox fieldNameTextBox = Controls.Find("txtFieldName" + i, true)[0] as TextBox;
                fieldNameMapping[i] = fieldNameTextBox.Text;
            }

            foreach (var kvp in fieldNameMapping)
            {
                int TextBoxNumber = kvp.Key;
                string userDefinedFieldName = kvp.Value;

                CheckBox checkBox = Controls.Find("checkBox" + TextBoxNumber, true)[0] as CheckBox;
                TextBox textBox = Controls.Find("textBox" + TextBoxNumber, true)[0] as TextBox;
                
                if (checkBox.Checked && textBox.Enabled && !string.IsNullOrEmpty(textBox.Text))
                {
                    string databaseFieldName = userDefinedFieldName;
                    filter &= filterBuilder.Eq(databaseFieldName, textBox.Text);
                }
            }           

            var results = bookCollection.Find(filter).ToList();

            if (results.Count > 0)
            {
                dataGridViewTimKiem.DataSource = results;
            }
            else
            {
                MessageBox.Show("Không thấy gì");
            }
        }

        private void SetupFieldTextBoxMap()
        {
            fieldTextBoxMap = new Dictionary<string, TextBox> {
                { "field1", textBox1 },
                { "field2", textBox2 },
                { "field3", textBox3 },
                { "field4", textBox4 },
                { "ComboBoxField", textBox5 },
                { "field6", textBox6 },
                { "field7", textBox7 }
            };
        }
        

    }
}
