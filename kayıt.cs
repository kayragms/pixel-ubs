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
using System.Data.Sql;

namespace piXel_UBS
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=14GMS07\\SQLEXPRESS;Initial Catalog = ubs; Integrated Security = True";
        SqlConnection con = new SqlConnection(constring);   

        private void kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State ==ConnectionState.Closed) 
                {
                    con.Open();
                    string kayıt = "insert into kisi(isimso,tc,tel,dogum,veliad,velitel,okul,sınıf,hasta,ilc,mail,rutbe,alan,aktif,hobileri,adres) values(@isimso,@tc,@tel,@dogum,@veliad,@velitel,@okul,@sınıf,@hasta,@ilc,@mail,@rutbe,@alan,@aktif,@hobileri,@adres)";
                   
                    SqlCommand cmd = new SqlCommand(kayıt ,con);
                   
                    cmd.Parameters.AddWithValue("@isimso",textBox1.Text);
                    
                    cmd.Parameters.AddWithValue("@tc", textBox3.Text);
                    
                    cmd.Parameters.AddWithValue("@tel", textBox15.Text);
                    
                    cmd.Parameters.AddWithValue("@dogum", textBox4.Text);
                    
                    cmd.Parameters.AddWithValue("@veliad", textBox5.Text);
                    
                    cmd.Parameters.AddWithValue("@velitel", textBox16.Text);
                    
                    cmd.Parameters.AddWithValue("@okul", textBox7.Text);
                   
                    cmd.Parameters.AddWithValue("@sınıf", textBox8.Text);
                
                    cmd.Parameters.AddWithValue("@hasta", textBox9.Text);
                    
                    cmd.Parameters.AddWithValue("@ilc", textBox10.Text);
                    
                    cmd.Parameters.AddWithValue("@mail", textBox11.Text);
                    
                    cmd.Parameters.AddWithValue("@rutbe", textBox12.Text);
                    
                    cmd.Parameters.AddWithValue("@alan", textBox6.Text);
                    
                    cmd.Parameters.AddWithValue("@aktif", textBox13.Text);
                    
                    cmd.Parameters.AddWithValue("@hobileri", textBox2.Text);
                    
                    cmd.Parameters.AddWithValue("@adres", textBox14.Text);
                    
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    
                    MessageBox.Show("KAYIT ALINDI SAYIN YUNUS BEY");

                }


            } 
            catch(Exception hata)
            {
                MessageBox.Show(" bir hata oldu "+hata.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
