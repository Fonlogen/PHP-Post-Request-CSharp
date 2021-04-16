using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace RequestExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string URL = "http://localhost/request.php"; //PHP Page Url

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();

            NameValueCollection formData = new NameValueCollection();
            formData["examplestring"] = textBox1.Text; // Will pick the TextBox1 text value and pass it throug POST metod as "examplestring"

            byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);
            string responsefromserver = Encoding.UTF8.GetString(responseBytes);

            MessageBox.Show("Out: " + responsefromserver);

            webClient.Dispose();
        }
    }
}