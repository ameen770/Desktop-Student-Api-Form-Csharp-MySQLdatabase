using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentApiForm
{
    public partial class AddUpdateStudent : Form
    {
        private readonly StudentInfo _parent;
        public string id, name, password, reg, iclass, section;
        public AddUpdateStudent(StudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Update Student";
            btnSave.Text = "Update";
            txtName.Text = name;
            txtPassword.Text = password;
            txtReg.Text = reg;
            txtClass.Text = iclass;
            txtSection.Text = section;
        }

        public void SaveInfo()
        {
            lbltext.Text = "Add Student";
            btnSave.Text = "Save";
        }

        public void Clear()
        {
            txtName.Text = txtPassword.Text = txtReg.Text = txtClass.Text = txtSection.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (txtName.Text != "" && txtPassword.Text != "" && txtReg.Text != "" && txtClass.Text != "" && txtSection.Text != "")
                {
                    WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/add.php");
                    request.Method = "POST";// the method to send data
                    request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                    string name = txtName.Text;
                    string password = txtPassword.Text;
                    string reg = txtReg.Text;
                    string iclass = txtClass.Text;
                    string section = txtSection.Text;
                    string postData = "&name=" + name + "&password=" + password + "&reg=" + reg + "&iClass=" + iclass + "&section=" + section;

                    ASCIIEncoding enc = new ASCIIEncoding();
                    byte[] data = enc.GetBytes(postData);
                    Stream stream = request.GetRequestStream();
                    stream.Write(data, 0, data.Length);

                    WebResponse response = request.GetResponse();
                    Stream stream2 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream2);
                    string result = sr.ReadLine();
                    _parent.Display();

                    if (result != "success")
                    {
                        MessageBox.Show("Added Successfully. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                    Clear();
                    return;
                }
            }

            if (btnSave.Text == "Update")
            {
                WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/update.php");
                request.Method = "POST";// the method to send data
                request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                string name = txtName.Text;
                string password = txtPassword.Text;
                string reg = txtReg.Text;
                string iclass = txtClass.Text;
                string section = txtSection.Text;
                string postData = "id=" + id + "&name=" + name + "&password=" + password + "&reg=" + reg + "&iClass=" + iclass + "&section=" + section;

                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] data = enc.GetBytes(postData);
                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);

                WebResponse response = request.GetResponse();
                Stream stream2 = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream2);
                string result = sr.ReadLine();
                _parent.Display();
                if (result != "success")
                {
                    MessageBox.Show("Updated Successfully. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot Be  Empty");
                }
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
