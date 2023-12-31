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
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "sp_ogrenciEkle";

            komut.Parameters.AddWithValue("@ogrenciAdi", adtextBox.Text);
            komut.Parameters.AddWithValue("@ogrenciSoyadi", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@ogrenciGsm", gsmtextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eklendi.");
            }
            baglanti.Close();
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "sp_ogrenciSil";

            komut.Parameters.AddWithValue("@ID", idcomboBox.SelectedItem.ToString());

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Silindi.");
            }
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /*private void Guncelle()
        {
            SqlConnection baglanti = new SqlConnection();
           baglanti.ConnectionString = "Data Source=ARIBILGI-YDK2;Initial Catalog=okul;Integrated Security=True";
            baglanti.Open();

           SqlDataAdapter da = new SqlDataAdapter("select * from ogrenciler", baglanti);
            DataSet ds = new DataSet();
           baglanti.Open();
            da.Fill(ds, "ogrenciler");
           baglanti.Close();
            dataGridView1.DataSource = ds.Tables["ogrenciler"];
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select ogrenciID from ogrenci";

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                idcomboBox.Items.Add(dr["ogrenciID"]);
            }

            dr.Close();
            komut.Dispose();
            baglanti.Close();

        }

        void Listele()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";

            SqlDataAdapter da = new SqlDataAdapter("sp_ogrenciListele", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "sp_ogrenciGuncelle";

            komut.Parameters.AddWithValue("@ID", idcomboBox.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@ogrenciAdi", adtextBox.Text);
            komut.Parameters.AddWithValue("@ogrenciSoyadi", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@ogrenciGsm", gsmtextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncellendi.");
            }
            baglanti.Close();
        }

        private void gosterbutton_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void idcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZ;Initial Catalog=OKUL;Integrated Security=True";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrenci where ogrenciID= @ID";

            komut.Parameters.AddWithValue("@ID", idcomboBox.SelectedItem.ToString());

            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                adtextBox.Text = dr["ogrenciAdi"].ToString();
                soyadtextBox.Text = dr["ogrenciSoyadi"].ToString();
                gsmtextBox.Text = dr["ogrenciGsm"].ToString();
            }
            baglanti.Close();

          
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            adtextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadtextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            gsmtextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
