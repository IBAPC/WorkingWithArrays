using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToDecimal(15);

            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = nmax;

            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = nmax;

            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = nmax;

            arrA = IntArray.RandomIntArray(nmax, Left, Right);
            fillGridFromArray(arrA, ref dataGridView1);
            arrB = IntArray.RandomIntArray(nmax, Left, Right);
            fillGridFromArray(arrB, ref dataGridView2);
            label1.Visible = false;
            dataGridView3.Visible = false;

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
        }

        int nmax = 15;
        IntArray arrA = new IntArray(15);
        IntArray arrB = new IntArray(15);
        public Form1()
        {
            InitializeComponent();
        }

        private void FillRandom(DataGridView dgv)
        {
            int n = dgv.ColumnCount;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                dgv.Columns[i].Name = (i + 1).ToString();
                dgv.Rows[0].Cells[i].Value = rnd.Next(-1000, 1000).ToString();
            }
        }

        private void fillGridFromArray(IntArray a, ref DataGridView dgv)
        {
            dgv.ColumnCount = a.Length;

            for (int i = 0; i < a.Length; i++)
            {
                dgv.Columns[i].Name = (i + 1).ToString();
                dgv.Rows[0].Cells[i].Value = a[i].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
                FillRandom(dataGridView1);
            }
            else if (radioButton3.Checked == true)
            {
                var arr = IntArray.ArrayFromTextFile(textBox1.Text.ToString());
                fillGridFromArray(arr, ref dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
                FillRandom(dataGridView2);
            }
            else if (radioButton3.Checked == true)
            {
                var arr = IntArray.ArrayFromTextFile(textBox1.Text.ToString());
                fillGridFromArray(arr, ref dataGridView2);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dataGridView1.ReadOnly = false;
                dataGridView2.ReadOnly = false;
            }
            if (radioButton2.Checked == false)
            {
                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;
            }
        }

        private void суммаЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            label1.Visible = true;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sum1 += Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            }
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                sum2 += Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value);
            }

            label1.Text = "Сумма элементов массива A:" + sum1 + " | Сумма элементов массива B:" + sum2;
        }

        private void колвоЭлементовКратныхЗаданномуЧислуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            label1.Visible = true;
            label1.Text = "";
            int n = 0;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            if (newForm.textBox1.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым!");
                newForm.Close();

            }
            else
            {
                n = Convert.ToInt32(newForm.textBox1.Text);
                label1.Text = "Для первого массива:";
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) % n == 0)
                    {
                        label1.Text += " " + Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                    }
                }
                label1.Text += " | Для второго массива:";
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    if (Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value) % n == 0)
                    {
                        label1.Text += " " + Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value);
                    }
                }
            }
        }

        private void aBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Сумма массивов:";
            dataGridView3.Visible = true;
            if (dataGridView1.ColumnCount == dataGridView2.ColumnCount)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView3.Columns[i].Name = (i + 1).ToString();
                    dataGridView3.Rows[0].Cells[i].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) + Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Кол-во элементов в массивах должно быть одинаковым!");
            }
        }

        private void aBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Разница массивов:";
            dataGridView3.Visible = true;
            if (dataGridView1.ColumnCount == dataGridView2.ColumnCount)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView3.Columns[i].Name = (i + 1).ToString();
                    dataGridView3.Rows[0].Cells[i].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) - Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Кол-во элементов в массивах должно быть одинаковым!");
            }
        }

        private void массивAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) < 0)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[0].Cells[j].Value) < 0)
                        {
                            if(Convert.ToInt32(dataGridView1.Rows[0].Cells[j].Value) < Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value))
                            {
                                temp = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                                dataGridView1.Rows[0].Cells[i].Value = dataGridView1.Rows[0].Cells[j].Value;
                                dataGridView1.Rows[0].Cells[j].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void массивBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                if (Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value) < 0)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (Convert.ToInt32(dataGridView2.Rows[0].Cells[j].Value) < 0)
                        {
                            if (Convert.ToInt32(dataGridView2.Rows[0].Cells[j].Value) < Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value))
                            {
                                temp = Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value);
                                dataGridView2.Rows[0].Cells[i].Value = dataGridView2.Rows[0].Cells[j].Value;
                                dataGridView2.Rows[0].Cells[j].Value = temp;
                            }
                        }
                    }
                }
            }
        }

        private void массивCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Visible == true)
            {
                int temp = 0;
                for (int i = 0; i < dataGridView3.ColumnCount; i++)
                {
                    if (Convert.ToInt32(dataGridView3.Rows[0].Cells[i].Value) < 0)
                    {
                        for (int j = 0; j < dataGridView3.ColumnCount; j++)
                        {
                            if (Convert.ToInt32(dataGridView3.Rows[0].Cells[j].Value) < 0)
                            {
                                if (Convert.ToInt32(dataGridView3.Rows[0].Cells[j].Value) < Convert.ToInt32(dataGridView3.Rows[0].Cells[i].Value))
                                {
                                    temp = Convert.ToInt32(dataGridView3.Rows[0].Cells[i].Value);
                                    dataGridView3.Rows[0].Cells[i].Value = dataGridView3.Rows[0].Cells[j].Value;
                                    dataGridView3.Rows[0].Cells[j].Value = temp;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Массив C должен отображаться");
            }
        }
    }
}
