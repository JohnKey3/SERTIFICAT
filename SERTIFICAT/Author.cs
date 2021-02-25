using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERTIFICAT
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123" && textBox2.Text == "123")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Некорректные данные");
            }
        }
    }
}
