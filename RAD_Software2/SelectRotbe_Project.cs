using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class SelectRotbe_Project : Form
    {
        public SelectRotbe_Project()
        {
            InitializeComponent();
        }

        private void SelectRotbe_Project_Load(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
            foreach (project project1 in myData.projects)
                cmbProject.Items.Add(project1.Code);

            cmbProject.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int Max = 0;
            int perId = -1;
            listView_Personel.Items.Clear();
           
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Projectid ==Convert.ToInt32(cmbProject.SelectedItem))
                {
                    int rotbe = personel1.RotbeCalculation(personel1.ID, personel1.Type);
                    if (rotbe > Max)
                    {
                        Max = rotbe;
                        perId = personel1.ID;
                    }
                }
            }
            MessageBox.Show("Highest rank in this project is  " + Max.ToString());
            foreach (personel personel2 in myData.personels)
            {
                if (personel2.ID == perId)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = personel2;
                    item.Text = personel2.ID.ToString();
                    item.SubItems.Add(personel2.Name);
                    item.SubItems.Add(personel2.Karkard.ToString());
                    item.SubItems.Add(personel2.Salary.ToString());
                    if (personel2.Bsalary == -1)
                        item.SubItems.Add("");
                    else
                        item.SubItems.Add(personel2.Bsalary.ToString());
                    item.SubItems.Add(personel2.Article.ToString());
                    if (personel2.Workcount == -1)
                        item.SubItems.Add("");
                    else
                        item.SubItems.Add(personel2.Workcount.ToString());
                    if (personel2.TeachCount == -1)
                        item.SubItems.Add("");
                    else
                        item.SubItems.Add(personel2.TeachCount.ToString());
                    item.SubItems.Add(personel2.Type);
                    listView_Personel.Items.Add(item);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}