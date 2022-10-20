using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_DCU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstore.Clear();
            txtresoult.Clear(); 

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "3";
        }
        float num;
        int count;
        private void btnguion_Click(object sender, EventArgs e)
        {
            if(txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresoult.Text = txtstore.Text + "-";
                txtstore.Clear();
                count = 1;


            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "9";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtstore.Text);
            txtresoult.Text = txtstore.Text + "+";
            txtstore.Clear();
            count = 2;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtstore.Text);
            txtresoult.Text = txtstore.Text + "*";
            txtstore.Clear();
            count = 3;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtstore.Text);
            txtresoult.Text = txtstore.Text + "/";
            txtstore.Clear();
            count = 4;
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtstore.Text);
            txtresoult.Text = txtstore.Text + "%";
            txtstore.Clear();
            count = 5;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:

                    ans = num - float.Parse(txtstore.Text);
                    txtresoult.Text = txtresoult.Text + txtstore.Text;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:

                    ans = num + float.Parse(txtstore.Text);
                    txtresoult.Text = txtresoult.Text + txtstore.Text;
                    txtstore.Text = ans.ToString();
                    break;
                case 3:

                    ans = num * float.Parse(txtstore.Text);
                    txtresoult.Text = txtresoult.Text + txtstore.Text;
                    txtstore.Text = ans.ToString();
                    break;
                case 4:
                    if (txtstore.Text != "0")
                    {
                        ans = num / float.Parse(txtstore.Text);
                        txtresoult.Text = txtresoult.Text + txtstore.Text;
                        txtstore.Text = ans.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero!!");
                    }
                    ans = num / float.Parse(txtstore.Text);
                    txtresoult.Text = txtresoult.Text + txtstore.Text;
                    txtstore.Text = ans.ToString();
                    break;
                case 5:

                    ans = num % float.Parse(txtstore.Text);
                    txtresoult.Text = txtresoult.Text + txtstore.Text;
                    txtstore.Text = ans.ToString();
                    break;

            }
        }
    }
}
