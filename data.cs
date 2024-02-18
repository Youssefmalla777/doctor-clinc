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
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data m = new data();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // txtdate.Text = dateTimePicker1.Text.ToString();
            txtdate.Text = dateTimePicker1.Value.ToString();
        }

        private void btnreview_Click(object sender, EventArgs e)
        {
            txtreview.Text = dateTimePicker2.Value.ToString();
        }

        private void data_Load(object sender, EventArgs e)
        {
            Point p1 = new Point(1, 100);
            Point p2 = new Point(600, 100);
            Point[] all = { p1, p2 };
            this.CreateGraphics().DrawLines(Pens.Black, all);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           try
            {
                if(txtaddress.Text == "" || txtage.Text == "" || txtdate.Text == "" || txtdisease.Text == "" || txtnotes.Text == "" ||txtpatient.Text == "" || txtreview.Text == "")
                {
                    MessageBox.Show("fill the textboxses first!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StreamReader sr = new StreamReader("data.txt");
                string check = sr.ReadToEnd();
                sr.Close();
                if (check.Contains(txtpatient.Text + "-"))
                {
                    MessageBox.Show("this data is already added!!", "add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpatient.SelectAll();
                    txtpatient.Focus();

                }

                else
                {
                    StreamWriter sw = new StreamWriter("data.txt",true);
                    string strdata = txtdate.Text + "- "
                                    + txtreview.Text + "- "
                                    + txtdoctor.Text + "- "
                                    + txtpatient.Text + "- "
                                    + txtdisease.Text + "- "
                                    + txtage.Text + "- "
                                    + txtaddress.Text + "- "
                                    + combogender.Text + "- "
                                    + txtnotes.Text;
                    MessageBox.Show("your data is added..", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.WriteLine(strdata);
                    sw.Close();
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                            c.Text = "";
                    }
                    combogender.Text = "";

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
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
           foreach(Control w in this.Controls)
            {
                if (w is TextBox)
                    w.Text = "";
            }
            combogender.Text = "";
            if(checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else if(checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            else if(checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox4.Checked = false;
            }

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if(txtpatient.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("data.txt");
                string youssef = "";
                bool found = false;
                do
                {
                    youssef = sr.ReadLine();
                    if(youssef != null)
                    {
                        string[] data = youssef.Split('-');
                        if(txtpatient.Text == data[3])
                        {
                            txtdate.Text = data[0];
                            txtreview.Text = data[1];
                            txtdoctor.Text = data[2];
                            txtpatient.Text = data[3];
                            txtage.Text = data[4];
                            txtdisease.Text = data[5];
                            txtaddress.Text = data[6];
                            combogender.Text = data[7];
                            txtnotes.Text = data[8];
                            found = true;
                            break;
                        }
                    }
                } while (youssef != null);
                sr.Close();

                if(found == false)
                {
                    MessageBox.Show("not found!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpatient.SelectAll();
                    txtpatient.Focus();
                }
            }

            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int top = 0;
            Form frm = new Form();
            TextBox t = new TextBox();
            frm.TopLevel = true;
            frm.Name = "noor";
            frm.Size = this.Size;
            frm.TopMost = true;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.BackColor = ScrollBar.DefaultBackColor;
            frm.Text = "all the data";
            frm.AutoScroll = true;
            frm.AutoSize = true;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.AllowDrop = true;
            frm.SizeGripStyle = SizeGripStyle.Show;
            frm.Icon = this.Icon;
            frm.Activate();
            frm.ShowIcon = true;
            
            t.Multiline = true;
            t.Top = top;
            t.BackColor = Color.Beige;
            t.Cursor = Cursors.IBeam;
            t.BorderStyle = BorderStyle.None;
            t.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            t.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            t.Dock = DockStyle.Fill;
            t.ForeColor = Color.Black;
            t.Size = new Size(50, 50);
            t.Font = this.Font;
            
            frm.Controls.Add(t);
            StreamReader sr = new StreamReader("data.txt");
            string sw = sr.ReadToEnd();
            t.Text = sw;
            sr.Close();
           
            frm.ShowDialog();
            DialogResult dr = MessageBox.Show("do you wanna to save the edit??", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sv.FileName = t.Text;
                dr = sv.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    StreamWriter ss = new StreamWriter(sv.FileName);
                    ss.WriteLine(t.Text);
                    ss.Close();

                }
            }

            else
            {
                frm.Close();
            }
        }


        private void txtdate_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtreview.Focus();
            }
        }

        private void txtreview_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtdoctor.Focus();
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
                txtage.Focus();
            }
        }

        private void txtage_KeyDown(object sender, KeyEventArgs e)
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
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyUp(object sender, KeyEventArgs e)
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
                txtage.Focus();
            }
        }

        private void txtage_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtpatient.Focus();
            }
        }

        private void txtpatient_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdoctor.Focus();
            }
        }

        private void txtdoctor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtreview.Focus();
            }
        }

        private void txtreview_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtdate.Focus();
            }
        }
    }
}
