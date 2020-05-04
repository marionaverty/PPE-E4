using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace Form1
{
    public partial class Form2 : Form
    {
        string connectString = "SERVER=127.0.0.1; DATABASE=sucrerie; UID=root; PASSWORD =";
        public Form2()
        {
            InitializeComponent();
            MySqlConnection Conn = new MySqlConnection(connectString);
            try
            {
                Conn.Open();
                string sql = "SHOW DATABASES;";
                DataTable schema = Conn.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    comboBox1.Items.Add(row[2].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectString);
            try
            {
                Console.WriteLine(dataGridView1.Focus().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("toto");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection Conn = new MySqlConnection(connectString);
            try
            {
                Console.WriteLine(comboBox1.SelectedItem.ToString());
                var DataContacts = Utilitaire.comboType(comboBox1);
                dataGridView1.DataSource = DataContacts;
            }
            catch (Exception ex)
            {
                Console.WriteLine("toto");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*string uid = dataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value.ToString();
            string row = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Fen2 fen2 = new Fen2(row);
            fen2.Visible = Visible.Equals(true);*/
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            Console.WriteLine("toto");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataGridViewRow ligne = dataGridView1.Rows[index];
            List<String> values = new List<String>();
            foreach(DataGridViewCell cell in ligne.Cells)
            {
                values.Add(cell.Value.ToString());
            }
            List<String> libelles = Utilitaire.getList(comboBox1);
            foreach(string libelle in libelles)
            {
                Console.WriteLine(libelle.ToString());
            }
            
        }

    }
}
