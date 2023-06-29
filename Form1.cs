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
using MySql.Data.MySqlClient;

namespace CLASE14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=127.0.0.1;User=root;Database=clase14_61;password=''");
            con.Open();
            DataTable datos = new DataTable();
            string sentencia = "select * from estudiantes";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sentencia, con);
            adapter.Fill(datos);
            con.Close();

            dataGridView1.DataSource = datos;
        }
    }
}
