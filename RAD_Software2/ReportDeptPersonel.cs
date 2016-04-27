using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class ReportDeptPersonel : Form
    {
        public ReportDeptPersonel()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
            int dCode = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Deptid == dCode)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = personel1;
                    item.Text = personel1.ID.ToString();
                    item.SubItems.Add(personel1.Name);
                    item.SubItems.Add(personel1.Karkard.ToString());
                    item.SubItems.Add(personel1.Salary.ToString());
                    listView_Personel.Items.Add(item);
                }
            }
        }
        dept d1 = new dept(1, "s", 1, "s", "a", "12");
        private void ReportDeptPersonel_Load(object sender, EventArgs e)
        {
            foreach (dept d1 in myData.depts)
                cmbBakhsh.Items.Add(d1.Name);

            cmbBakhsh.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}