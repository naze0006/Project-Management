namespace RAD_Software2
{
    partial class InsertProject
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtTarikh = new System.Windows.Forms.TextBox();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.rbResearch = new System.Windows.Forms.RadioButton();
            this.rbImp = new System.Windows.Forms.RadioButton();
            this.rbStudy = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Project = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Controls.Add(this.txtTarikh);
            this.groupBox1.Controls.Add(this.txtPersonel);
            this.groupBox1.Controls.Add(this.txtSub);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.rbResearch);
            this.groupBox1.Controls.Add(this.rbImp);
            this.groupBox1.Controls.Add(this.rbStudy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(659, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projects Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(544, 171);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Submit";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Year/Month/Day";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(273, 74);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(77, 21);
            this.txtHour.TabIndex = 20;
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHour_KeyPress);
            // 
            // txtTarikh
            // 
            this.txtTarikh.Location = new System.Drawing.Point(325, 31);
            this.txtTarikh.Name = "txtTarikh";
            this.txtTarikh.Size = new System.Drawing.Size(100, 21);
            this.txtTarikh.TabIndex = 19;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(191, 157);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(73, 21);
            this.txtPersonel.TabIndex = 18;
            this.txtPersonel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonel_KeyPress);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(74, 114);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(100, 21);
            this.txtSub.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 16;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(86, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(84, 21);
            this.txtCode.TabIndex = 15;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // rbResearch
            // 
            this.rbResearch.AutoSize = true;
            this.rbResearch.Location = new System.Drawing.Point(273, 115);
            this.rbResearch.Name = "rbResearch";
            this.rbResearch.Size = new System.Drawing.Size(70, 17);
            this.rbResearch.TabIndex = 14;
            this.rbResearch.TabStop = true;
            this.rbResearch.Text = "Research";
            this.rbResearch.UseVisualStyleBackColor = true;
            // 
            // rbImp
            // 
            this.rbImp.AutoSize = true;
            this.rbImp.Location = new System.Drawing.Point(346, 115);
            this.rbImp.Name = "rbImp";
            this.rbImp.Size = new System.Drawing.Size(99, 17);
            this.rbImp.TabIndex = 13;
            this.rbImp.TabStop = true;
            this.rbImp.Text = "Implementation";
            this.rbImp.UseVisualStyleBackColor = true;
            // 
            // rbStudy
            // 
            this.rbStudy.AutoSize = true;
            this.rbStudy.Location = new System.Drawing.Point(448, 115);
            this.rbStudy.Name = "rbStudy";
            this.rbStudy.Size = new System.Drawing.Size(60, 17);
            this.rbStudy.TabIndex = 12;
            this.rbStudy.TabStop = true;
            this.rbStudy.Text = "Studies";
            this.rbStudy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kind of project:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Required Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of start the project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of required personnel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView_Project
            // 
            this.listView_Project.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Project.Location = new System.Drawing.Point(12, 246);
            this.listView_Project.Name = "listView_Project";
            this.listView_Project.Size = new System.Drawing.Size(659, 158);
            this.listView_Project.TabIndex = 1;
            this.listView_Project.UseCompatibleStateImageBehavior = false;
            this.listView_Project.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personnel ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Number of Required Personnel";
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date of Start";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Required Time";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kind of Project";
            this.columnHeader7.Width = 90;
            // 
            // InsertProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 416);
            this.Controls.Add(this.listView_Project);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Project Regirstration";
            this.Load += new System.EventHandler(this.InsertProject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarikh;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.RadioButton rbResearch;
        private System.Windows.Forms.RadioButton rbImp;
        private System.Windows.Forms.RadioButton rbStudy;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ListView listView_Project;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}