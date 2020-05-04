using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Fen2 : Form
    {
        public Fen2(string content)
        {
            InitializeComponent();
            textBox1.AppendText(content);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text.ToString());
            this.Close();
        }
    }
}
