using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kakulitor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private bool isNumber = false;
        private double numFirst, numSecond, numRes;
       
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9|| e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9|| e.KeyCode == Keys.Back;

        }


        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch(e.KeyChar)
            {
                case '-':
                    if (box.Text.Length == 0)
                    {
                        isNumber = true;
                    }
                    break;
                case  '.':
                case  ',':
                    if (box.Text.Length == 0)
                    { 
                        isNumber = false;
                        break;
                    }
                    if ((box.Text[0] != '-' && box.Text.Length == 1 && !(box.Text.Contains(',') || (box.Text.Contains(',')))) || (box.Text[0] != '-' && box.Text.Length == 2 && !(box.Text.Contains(',') || (box.Text.Contains(',')))))
                    {
                        isNumber = true;
                        break;
                    }
                    break;
                case '!':
                case '@':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '"':
                case '№':
                case ';':
                case ':':
                case '?':
                    isNumber = false;
                    break;

            }
            if (!isNumber)
            {
                e.Handled = true;
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            string strFirst = string.Copy(txtB1.Text);
            string strSecond = string.Copy(txtB2.Text);
            if(txtB1.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strFirst);
            }
            else
            {
                numFirst = 0;
            }

            if (txtB2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strSecond);
            }
            else
            {
                numSecond = 0;
            }

            bool divideFlag = false;
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnplus":
                    numRes = numFirst + numSecond;
                    lblresalt.Text = numRes.ToString();
                     break;
                case "btnminus":
                    numRes = numFirst - numSecond;
                    lblresalt.Text = numRes.ToString();
                    break;
                case "btninkris":
                    numRes = numFirst * numSecond;
                    lblresalt.Text = numRes.ToString();
                    break;
                case "btndivide":
                    if(Math.Abs(numSecond) < 1.0E-30)
                    {
                        MessageBox.Show("делить на ноль нельзя", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        numRes = numFirst / numSecond;
                        lblresalt.Text = numRes.ToString();
                    }
                    break;
            }
            if (!divideFlag)
            {
                lblresalt.Text = Convert.ToString(numRes);
            }

        }

        private void btn_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
