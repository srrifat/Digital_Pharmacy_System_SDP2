namespace DigitalPharmacySystem
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicineValidtyChack = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_E_MedicineValidityCheck1 = new DigitalPharmacySystem.EmployeeUC.UC_E_MedicineValidityCheck();
            this.uC_E_UpdateMedicine1 = new DigitalPharmacySystem.EmployeeUC.UC_E_UpdateMedicine();
            this.uC_E_ViewMedicines1 = new DigitalPharmacySystem.EmployeeUC.UC_E_ViewMedicines();
            this.uC_E_AddMedicine1 = new DigitalPharmacySystem.EmployeeUC.UC_E_AddMedicine();
            this.uC_E_Dashbord1 = new DigitalPharmacySystem.EmployeeUC.UC_E_Dashbord();
            this.uC_E_SellMedicine1 = new DigitalPharmacySystem.EmployeeUC.UC_E_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedicineValidtyChack);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 957);
            this.panel1.TabIndex = 1;
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.BorderColor = System.Drawing.Color.LightGray;
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnSellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.CheckedState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSellMedicine.CustomImages.Parent = this.btnSellMedicine;
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.HoverState.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSellMedicine.Location = new System.Drawing.Point(0, 637);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.ShadowDecoration.Parent = this.btnSellMedicine;
            this.btnSellMedicine.Size = new System.Drawing.Size(314, 55);
            this.btnSellMedicine.TabIndex = 10;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnMedicineValidtyChack
            // 
            this.btnMedicineValidtyChack.BorderColor = System.Drawing.Color.LightGray;
            this.btnMedicineValidtyChack.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedicineValidtyChack.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnMedicineValidtyChack.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedicineValidtyChack.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedicineValidtyChack.CheckedState.Parent = this.btnMedicineValidtyChack;
            this.btnMedicineValidtyChack.CustomBorderColor = System.Drawing.Color.Black;
            this.btnMedicineValidtyChack.CustomImages.Parent = this.btnMedicineValidtyChack;
            this.btnMedicineValidtyChack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMedicineValidtyChack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineValidtyChack.ForeColor = System.Drawing.Color.Black;
            this.btnMedicineValidtyChack.HoverState.Parent = this.btnMedicineValidtyChack;
            this.btnMedicineValidtyChack.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicineValidtyChack.Image")));
            this.btnMedicineValidtyChack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedicineValidtyChack.Location = new System.Drawing.Point(0, 576);
            this.btnMedicineValidtyChack.Name = "btnMedicineValidtyChack";
            this.btnMedicineValidtyChack.ShadowDecoration.Parent = this.btnMedicineValidtyChack;
            this.btnMedicineValidtyChack.Size = new System.Drawing.Size(314, 55);
            this.btnMedicineValidtyChack.TabIndex = 9;
            this.btnMedicineValidtyChack.Text = "Medicine Validity Chack ";
            this.btnMedicineValidtyChack.Click += new System.EventHandler(this.btnMedicineValidtyChack_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(448, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1217, 807);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(448, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 948);
            this.panel2.TabIndex = 1;
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BorderColor = System.Drawing.Color.LightGray;
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnViewMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.CheckedState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.CustomBorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.CustomImages.Parent = this.btnViewMedicine;
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.HoverState.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(0, 449);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.ShadowDecoration.Parent = this.btnViewMedicine;
            this.btnViewMedicine.Size = new System.Drawing.Size(314, 55);
            this.btnViewMedicine.TabIndex = 6;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.BorderColor = System.Drawing.Color.LightGray;
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnModifyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.CheckedState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.CustomBorderColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.CustomImages.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.HoverState.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModifyMedicine.Location = new System.Drawing.Point(0, 510);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.ShadowDecoration.Parent = this.btnModifyMedicine;
            this.btnModifyMedicine.Size = new System.Drawing.Size(314, 55);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.LightGray;
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomBorderColor = System.Drawing.Color.Black;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(0, 698);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(314, 52);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BorderColor = System.Drawing.Color.LightGray;
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnAddMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.CheckedState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.CustomImages.Parent = this.btnAddMedicine;
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.HoverState.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddMedicine.Location = new System.Drawing.Point(0, 388);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.ShadowDecoration.Parent = this.btnAddMedicine;
            this.btnAddMedicine.Size = new System.Drawing.Size(314, 53);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderColor = System.Drawing.Color.LightGray;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(80, 80);
            this.btnDashboard.Location = new System.Drawing.Point(-5, 331);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(319, 51);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(81, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_E_MedicineValidityCheck1
            // 
            this.uC_E_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_E_MedicineValidityCheck1.Location = new System.Drawing.Point(319, -2);
            this.uC_E_MedicineValidityCheck1.Name = "uC_E_MedicineValidityCheck1";
            this.uC_E_MedicineValidityCheck1.Size = new System.Drawing.Size(1180, 807);
            this.uC_E_MedicineValidityCheck1.TabIndex = 6;
            // 
            // uC_E_UpdateMedicine1
            // 
            this.uC_E_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_E_UpdateMedicine1.Location = new System.Drawing.Point(309, 0);
            this.uC_E_UpdateMedicine1.Name = "uC_E_UpdateMedicine1";
            this.uC_E_UpdateMedicine1.Size = new System.Drawing.Size(1180, 807);
            this.uC_E_UpdateMedicine1.TabIndex = 5;
            // 
            // uC_E_ViewMedicines1
            // 
            this.uC_E_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_E_ViewMedicines1.Location = new System.Drawing.Point(318, -3);
            this.uC_E_ViewMedicines1.Name = "uC_E_ViewMedicines1";
            this.uC_E_ViewMedicines1.Size = new System.Drawing.Size(1180, 807);
            this.uC_E_ViewMedicines1.TabIndex = 4;
            // 
            // uC_E_AddMedicine1
            // 
            this.uC_E_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_E_AddMedicine1.Location = new System.Drawing.Point(309, 3);
            this.uC_E_AddMedicine1.Name = "uC_E_AddMedicine1";
            this.uC_E_AddMedicine1.Size = new System.Drawing.Size(1203, 807);
            this.uC_E_AddMedicine1.TabIndex = 3;
            // 
            // uC_E_Dashbord1
            // 
            this.uC_E_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_E_Dashbord1.Location = new System.Drawing.Point(318, 0);
            this.uC_E_Dashbord1.Name = "uC_E_Dashbord1";
            this.uC_E_Dashbord1.Size = new System.Drawing.Size(1194, 805);
            this.uC_E_Dashbord1.TabIndex = 2;
            // 
            // uC_E_SellMedicine1
            // 
            this.uC_E_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_E_SellMedicine1.Location = new System.Drawing.Point(309, 0);
            this.uC_E_SellMedicine1.Name = "uC_E_SellMedicine1";
            this.uC_E_SellMedicine1.Size = new System.Drawing.Size(1203, 807);
            this.uC_E_SellMedicine1.TabIndex = 7;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 807);
            this.Controls.Add(this.uC_E_SellMedicine1);
            this.Controls.Add(this.uC_E_MedicineValidityCheck1);
            this.Controls.Add(this.uC_E_UpdateMedicine1);
            this.Controls.Add(this.uC_E_ViewMedicines1);
            this.Controls.Add(this.uC_E_AddMedicine1);
            this.Controls.Add(this.uC_E_Dashbord1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedicineValidtyChack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private EmployeeUC.UC_E_Dashbord uC_E_Dashbord1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private EmployeeUC.UC_E_AddMedicine uC_E_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private EmployeeUC.UC_E_ViewMedicines uC_E_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private EmployeeUC.UC_E_UpdateMedicine uC_E_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private EmployeeUC.UC_E_MedicineValidityCheck uC_E_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private EmployeeUC.UC_E_SellMedicine uC_E_SellMedicine1;
    }
}