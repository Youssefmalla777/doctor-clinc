using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doctor_clinc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if(txtname.Text.Trim() == "" || txtcode.Text.Trim() == "" || txtnumber.Text.Trim() == "")
            {
                MessageBox.Show("fll the textboxses with the data first", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtcode.Text == txtcode.Text.ToLower())
            {
                MessageBox.Show("use the code with big letters!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcode.SelectAll();
                txtcode.Focus();
                return;
            }

            main m = new main();
            DialogResult dr = MessageBox.Show("geting the main page", "main", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if( dr == DialogResult.Yes)
            {
                m.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("welcome sir.. would you like to get in?", "log in", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr==DialogResult.No)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("would you like to log out?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //    txtnumber.SelectAll();
            //txtnumber.Focus();
        }

        private void txtnumber_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //    txtcode.SelectAll();
            //txtcode.Focus();
        }

        private void txtname_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtnumber.Focus();
            }
        }

        private void txtnumber_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtcode.Focus();
            }
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnenter.PerformClick();
            }
        }
    }
}
