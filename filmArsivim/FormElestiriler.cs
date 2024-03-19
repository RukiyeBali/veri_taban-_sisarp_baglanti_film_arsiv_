using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmArsivim
{
    public partial class FormElestiriler : Form
    {
        public FormElestiriler()
        {
            InitializeComponent();
        }
        string connectionstring = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";


        void VeriGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionstring))
            {
                baglanti.Open();
                string sorgu = "SELECT filmler.film_ad,elestiriler.elestiri_metin,elestiriler.puan,elestiriler.elestiri_tarihi,elestiriler.elestirmen FROM elestiriler JOIN filmler ON filmler.film_id=elestiriler.elestiri_id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);

                dgvElestiriler.DataSource = tablo;
            }
        }
        private void FormElestiriler_Load(object sender, EventArgs e)
        {
            
            VeriGetir();    
      
        }
    }
}
