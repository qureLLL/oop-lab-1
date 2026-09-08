using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _3практична
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void протабулюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double x, xk, h, y, y_prime;
                double[] arr = new double[100];
                int i = 0;

                x = Convert.ToDouble(textBox1.Text);
                xk = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox3.Text);

                using (System.IO.StreamWriter f = new System.IO.StreamWriter("file.txt", true))
                {
                    for (double currentX = x; currentX <= xk; currentX += h)
                    {
                        y = Math.Sin(currentX) + 1;
                        string outputLine = Math.Round(currentX, 1) + "\t" + Math.Round(y, 4);

                        if (checkBox4.Checked)
                        {
                            y_prime = Math.Cos(currentX);
                            outputLine += "\tПох: " + Math.Round(y_prime, 4);
                        }
                        if (checkBox1.Checked)
                        {
                            listBox1.Items.Add(outputLine);
                        }

                        if (checkBox2.Checked)
                        {
                            f.WriteLine(outputLine);
                        }

                        if (checkBox3.Checked && i < 100)
                        {
                            arr[i] = y;
                            i++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка вхідних даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void очиститиПолеВиведенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void знятиВсіПрапорціToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void встановитиВсіПрапорціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }

        private void встановитиІнверсіюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkBox2.Checked = !checkBox2.Checked;
            checkBox3.Checked = !checkBox3.Checked;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}