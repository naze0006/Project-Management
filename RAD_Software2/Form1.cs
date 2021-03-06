using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAD_Software2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ثبتبخشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertDept().Show();
        }

        private void ثبتپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertPersonel().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void ثبتپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertProject().Show();
        }

        private void انتسابپرسنلبهپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EntesabPersonelProject().Show();
        }

        private void مشاهدهلیستپرسنلهربخشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportDeptPersonel().Show();
        }

        private void مشاهدهلیستیازپروژههایواگذارشدهبههربخشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportDeptProject().Show();
        }

        private void مشاهدهلیستیازپرسنلشرکتکنندهدرهرپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportProjectPersonel().Show();
        }

        private void محاسبهوتخمینزمانانجامیکپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MohasebeZaman().Show();
        }

        private void نمایشلیستیازپرسنلهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowPersonelRotbe_Dept().Show();
        }

        private void نمایشلیستپرسنلهابههمراهحقوقدرهربخشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowSalaryPersonel_Dept().Show();
        }

        private void نمایشپرسنلبابالاترینرتبهدرهربخشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SelectRotbe_Dept().Show();
        }

        private void نمایشلیستیازپرسنلهابههمراهرتبهدرهرپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowRotbePersonel_Project().Show();
        }

        private void نمایشپرسنلبابالاترینرتبهدرهرپروژهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SelectRotbe_Project().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}