using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAdoNet.model;

namespace WindowsFormsAdoNet
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NA1POU6\SQLEXPRESS;Initial Catalog=adonet;User ID=sa;password=1");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  kayitlariGetir();
        }

        public List<Musteri> kayitlariGetir()
        {
            List<Musteri> musteriList = new List<Musteri>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from musteri", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Musteri musteri = new Musteri();
                musteri.id = int.Parse(dr["id"].ToString());
                musteri.isim = dr["isim"].ToString();
                musteri.soyisim = dr["soyisim"].ToString();
                musteri.emailAdres = dr["email"].ToString();
                musteri.telefonno = dr["telefonno"].ToString();
                musteriList.Add(musteri);
            }
            con.Close();
            return musteriList;
        }

        public int kayitEkle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into musteri (isim,soyisim,email,telefonno) values(@isim,@soyisim,@email,@telefonno)", con);
            cmd.Parameters.AddWithValue("@isim", txt_isim.Text);
            cmd.Parameters.AddWithValue("@soyisim", txt_soyisim.Text);
            cmd.Parameters.AddWithValue("@email", txt_emailadres.Text);
            cmd.Parameters.AddWithValue("@telefonno", maskedTextBox1.Text);
            int donenDeger = cmd.ExecuteNonQuery();
            con.Close();
            if(donenDeger == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void btn_kayitekle_Click(object sender, EventArgs e)
        {
            int donenDeger = kayitEkle();
            if(donenDeger == 1)
            {
                MessageBox.Show("Kayıt Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kayitlariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int kayitGuncelle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update musteri set email=@email where id=@id", con);
            cmd.Parameters.AddWithValue("@email", txt_emailadres.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            int donenDeger = cmd.ExecuteNonQuery();
            con.Close();
            if(donenDeger == 1)
            {
                return 1; //Başarılı
            }
            else
            {
                return 0; //Başarısız
            }
        }
        private void btn_kayitguncelle_Click(object sender, EventArgs e)
        {
           int sonuc = kayitGuncelle();
            if (sonuc == 1)
            {
                MessageBox.Show("Kayıt Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kayitlariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int kayitSil()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from musteri where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            int donenDeger = cmd.ExecuteNonQuery();
            con.Close();
            if (donenDeger == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        private void btn_kayitsil_Click(object sender, EventArgs e)
        {
            int sonuc =kayitSil();
            if(sonuc == 1)
            {

                MessageBox.Show("Kayıt Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kayitlariGetir();
            }
            else
            {
                MessageBox.Show("Kayıt hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
