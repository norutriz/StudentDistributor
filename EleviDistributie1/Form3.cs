using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleviDistributie1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            try
            {
                textBox1.Text = System.IO.File.ReadAllText("nume.txt");
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("nume.txt", textBox1.Text);
            this.Close();
        }
    }
}
