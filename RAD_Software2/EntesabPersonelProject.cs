using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class EntesabPersonelProject : Form
    {
        public EntesabPersonelProject()
        {
            InitializeComponent();
        }

        private void EntesabPersonelProject_Load(object sender, EventArgs e)
        {
            try { lbProject.SelectedIndex = 0; lbPersonel.SelectedIndex = 0; }
            catch{}
            lbProject.Items.Clear();
            lbPersonel.Items.Clear();
            foreach (dept d1 in myData.depts)
                cmbBakhsh.Items.Add(d1.Name);

            cmbBakhsh.SelectedIndex = 0;
        }
        dept d1 = new dept(1, "s", 1, "s", "a", "12");
        private void cmbBakhsh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lbProject.Items.Clear();
            lbPersonel.Items.Clear();
           
            int DeptNum = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());

            foreach (personel personel1 in myData.personels)
            {
                if (personel1.Deptid == DeptNum)
                {
                    lbPersonel.Items.Add(personel1.Name);

                }
            }
            

            foreach (project project1 in myData.projects)
            {
                if (project1.Deptid==DeptNum)
                {
                    lbProject.Items.Add(project1.Code);

                }
            }
            
        }
        personel p1 = new personel(1, "s", 1, 1, 1, 1,0,0,0,0,"");
        project pr1 = new project(0, "p", "s", "13", 4, 3, "i", 1);
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int PersonelSum=pr1.SearchProjectPersonel(Convert.ToInt32(lbProject.SelectedItem));
            int sum = p1.SearchSumPersonelProject(Convert.ToInt32(lbProject.SelectedItem));
            if (sum == PersonelSum)
            {
                MessageBox.Show("This project is full.");
            }
            else
            {
                foreach (personel personel1 in myData.personels)
                {
                    if (personel1.Name == lbPersonel.SelectedItem.ToString())
                    {
                        personel1.Projectid = Convert.ToInt32(lbProject.SelectedItem);
                        MessageBox.Show("Registration was confirmed.");
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}