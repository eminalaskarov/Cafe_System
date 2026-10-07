using System;
using System.Windows.Forms;

namespace Cafe_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;

        private void ElaveEt(string ad, double qiymet)
        {
            listBox1.Items.Add(ad + " - " + qiymet.ToString());
            total += qiymet;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { ElaveEt("Burger", 6.3); }
        private void pictureBox2_Click(object sender, EventArgs e) { ElaveEt("Tort", 4.5); }
        private void pictureBox3_Click(object sender, EventArgs e) { ElaveEt("Kofe", 3.0); }
        private void pictureBox4_Click(object sender, EventArgs e) { ElaveEt("Hot-dog", 4.0); }
        private void pictureBox5_Click(object sender, EventArgs e) { ElaveEt("Limonad", 2.5); }
        private void pictureBox6_Click(object sender, EventArgs e) { ElaveEt("Nuggets", 5.5); }
        private void pictureBox7_Click(object sender, EventArgs e) { ElaveEt("Pissa", 12.0); }
        private void pictureBox8_Click(object sender, EventArgs e) { ElaveEt("Kola", 2.0); }
        private void pictureBox9_Click(object sender, EventArgs e) { ElaveEt("Toyuq", 9.0); }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show(item + " səbətdən silindi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xanalar sıfırlansınmı?", "Xəbərdarlıq", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
                label2.Text = "Qaytarılır: 0";
                total = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
            }
            else
            {
                textBox2.Text = total.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double mebleg;
                if (double.TryParse(textBox1.Text, out mebleg))
                {
                    if (mebleg < total)
                    {
                        MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                    }
                    else
                    {
                        double qaliq = mebleg - total;
                        label2.Text = "Qaytarılır: " + qaliq.ToString();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "Qaytarılır: 0";
        }
    }
}