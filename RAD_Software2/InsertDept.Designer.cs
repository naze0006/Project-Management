namespace RAD_Software2
{
    partial class InsertDept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbResearch = new System.Windows.Forms.RadioButton();
            this.rbImp = new System.Windows.Forms.RadioButton();
            this.rbStudy = new System.Windows.Forms.RadioButton();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Dept = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.rbResearch);
            this.groupBox1.Controls.Add(this.rbImp);
            this.groupBox1.Controls.Add(this.rbStudy);
            this.groupBox1.Controls.Add(this.txtPersonel);
            this.groupBox1.Controls.Add(this.txtTell);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departmens Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(200, 174);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Submit";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rbResearch
            // 
            this.rbResearch.AutoSize = true;
            this.rbResearch.Location = new System.Drawing.Point(145, 142);
            this.rbResearch.Name = "rbResearch";
            this.rbResearch.Size = new System.Drawing.Size(70, 17);
            this.rbResearch.TabIndex = 11;
            this.rbResearch.TabStop = true;
            this.rbResearch.Text = "Research";
            this.rbResearch.UseVisualStyleBackColor = true;
            // 
            // rbImp
            // 
            this.rbImp.AutoSize = true;
            this.rbImp.Location = new System.Drawing.Point(225, 140);
            this.rbImp.Name = "rbImp";
            this.rbImp.Size = new System.Drawing.Size(99, 17);
            this.rbImp.TabIndex = 10;
            this.rbImp.TabStop = true;
            this.rbImp.Text = "Implementation";
            this.rbImp.UseVisualStyleBackColor = true;
            // 
            // rbStudy
            // 
            this.rbStudy.AutoSize = true;
            this.rbStudy.Location = new System.Drawing.Point(335, 140);
            this.rbStudy.Name = "rbStudy";
            this.rbStudy.Size = new System.Drawing.Size(60, 17);
            this.rbStudy.TabIndex = 9;
            this.rbStudy.TabStop = true;
            this.rbStudy.Text = "Studies";
            this.rbStudy.UseVisualStyleBackColor = true;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(362, 20);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(58, 21);
            this.txtPersonel.TabIndex = 8;
            this.txtPersonel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonel_KeyPress);
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(91, 105);
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(100, 21);
            this.txtTell.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(80, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(146, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Feild of activity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(199, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max No. of required personnel:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // listView_Dept
            // 
            this.listView_Dept.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Dept.Location = new System.Drawing.Point(17, 242);
            this.listView_Dept.Name = "listView_Dept";
            this.listView_Dept.Size = new System.Drawing.Size(481, 167);
            this.listView_Dept.TabIndex = 1;
            this.listView_Dept.UseCompatibleStateImageBehavior = false;
            this.listView_Dept.View = System.Windows.Forms.View.Details;
            this.listView_Dept.SelectedIndexChanged += new System.EventHandler(this.listView_Dept_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tell";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Required Personnel";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Field Of Activity";
            this.columnHeader5.Width = 124;
            // 
            // InsertDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 421);
            this.Controls.Add(this.listView_Dept);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertDept";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Department Submition";
            this.Load += new System.EventHandler(this.InsertDept_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbResearch;
        private System.Windows.Forms.RadioButton rbImp;
        private System.Windows.Forms.RadioButton rbStudy;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.TextBox txtTell;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListView listView_Dept;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}