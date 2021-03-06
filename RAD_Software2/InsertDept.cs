using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class InsertDept : Form
    {
        public InsertDept()
        {
            InitializeComponent();
        }

        private void InsertDept_Load(object sender, EventArgs e)
        {
            rbStudy.Checked = true;
            foreach (dept dept1 in myData.depts)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = dept1;
                item.Text = dept1.Name;
                item.SubItems.Add(dept1.Address);
                item.SubItems.Add(dept1.Tell);
                item.SubItems.Add(dept1.Personel.ToString());
                item.SubItems.Add(dept1.Major);
                listView_Dept.Items.Add(item);
            }
        }
        public static int id = 1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string major1;
            
            if (txtName.Text != "")
            {
                if (txtAddress.Text != "" && txtTell.Text != "")
                {
                    if (txtPersonel.Text != "")
                    {
                        if (rbStudy.Checked == true)
                            major1 = "studies";
                        else if (rbResearch.Checked == true)
                            major1 = "research";
                        else
                            major1 = "implementation";
                        dept d1 = new dept(++id, txtName.Text.Trim(), Convert.ToInt32(txtPersonel.Text), major1, txtAddress.Text.Trim(), txtTell.Text.Trim());
                        myData.depts.Add(d1);

                        ListViewItem item = new ListViewItem(d1.Name);
                        item.SubItems.Add(d1.Address);
                        item.SubItems.Add(d1.Tell);
                        item.SubItems.Add(d1.Personel.ToString());
                        item.SubItems.Add(d1.Major);
                        listView_Dept.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Please insert the number of required personnel.");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert the address and the telephone number.");
                }
            }
            else
            {
                MessageBox.Show("Please insert the name.");
            }
        }

        private void txtPersonel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}