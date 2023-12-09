using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApiForm
{
    public partial class StudentInfo : Form
    {

        AddUpdateStudent form;

        public StudentInfo()
        {
            InitializeComponent();
            form = new AddUpdateStudent(this);
        }

        public void Display()
        {
            /*var client = new HttpClient();
            var response = client.GetStringAsync("http://localhost/StudentsInfoApi/menuJson.php");
            var menuStudent = response.Result;

            if (menuStudent != "Sorry, No Student in this menu")
            {
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(menuStudent);
                dt.TableName = "Menu";

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }*/

            // ====================================================

            WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/menuJson.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string postData = "name=";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuStudent = sr.ReadToEnd();
            //MessageBox.Show(menuStudent);
            if (menuStudent != "Sorry, No Student in this menu")
            {
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(menuStudent);
                dt.TableName = "Ameen";

                dataGridView1.DataSource = dt;
            }
        }
        private void StudentInfo_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void StudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Edit

                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.password = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.reg = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.iclass = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.section = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }

            if (e.ColumnIndex == 1)
            {
                // Delete

                if (MessageBox.Show("Are you want to delete the student record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string del = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                    WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/delete.php");
                    request.Method = "POST";// the method to send data
                    request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                    string postData = "id=" + del;

                    ASCIIEncoding enc = new ASCIIEncoding();
                    byte[] data = enc.GetBytes(postData);
                    Stream stream = request.GetRequestStream();
                    stream.Write(data, 0, data.Length);

                    WebResponse response = request.GetResponse();
                    Stream stream2 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream2);
                    string result = sr.ReadLine();

                    Display();
                    MessageBox.Show("Deleted Successfully");
                }
            }
            return;
        }

        private void DisplaySearch(string s)
        {
            //MessageBox.Show(s);
            WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/MenujsonSearch.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string postData = "search=" + s;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuStudent = sr.ReadToEnd();
            //MessageBox.Show(menuStudent);
            if (menuStudent != "Sorry, No Student in this menu")
            {
                try
                {
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(menuStudent);
                    dt.TableName = "Menu";

                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {
                    while (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows.RemoveAt(0);
                    }
                }

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DisplaySearch(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imageRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void imageLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            loginForm.Dispose();
            this.Close();
            //this.Show();
        }
    }
}
