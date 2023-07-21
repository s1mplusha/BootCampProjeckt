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
    public partial class MENU : Form
    {
        const string _password = "123321";
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            enterPassword:
            string password = PASSWORD.Show("АУТИФИКАЦИЯ", "ВВЕДИ ПАРОЛЬ!!!");
            if(password == "")
            {
                this.Close();
            }

            if(password != _password && password != "")
            {
                MessageBox.Show("пароль не верный.\nПопробуй еще раз","Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto enterPassword;
            }

        }

        private void LLKALKUL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }
    }
}
