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
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtdate.Text = dateTimePicker1.Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtdoctor.Text == "" || txtame.Text == "" || comboBox1.Text == "" || txtdate.Text == "" || txtcount.Text == "" || txtphone.Text == "")
                {
                    MessageBox.Show("fill the textboxses first!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdoctor.SelectAll();
                    txtdoctor.Focus();
                    txtame.SelectAll();
                    txtame.Focus();

                }
                else
                {
                    StreamReader sr = new StreamReader("person.txt");
                    String se = sr.ReadToEnd();
                    sr.Close();
                    if (se.Contains(txtame.Text + "-"))
                    {
                        MessageBox.Show("this data has been already added!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtame.SelectAll();
                        txtame.Focus();
                        return;

                    }


                    else
                    {
                        StreamWriter sw = new StreamWriter("person.txt");
                        string SE = txtdoctor.Text + "- "
                                     + txtame.Text + "- "
                                     + comboBox1.Text + "- "
                                     + txtdate.Text + "- "
                                     + txtcount.Text + "- "
                                     + txtphone.Text;
                        MessageBox.Show("your data is added!", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sw.WriteLine(SE);
                        sw.Close();

                    }

                    ListViewItem L = new ListViewItem(txtdoctor.Text);
                    L.SubItems.Add(txtame.Text);
                    L.SubItems.Add(comboBox1.Text);
                    L.SubItems.Add(txtdate.Text);
                    L.SubItems.Add(txtcount.Text);
                    L.SubItems.Add(txtphone.Text);
                    listView1.Items.Add(L);

                }


                foreach (Control s in this.Controls)
                {
                    if (s is TextBox)
                        s.Text = "";
                }
                comboBox1.Text = "";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    MessageBox.Show("your data is edited..", "edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.SelectedItems[0].Text = txtdoctor.Text;
                    listView1.SelectedItems[0].SubItems[1].Text = txtame.Text;
                    listView1.SelectedItems[0].SubItems[2].Text = comboBox1.Text;
                    listView1.SelectedItems[0].SubItems[3].Text = txtdate.Text;
                    listView1.SelectedItems[0].SubItems[4].Text = txtcount.Text;
                    listView1.SelectedItems[0].SubItems[5].Text = txtphone.Text;

                    foreach (Control f in this.Controls)
                    {
                        if (f is TextBox)
                            f.Text = "";
                    }
                    comboBox1.Text = "";
                }
            }catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtdoctor.Text = listView1.SelectedItems[0].Text;
                txtame.Text = listView1.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtdate.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtcount.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtphone.Text = listView1.SelectedItems[0].SubItems[5].Text;
                
            }

            else
            {
                foreach (Control f in this.Controls)
                {
                    if (f is TextBox)
                        f.Text = "";
                }
                comboBox1.Text = "";
            }



        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you wanna to close it??", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("do you wanna to delete it??", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int c = 0; c <= listView1.SelectedItems.Count; c++)
                {
                    if (listView1.SelectedItems.Count > c)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[c]);
                    }
                }
            }

            else
            {
                ListViewItem L = new ListViewItem(txtdoctor.Text);
                L.SubItems.Add(txtame.Text);
                L.SubItems.Add(comboBox1.Text);
                L.SubItems.Add(txtdate.Text);
                L.SubItems.Add(txtcount.Text);
                L.SubItems.Add(txtphone.Text);
                listView1.Items.Add(L);
            }
        }

        private void btndelete_MouseClick(object sender, MouseEventArgs e)
        {
            for (int c = 0; c <= listView1.SelectedItems.Count; c++)
            {
                if (listView1.SelectedItems.Count > c)
                {
                    listView1.Items.Remove(listView1.SelectedItems[c]);
                }
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtame.Text.Trim() != "")
                {
                    StreamReader sr = new StreamReader("person.txt");
                    string serach = "";
                    bool found = false;
                    do
                    {
                        serach = sr.ReadLine();
                        if (serach != null)
                        {
                            string[] data = serach.Split('-');
                            if (txtame.Text == data[1])
                            {
                                txtdoctor.Text = data[0];
                                txtame.Text = data[1];
                                comboBox1.Text = data[2];
                                txtdate.Text = data[3];
                                txtcount.Text = data[4];
                                txtphone.Text = data[5];
                                found = true;
                                break;
                            }
                        }
                    } while (serach != null);
                    sr.Close();

                    if (!found)
                    {
                        MessageBox.Show("not found!!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtame.SelectAll();
                        txtame.Focus();
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtdoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtame.Focus();
            }
        }

        private void txtame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtdate.Focus();
            }
        }

        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtcount.Focus();
            }
        }

        private void txtcount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtphone.Focus();
            }
        }

        private void txtame_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdoctor.Focus();
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtame.Focus();
                comboBox1.Text = "";
            }
        }

        private void txtdate_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                comboBox1.Focus();
            }
        }

        private void txtcount_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdate.Focus();
            }
        }

        private void txtphone_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtcount.Focus();
            }
        }
    }
}
