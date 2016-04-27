using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class ShowPersonelRotbe_Dept : Form
    {
        public ShowPersonelRotbe_Dept()
        {
            InitializeComponent();
        }

        private void ShowPersonelRotbe_Dept_Load(object sender, EventArgs e)
        {
            foreach (dept d1 in myData.depts)
                cmbBakhsh.Items.Add(d1.Name);
            cmbBakhsh.SelectedIndex = 0;
           
        }
        dept d1 = new dept(1, "s", 1, "s", "a", "12");
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            listView_Personel.Items.Clear();
            int dCode = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());
            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Deptid == dCode)
                {
                    int rotbe=personel1.RotbeCalculation(personel1.ID,personel1.Type);
                    ListViewItem item = new ListViewItem();
                    item.Tag = personel1;
                    item.Text = personel1.ID.ToString();
                    item.SubItems.Add(personel1.Name);
                    item.SubItems.Add(rotbe.ToString());
                    listView_Personel.Items.Add(item);
                }
            }
        }
    }
}