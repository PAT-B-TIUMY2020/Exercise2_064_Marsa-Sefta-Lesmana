using Newtonsoft.Json;
using Service_Exercixe2_064;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_064_Marsa_Sefta_Lesmana
{
    public partial class Form1 : Form
    {
        string baseUrl = "http://localhost:1412/";
        void BuatMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nama = textBox2.Text;
            mhs.nim = textBox1.Text;
            mhs.prodi = textBox3.Text;
            mhs.angkatan = textBox4.Text;
            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseUrl + "Mahasiswa", data);
            Console.WriteLine(response);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuatMahasiswa();
          
        }

        private void btdel_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
