using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adapter;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public char cin;
        private void button1_Click(object sender, EventArgs e)

        {
            verigetir();
            if (radioButton1.Checked==true)
            {
                cin = radioButton1.Text[0];
            }
            else
            {
                cin=radioButton2.Text[0];
            }

            string sorgu = "İNSERT İNTO tabloyol(nereden,nereye,saat,ad,tc,telefon,cinsiyet) VALUES (@nrdn,@nrye,@saat,@ad,@tc,@telefon,@cnsyt)";
           komut =new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@nrdn", comboBox1.Text);
            komut.Parameters.AddWithValue("@nrye", comboBox2.Text);
            
            komut.Parameters.AddWithValue("@saat", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@tc", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@telefon", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@cnsyt", cin);

            MessageBox.Show("kayıt tamam");
            verigetir();


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = a;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        void verigetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=yolcu;Integrated Security=SSPI");
            baglanti.Open();
           SqlDataAdapter da = new SqlDataAdapter("Select *From tabloyol", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            
           dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            void verigetir()
            {
                baglanti = new SqlConnection("server=.; Initial Catalog=yolcu;Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *From tabloyol", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dataGridView1.DataSource = tablo;
                baglanti.Close();
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
