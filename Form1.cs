using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        #region
        private void btn00_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 0 + 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 0;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 3;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 1;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 6;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 5;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 4;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 9;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 8;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 2;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtCalculator.Text != "")
            {
                num1 = float.Parse(txtCalculator.Text);
                txtCalculator.Clear();
                txtCalculator.Focus();
                count = 1;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtCalculator.Text);
            txtCalculator.Clear();
            txtCalculator.Focus();
            count = 4;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculator.Clear();
            count = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + 7;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int c = txtCalculator.TextLength;
            int flag = 0;
            string text = txtCalculator.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ",")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtCalculator.Text = txtCalculator.Text + ",";
            }
        }


        #endregion



        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.D1))
            {
                btn1.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D2))
            {
                btn2.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D3))
            {
                btn3.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D4))
            {
                btn4.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D5))
            {
                btn5.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D6))
            {
                btn6.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D7))
            {
                btn7.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D8))
            {
                btn8.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D9))
            {
                btn9.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.D0))
            {
                btn0.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.OemQuestion))
            {
                btnDivide.PerformClick();
            }


        }

        

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtCalculator.Text);
                    txtCalculator.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtCalculator.Text);
                    txtCalculator.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtCalculator.Text);
                    txtCalculator.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtCalculator.Text);
                    txtCalculator.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
