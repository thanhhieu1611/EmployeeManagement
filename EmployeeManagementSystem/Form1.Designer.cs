namespace EmployeeManagementSystem
{
    partial class FormEMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEMS));
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxEmployeeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmpInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.Location = new System.Drawing.Point(43, 40);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(164, 316);
            this.listBoxEmployee.TabIndex = 0;
            this.listBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee:";
            // 
            // comBoxEmployeeType
            // 
            this.comBoxEmployeeType.FormattingEnabled = true;
            this.comBoxEmployeeType.Location = new System.Drawing.Point(237, 40);
            this.comBoxEmployeeType.Name = "comBoxEmployeeType";
            this.comBoxEmployeeType.Size = new System.Drawing.Size(121, 21);
            this.comBoxEmployeeType.TabIndex = 2;
            this.comBoxEmployeeType.SelectedIndexChanged += new System.EventHandler(this.comBoxEmployeeType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Type:";
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveEmp.Location = new System.Drawing.Point(237, 333);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEmp.TabIndex = 4;
            this.btnRemoveEmp.Text = "Remove";
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Information:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Written by: HD\r\nDate: 09/17/2020";
            // 
            // txtBoxEmpInfo
            // 
            this.txtBoxEmpInfo.Location = new System.Drawing.Point(237, 94);
            this.txtBoxEmpInfo.Multiline = true;
            this.txtBoxEmpInfo.Name = "txtBoxEmpInfo";
            this.txtBoxEmpInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEmpInfo.Size = new System.Drawing.Size(230, 233);
            this.txtBoxEmpInfo.TabIndex = 8;
            // 
            // FormEMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 395);
            this.Controls.Add(this.txtBoxEmpInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBoxEmployeeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEMS";
            this.Text = "EMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxEmployeeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmpInfo;
    }
}

