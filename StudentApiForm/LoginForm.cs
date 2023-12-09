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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserName.Text != null && Password.Text != null)
            {
                string name = UserName.Text;
                string password = Password.Text;

                if (name == "admin" && password == "admin")
                {
                    this.Hide();
                    StudentInfo st = new StudentInfo();
                    st.ShowDialog();
                    st.Dispose();
                    this.Close();
                }
                else
                {
                    WebRequest request = WebRequest.Create("http://localhost/StudentsInfoApi/login.php");
                    request.Method = "POST";// the method to send data
                    request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

                    string postData = "name=" + name + "&password=" + password;

                    ASCIIEncoding enc = new ASCIIEncoding();
                    byte[] data = enc.GetBytes(postData);
                    Stream stream = request.GetRequestStream();
                    stream.Write(data, 0, data.Length);

                    WebResponse response = request.GetResponse();
                    Stream stream2 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream2);
                    string result = sr.ReadLine();

                    if (result == "success")
                    {
                        // MessageBox.Show("Successfully");
                        this.Hide();
                        FormStudents st = new FormStudents();
                        st.ShowDialog();
                        st.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login User Name/Password");
                    }
                }
            }
        }
    }
}
