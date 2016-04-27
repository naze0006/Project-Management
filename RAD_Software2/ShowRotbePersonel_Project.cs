using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class ShowRotbePersonel_Project : Form
    {
        public ShowRotbePersonel_Project()
        {
            InitializeComponent();
        }

        private void ShowRotbePersonel_Project_Load(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
            foreach (project project1 in myData.projects)
                cmbProject.Items.Add(project1.Code);

            cmbProject.SelectedIndex = 0;
        }
      
        private void btnShow_Click(object sender, EventArgs e)
        {
            listView_Personel.Items.Clear();
          
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Projectid ==Convert.ToInt32(cmbProject.SelectedItem))
                {
                    int rotbe = personel1.RotbeCalculation(personel1.ID, personel1.Type);
                    ListViewItem item = new ListViewItem();
                    item.Tag = personel1;
                    item.Text = personel1.ID.ToString();
                    item.SubItems.Add(personel1.Name);
                    item.SubItems.Add(rotbe.ToString());
                    listView_Personel.Items.Add(item);
                }
            }
        }

        private void listView_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}