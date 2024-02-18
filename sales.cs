using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace doctor_clinc
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void txtinvoice_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyData == Keys.Enter)
            {
                txtdate.Focus();
            }
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            double newr = 10900;
            MessageBox.Show("your data is added!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (listView1.SelectedItems != null)
            {
                txttotal.Text = Convert.ToDouble(txttotal.Text) + newr + "";

            }

            if (listView1.SelectedItems != null)
            {
                txttrest.Text = Convert.ToDouble(txtprice.Text) - Convert.ToDouble(newr) + "";

            }

            ListViewItem ls = new ListViewItem(txtinvoice.Text);
            ls.SubItems.Add(txtdate.Text);
            ls.SubItems.Add(txtdoctorname.Text);
            ls.SubItems.Add(txtpatientname.Text);
            ls.SubItems.Add(txtdisease.Text);
            ls.SubItems.Add(txtage.Text);
            ls.SubItems.Add(txtaddress.Text);
            ls.SubItems.Add(txttrest.Text);
            ls.SubItems.Add(txtprice.Text);
            StreamWriter sr = new StreamWriter("sales.txt",true);
            string strsales = txtinvoice.Text + "-"
                + txtdoctorname.Text + "-"
                + txtpatientname.Text + "-"
                + txtdate.Text + "-"
                + txtdisease.Text + "-"
                + txtaddress.Text + "-"
                + txtprice.Text + "-"
                + txttrest.Text;
            sr.WriteLine(strsales);
            sr.Close();

            listView1.Items.Add(ls);

            txtaddress.Text = "";
            txtage.Text = "";
            txtdate.Text = "";
            txtdisease.Text = "";
            txtdoctorname.Text = "";
            txtinvoice.Text = "";
            txtpatientname.Text = "";
            txtprice.Text = "";
            txttrest.Text = "";
         
        }

        private void btndate_Click(object sender, EventArgs e)
        {
            txtdate.Text = dtb11.Value.ToString();
        }

        private void btnfind2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                MessageBox.Show("your data is edited!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.SelectedItems[0].Text = txtinvoice.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtdate.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtdoctorname.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtpatientname.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtdisease.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txtage.Text;
                listView1.SelectedItems[0].SubItems[6].Text = txtaddress.Text;

                foreach(Control d in this.Controls)
                {
                    if (d is TextBox)
                        d.Text = "";
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                txtinvoice.Text = listView1.SelectedItems[0].Text;
                txtdate.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtdoctorname.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtpatientname.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtdisease.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtage.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtaddress.Text = listView1.SelectedItems[0].SubItems[6].Text;

            }
        }

        private void btndelete2_Click(object sender, EventArgs e)
        {
            for (int c = 0; c <= listView1.SelectedItems.Count; c += 1)
            {
                if (listView1.SelectedItems.Count > c)
                {
                    DialogResult dr = MessageBox.Show("do you wanna to delete this data?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[c]);
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }

            foreach(Control g in this.Controls)
            {
                if (g is TextBox)
                    g.Text = "";
            }
        }

        private void btndelete2_MouseClick(object sender, MouseEventArgs e)
        {
            for(int c=0;c<=listView1.SelectedItems.Count;c+=1)
            {
                if(listView1.SelectedItems.Count > c)
                {
                    DialogResult dr = MessageBox.Show("do you wanna to delete this data?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[c]);
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you wanna to out?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtdoctorname.Focus();
            }
        }

        private void txtdoctorname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtpatientname.Focus();
            }
        }

        private void txtpatientname_KeyDown(object sender, KeyEventArgs e)
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
                txtage.Focus();
            }
        }

        private void txtage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtage.Focus();
            }
        }

        private void txtage_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdisease.Focus();
            }
        }

        private void txtdisease_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtpatientname.Focus();
            }
        }

        private void txtpatientname_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdoctorname.Focus();
            }
        }

        private void txtdoctorname_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdate.Focus();
            }
        }

        private void txtdate_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtinvoice.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = this.Width + 20;
            int h = this.Height + 5;
            Bitmap b = new Bitmap(w, h);
            Rectangle r = new Rectangle(20, 10, w, h);
            this.DrawToBitmap(b, r);
            e.Graphics.DrawImage(b, r);
        }

        private void sales_Load(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("sales", this.Width + 20, this.Height  + 10);
            printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void txtinvoice_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnshowall2_Click(object sender, EventArgs e)
        {
            int newm = 10900;
            if(Convert.ToDouble(txtprice.Text) != 10900)
            {
                double p = Convert.ToDouble(txttrest.Text);
                double q = Convert.ToDouble(txttotal.Text);
                txttrest.Text = Convert.ToDouble(txtprice.Text) - Convert.ToDouble(newm) + "";
            }
           
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnadd2.PerformClick();
                txtinvoice.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtprice.SelectAll();
                txtprice.Focus();
            }
        }
    }
}
