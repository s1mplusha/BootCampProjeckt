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
    public partial class PASSWORD : Form
    {
        public PASSWORD()
        {
            InitializeComponent();
        }
        public PASSWORD(string windowsTile, string message)
        {
            InitializeComponent();
            this.Text = windowsTile;
            LBLPSS.Text = message;
            this.ActiveControl = TXTBPPS;
        }
        public static string Show(string windowsTile, string message)
        {
            using (PASSWORD inputdlg = new PASSWORD(windowsTile, message))
            {
                inputdlg.ShowDialog();
                return inputdlg.TXTBPPS.Text;
            }
        }

        private void PASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void TXTBPPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


