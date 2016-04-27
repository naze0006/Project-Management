using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class EntesabProjectDept : Form
    {
        public EntesabProjectDept()
        {
            InitializeComponent();
        }

        private void EntesabProjectDept_Load(object sender, EventArgs e)
        {
            foreach (dept d1 in myData.depts)
                cmbBakhsh.Items.Add(d1.Name);
              
            cmbBakhsh.SelectedIndex = 0;
        }
        dept d1 = new dept(1, "s", 1, "s", "a", "12");
        public static int DepartCode = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int deptid = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());
            DepartCode = deptid;
            MessageBox.Show("This department for this project was confirmed.");
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}