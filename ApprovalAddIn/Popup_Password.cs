using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovalAddIn
{
    public partial class Popup_Password : Form
    {
        private String reason = "";
        private String password="";


        public Popup_Password(String reason)
        {
            InitializeComponent();
            this.Reason = reason;
        }


        public Popup_Password()
        {
            InitializeComponent();
        }

        public string Password { get => password; set => password = value; }
        public string Reason { get => reason; set => reason = value; }



        private void Popup_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }


        private void Popup_Password_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            form.StartPosition = FormStartPosition.CenterParent;
            

            if (reason != "")
            {
                lblReason.Text = reason;
                lblReason.Visible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password = txtPassword.Text;
                this.Close();
            }
        }
    }
}
