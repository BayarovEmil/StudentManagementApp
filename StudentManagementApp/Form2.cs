using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class Form2 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", Type.GetType("System.Int32"));
            table.Columns.Add("Firstname", Type.GetType("System.String"));
            table.Columns.Add("Lastname", Type.GetType("System.String"));
            table.Columns.Add("Email", Type.GetType("System.String"));
            table.Columns.Add("Gpa", Type.GetType("System.Double"));
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text,textBox2.Text,
                textBox3.Text,textBox4.Text,textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=String.Empty;
            textBox2.Text=String.Empty;
            textBox3.Text=String.Empty;
            textBox4.Text=String.Empty;
            textBox5.Text=String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = textBox1.Text;
            newData.Cells[1].Value = textBox2.Text;
            newData.Cells[2].Value = textBox3.Text;
            newData.Cells[3].Value = textBox4.Text;
            newData.Cells[4].Value = textBox5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
