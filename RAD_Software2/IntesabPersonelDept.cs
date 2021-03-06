using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class IntesabPersonelDept : Form
    {
        public IntesabPersonelDept()
        {
            InitializeComponent();
        }
        public static int departmentid = 0;
        dept d1=new dept(1,"s",1,"s","a","12");
        personel p1=new personel(1,"s",1,1,1,1,1,1,1,1,"");
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int deptCode = d1.SearchIDDept(cmbBakhsh.SelectedItem.ToString());
            int PersonelSum = d1.SearchPersonelSum(deptCode);
            int PersonelFindSum = p1.PersonelDeptSum(deptCode);
            if (PersonelFindSum == PersonelSum)
            {
                MessageBox.Show(" Department is full !!!!");
            }
            else
            {
                departmentid = deptCode;
                MessageBox.Show("The selected department for this personnel was confirmed.");
            }
        }

        private void IntesabPersonelDept_Load(object sender, EventArgs e)
        {
            foreach (dept d1 in myData.depts)

                cmbBakhsh.Items.Add(d1.Name);
                cmbBakhsh.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}