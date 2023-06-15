using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cSharpRev1
{
    public partial class Categories : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\exercice\\c#\\cSharpRev1\\cSharpRev1\\gestionStock.mdf;Integrated Security=True");
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionStockDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.gestionStockDataSet.Categories);

        }

        private void save_Click(object sender, EventArgs e)
        {
            string req = "INSERT INTO Categories (libelle, tva) VALUES(@lib, @tva)";
            SqlCommand cmd = new SqlCommand(req, con);
            cmd.Parameters.AddWithValue("@lib", libelle_TB.Text);
            cmd.Parameters.AddWithValue("@tva", float.Parse(taux_tva_TB.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("You have added the categorie with success", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            refrechData();
            con.Close();
        }

        public void refrechData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();

            string query = "SELECT * FROM Categories";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous vraiment quitter l'application", "Quitter", MessageBoxButtons.YesNo ,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
