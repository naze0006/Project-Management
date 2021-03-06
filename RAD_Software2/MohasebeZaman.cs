using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class MohasebeZaman : Form
    {
        public MohasebeZaman()
        {
            InitializeComponent();
        }

        private void MohasebeZaman_Load(object sender, EventArgs e)
        {
            foreach (project project1 in myData.projects)
                cmbProject.Items.Add(project1.Code);

            cmbProject.SelectedIndex = 0;
        }
        personel p1 = new personel(1, "s", 1, 1, 1, 1, 0, 0, 0, 0, "");
        project pr1 = new project(0, "p", "s", "13", 4, 3, "i", 1);
        private void button1_Click(object sender, EventArgs e)
        {
            int PersonelSum = p1.SumofKarkard(Convert.ToInt32(cmbProject.SelectedItem));
            int ProjectSum = pr1.SearchHoure(Convert.ToInt32(cmbProject.SelectedItem));
            if (PersonelSum != 0)
            {
                float sum = ProjectSum / PersonelSum;
                txtMah.Text =sum.ToString();

            }
            else
            {
                MessageBox.Show("Nobody has been registered for this project.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}