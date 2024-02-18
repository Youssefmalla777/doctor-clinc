using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace doctor_clinc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtpatient.Text = listView1.SelectedItems[0].Text;
                txtdesies.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
            string strpic = ("images/" + txtpatient.Text + ".jpg");
            if (File.Exists(strpic))
                pictureBox1.Image = Image.FromFile(strpic);
            

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtpatient.Text == "" && txtdesies.Text == "")
            {
                MessageBox.Show("fill the textboxses first!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Directory.Exists("images") == false)
                Directory.CreateDirectory("images");
            pictureBox1.Image.Save("images/" + txtpatient.Text + ".jpg");
            listView1.Items.Add(txtpatient.Text).SubItems.Add(txtdesies.Text);
            MessageBox.Show("your data is added..", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            pictureBox1.Image = new PictureBox().Image;
        }

        private void btnpick_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OD = new OpenFileDialog();
            DialogResult dr = OD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OD.FileName);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                MessageBox.Show("your data has been edited..", "edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.SelectedItems[0].Text = txtpatient.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtdesies.Text;

            }
           

            foreach (Control d in this.Controls)
            {
                if (d is TextBox)
                    d.Text = "";
            }
            pictureBox1.Image = new PictureBox().Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            DialogResult dr = OF.ShowDialog();
            if(dr==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OF.FileName);
            }
            pictureBox1.Image.Save("images/" + txtpatient.Text + ".jpg");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int c = 0; c <= listView1.SelectedItems.Count; c++)
                {
                    if (listView1.SelectedItems.Count > c)
                    {
                        DialogResult dr = MessageBox.Show("do you wanna to delete this data??", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            listView1.Items.Remove(listView1.SelectedItems[c]);
                            if (File.Exists("images"))
                            {
                                string pic = ("images/" + txtpatient.Text + ".jpg");
                                if (File.Exists(pic) == true)
                                    File.Delete(pic);

                            }

                        }
                        foreach (Control s in this.Controls)
                        {
                            if (s is TextBox)
                                s.Text = "";
                        }
                        pictureBox1.Image = new PictureBox().Image;
                    }


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void thePateintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data d = new data();
            d.Show();
        }

        private void aboutTheDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctor d = new doctor();
            d.Show();
        }

        private void theSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales s = new sales();
            s.Show();
        }

        private void txtpatient_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void theApoitmientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservation re = new reservation();
            re.Show();
        }

        private void theAgeAndTheGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medical m = new medical();
            m.Show();
        }

        private void txtpatient_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtdesies.Focus();
            }
        }

        private void txtdesies_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtpatient.Focus();
            }
        }
    }
}
