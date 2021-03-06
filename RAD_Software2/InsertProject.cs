using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class InsertProject : Form
    {
        public InsertProject()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string major1;
            if (txtCode.Text != "")
            {
                if (txtName.Text != "")
                {
                    if (txtSub.Text != "")
                    {
                        if (txtPersonel.Text != "")
                        {
                            if (txtTarikh.Text != "")
                            {
                                new EntesabProjectDept().ShowDialog();
                                if(rbStudy.Checked==true)
                                    major1="studies";
                                else if(rbResearch.Checked==true)
                                    major1="research";
                                else
                                    major1="implementation";

                                int DepCode = EntesabProjectDept.DepartCode;
                                if (DepCode != 0)
                                {
                                    
                                    project p1 = new project(Convert.ToInt32(txtCode.Text), txtName.Text.Trim(), txtSub.Text.Trim(), txtTarikh.Text.Trim(),Convert.ToInt32(txtHour.Text),Convert.ToInt32(txtPersonel.Text),major1,DepCode);
                                    myData.projects.Add(p1);

                                    /////show in listview
                                    ListViewItem item = new ListViewItem(p1.Code.ToString());
                                    item.SubItems.Add(p1.Name);
                                    item.SubItems.Add(p1.Subject);
                                    item.SubItems.Add(p1.Personel.ToString());
                                    item.SubItems.Add(p1.Tarikh.ToString());
                                    item.SubItems.Add(p1.Hourse.ToString());
                                    item.SubItems.Add(p1.Major);
                                    listView_Project.Items.Add(item);

                                }
                                else
                                {
                                    MessageBox.Show("Please choose the department.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please insert the date.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert the number of personnel.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose the subject.");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert the name.");
                }
            }
            else
            {
                MessageBox.Show("Please insert the code.");
            }
        }

        private void InsertProject_Load(object sender, EventArgs e)
        {
            rbStudy.Checked = true;
            foreach (project project1 in myData.projects)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = project1;
                item.Text = project1.Code.ToString();
                item.SubItems.Add(project1.Name);
                item.SubItems.Add(project1.Subject);
                item.SubItems.Add(project1.Personel.ToString());
                item.SubItems.Add(project1.Tarikh.ToString());
                item.SubItems.Add(project1.Hourse.ToString());
                item.SubItems.Add(project1.Major);
                listView_Project.Items.Add(item);
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}