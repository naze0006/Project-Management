namespace RAD_Software2
{
    partial class EntesabPersonelProject
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
            this.cmbBakhsh = new System.Windows.Forms.ComboBox();
            this.lbPersonel = new System.Windows.Forms.ListBox();
            this.lbProject = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.cmbBakhsh);
            this.groupBox1.Controls.Add(this.lbPersonel);
            this.groupBox1.Controls.Add(this.lbProject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please choose the project and assign it to the personnel:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(247, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 29);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Submit";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbBakhsh
            // 
            this.cmbBakhsh.FormattingEnabled = true;
            this.cmbBakhsh.Location = new System.Drawing.Point(111, 49);
            this.cmbBakhsh.Name = "cmbBakhsh";
            this.cmbBakhsh.Size = new System.Drawing.Size(162, 21);
            this.cmbBakhsh.TabIndex = 5;
            this.cmbBakhsh.SelectedIndexChanged += new System.EventHandler(this.cmbBakhsh_SelectedIndexChanged);
            // 
            // lbPersonel
            // 
            this.lbPersonel.FormattingEnabled = true;
            this.lbPersonel.Location = new System.Drawing.Point(380, 115);
            this.lbPersonel.Name = "lbPersonel";
            this.lbPersonel.Size = new System.Drawing.Size(174, 121);
            this.lbPersonel.TabIndex = 4;
            this.lbPersonel.SelectedIndexChanged += new System.EventHandler(this.lbPersonel_SelectedIndexChanged);
            // 
            // lbProject
            // 
            this.lbProject.FormattingEnabled = true;
            this.lbProject.Location = new System.Drawing.Point(147, 115);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(91, 121);
            this.lbProject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department\'s personnels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department\'s projects:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department:";
            // 
            // EntesabPersonelProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 382);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntesabPersonelProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Assign Personnel to Project";
            this.Load += new System.EventHandler(this.EntesabPersonelProject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBakhsh;
        private System.Windows.Forms.ListBox lbPersonel;
        private System.Windows.Forms.ListBox lbProject;
        private System.Windows.Forms.Button btnInsert;
    }
}