using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int cpu, ram,other,other1,other2,other3, lcd ,total;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                cpu = 17970;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                cpu = 22000;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

                ram = 2699;
                string ram2 = Convert.ToString(ram);
                textBox5.Text = ram2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
                ram = 5398;
                string ram2 = Convert.ToString(ram);
                textBox5.Text = ram2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
                lcd = 4088;
                string lcd2 = Convert.ToString(lcd);
                textBox4.Text = lcd2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
                lcd = 5988;
                string lcd2 = Convert.ToString(lcd);
                textBox4.Text = lcd2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            lcd = 6488;
            string lcd2 = Convert.ToString(lcd);
            textBox4.Text = lcd2;
            total = cpu + ram + lcd + other;
            string total2 = Convert.ToString(total);
            textBox9.Text = total2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked is true)
            {
                other1 = 4990;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
            if (checkBox1.Checked is false)
            {
                other1 = 0;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked is true)
            {
                other2 = 2990;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
            if (checkBox2.Checked is false)
            {
                other2 = 0;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked is true)
            {
                other3 = 2290;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
            if (checkBox3.Checked is false)
            {
                other3 = 0;
                other = other1 + other2 + other3;
                total = cpu + ram + lcd + other;
                string other_ = Convert.ToString(other);
                textBox7.Text = other_;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked is true)
            {
                cpu = 15800;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked is true)
            {
                ram = 1400;
                string ram2 = Convert.ToString(ram);
                textBox5.Text = ram2;
                total = cpu + ram + lcd + other;
                string total2 = Convert.ToString(total);
                textBox9.Text = total2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked is true)
            {
                cpu = 15800;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
            }
            else if (radioButton2.Checked is true)
            {
                cpu = 17900;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
            }
            else if (radioButton3.Checked is true)
            {
                cpu = 22000;
                string cpu2 = Convert.ToString(cpu);
                textBox2.Text = cpu2;
            }
        }
    }
}
