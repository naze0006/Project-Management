using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class ReportProjectPersonel : Form
    {
        public ReportProjectPersonel()
        {
            InitializeComponent();
        }

        private void ReportProjectPersonel_Load(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
            foreach (project project1 in myData.projects)
                cmbProject.Items.Add(project1.Code);

            cmbProject.SelectedIndex = 0;
        }
        project pr1 = new project(0, "p", "s", "13", 4, 3, "i", 1);
        private void btnShow_Click(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Projectid == Convert.ToInt32(cmbProject.SelectedItem))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}