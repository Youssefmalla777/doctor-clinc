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
    public partial class medical : Form
    {
        public medical()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtdoctor.Text == "" || txtpatient.Text == "" || txtdisease.Text == "" || txtprescrption.Text == "" || txtnotes.Text == "")
                {
                    MessageBox.Show("fill the textboxses first!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                             
                MessageBox.Show("the data of the patient is added..", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewItem ls = new ListViewItem(txtdoctor.Text);
                ls.SubItems.Add(txtpatient.Text);
                ls.SubItems.Add(txtdisease.Text);
                ls.SubItems.Add(txtprescrption.Text);
                ls.SubItems.Add(txtnotes.Text);
                listView1.Items.Add(ls);

                foreach (Control s in this.Controls)
                {
                    if (s is TextBox)
                        s.Text = "";
                }

                if (checkBox1.Checked == true)
                {
                    checkBox1.Checked = false;
                }
                else if (checkBox2.Checked == true)
                {
                    checkBox2.Checked = false;
                }
                else if (checkBox3.Checked == true)
                {
                    checkBox3.Checked = false;
                }
                else
                {
                    checkBox4.Checked = false;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //DialogResult dr = MessageBox.Show("do you wanna to ediet the data??", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dr == DialogResult.Yes)
                
                    if (listView1.SelectedItems.Count > 0)
                    {
                        txtdoctor.Text = listView1.SelectedItems[0].Text;
                        txtpatient.Text = listView1.SelectedItems[0].SubItems[1].Text;
                        txtdisease.Text = listView1.SelectedItems[0].SubItems[2].Text;
                        txtprescrption.Text = listView1.SelectedItems[0].SubItems[3].Text;
                        txtnotes.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    }
                

                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                MessageBox.Show("your data is edited..", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.SelectedItems[0].Text = txtdoctor.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtpatient.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtdisease.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtprescrption.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtnotes.Text;
            }
            foreach(Control h in this.Controls)
            {
                if (h is TextBox)
                    h.Text = "";
            }
        }

        private void btndelete_MouseClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("do you wanna to delete this data?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    for (int c = 0; c <= listView1.SelectedItems.Count; c += 1)
                    {
                        if (listView1.SelectedItems.Count > c)
                        {
                            listView1.Items.Remove(listView1.SelectedItems[c]);
                        }
                    }
                }
                
                else
                {
                    this.Show();
                }

                foreach(Control s in this.Controls)
                {
                    if (s is TextBox)
                        s.Text = "";
                }
               
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you wanna to quit??", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void txtdoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtpatient.Focus();
            }
        }

        private void txtpatient_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtdisease.Focus();
            }
        }

        private void txtdisease_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtprescrption.Focus();
            }
        }

        private void txtprescrption_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdisease.Focus();
            }
        }
    }
}
