using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class ReportDeptProject : Form
    {
        public ReportDeptProject()
        {
            InitializeComponent();
        }

        private void ReportDeptProject_Load(object sender, EventArgs e)
        {
            listView_Project.Items.Clear();
            foreach (dept d1 in myData.depts)
                cmbBakhsh.Items.Add(d1.Name);

            cmbBakhsh.SelectedIndex = 0;
        }
        dept d1 = new dept(1, "s", 1, "s", "a", "12");
        private void btnShow_Click(object sender, EventArgs e)
        {
            listView_Project.Items.Clear();
            int dCode = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());
            foreach (project project1 in myData.projects)
            {
                if (project1.Deptid == dCode)
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}