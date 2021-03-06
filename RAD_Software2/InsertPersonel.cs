using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class InsertPersonel : Form
    {
        public InsertPersonel()
        {
            InitializeComponent();
        }

        private void InsertPersonel_Load(object sender, EventArgs e)
        {
            foreach (personel personel1 in myData.personels)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = personel1;
                item.Text = personel1.ID.ToString();
                item.SubItems.Add(personel1.Name);
                item.SubItems.Add(personel1.Karkard.ToString());
                item.SubItems.Add(personel1.Salary.ToString());
                if (personel1.Bsalary == -1)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(personel1.Bsalary.ToString());
                item.SubItems.Add(personel1.Article.ToString());
                if (personel1.Workcount == -1)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(personel1.Workcount.ToString());
                if (personel1.TeachCount == -1)
                    item.SubItems.Add("");
                else
                    item.SubItems.Add(personel1.TeachCount.ToString());
                item.SubItems.Add(personel1.Type);
                listView_Personel.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int wcount = -1;
            int tcount = -1;
            int bsal = -1;
            string tp="";
            if (txtNum.Text != "")
            {
                if (txtName.Text != "")
                {
                    if (txtKarkard.Text != "" && txtSalary.Text != "")
                    {
                        if (txtArticle.Text != "")
                        {
                            new IntesabPersonelDept().ShowDialog();
                            if (IntesabPersonelDept.departmentid != 0)
                            {
                                if (txtWork.Text != "")
                                    wcount = Convert.ToInt32(txtWork.Text);
                                if (txtTeach.Text != "")
                                    tcount = Convert.ToInt32(txtTeach.Text);
                                if (txtBSalary.Text != "")
                                    bsal = Convert.ToInt32(txtBSalary.Text);
                                if (rbMohaghegh.Checked == true)
                                    tp = "Researcher";
                                else
                                    tp = "Apprentice";
                                personel p1 = new personel(Convert.ToInt32(txtNum.Text), txtName.Text.Trim(), IntesabPersonelDept.departmentid, -1, Convert.ToInt32(txtKarkard.Text), Convert.ToInt32(txtSalary.Text),bsal,Convert.ToInt32(txtArticle.Text),wcount,tcount,tp);
                                myData.personels.Add(p1);
                                ////////show in list view

                                ListViewItem item = new ListViewItem(p1.ID.ToString());
                                item.SubItems.Add(p1.Name);
                                item.SubItems.Add(p1.Karkard.ToString());
                                item.SubItems.Add(p1.Salary.ToString());
                                if (p1.Bsalary == -1)
                                    item.SubItems.Add("");
                                else
                                    item.SubItems.Add(p1.Bsalary.ToString());
                                item.SubItems.Add(p1.Article.ToString());
                                if (p1.Workcount == -1)
                                    item.SubItems.Add("");
                                else
                                    item.SubItems.Add(p1.Workcount.ToString());
                                if (p1.TeachCount == -1)
                                    item.SubItems.Add("");
                                else
                                    item.SubItems.Add(p1.TeachCount.ToString());
                                item.SubItems.Add(p1.Type);

                                listView_Personel.Items.Add(item);
                            }

                            else
                            {
                                MessageBox.Show("Please choose the department of this personnel.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please insert number of publication.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please insert function and sallary.");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert the name.");
                }
            }
            else
            {
                MessageBox.Show("Please insert the personnel ID.");
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtKarkard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}