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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }
        int i = 0;
        string ad = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" && maskedTextBox1.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Заполните всё");
            }
            else
            {
                i++;
                dataGridView1.Rows.Add(i, textBox1.Text, maskedTextBox1.Text, textBox3.Text,comboBox1.SelectedItem);
            }
            int b = dataGridView1.Rows.Count;
            label4.Text = "Количетсов записей: " + (b- 1);

            MessageBox.Show(ad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[1].Value = textBox1.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = maskedTextBox1.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = textBox3.Text;
        }
        //dadddd
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                maskedTextBox1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);


                ad = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
                for (int i = 0; i < 4; i++)
                {
                    if (ad == comboBox1.Items[i])
                    {
                        comboBox1.SelectedItem = comboBox1.Items[i];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выбери корретную строку");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);


                int b = dataGridView1.Rows.Count;
                label4.Text = "Количетсов записей: " + (b - 1);
                //eshe testaD
                //aao
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
