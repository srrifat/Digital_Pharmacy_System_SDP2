namespace DigitalPharmacySystem.EmployeeUC
{
    partial class UC_E_UpdateMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_E_UpdateMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtMediID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMediName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvailableQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.laere = new System.Windows.Forms.Label();
            this.txtMDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dsada = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Medicine";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicine ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtMediID
            // 
            this.txtMediID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediID.DefaultText = "";
            this.txtMediID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.DisabledState.Parent = this.txtMediID;
            this.txtMediID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.FocusedState.Parent = this.txtMediID;
            this.txtMediID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediID.ForeColor = System.Drawing.Color.Black;
            this.txtMediID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediID.HoverState.Parent = this.txtMediID;
            this.txtMediID.Location = new System.Drawing.Point(52, 234);
            this.txtMediID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMediID.Name = "txtMediID";
            this.txtMediID.PasswordChar = '\0';
            this.txtMediID.PlaceholderText = "";
            this.txtMediID.SelectedText = "";
            this.txtMediID.ShadowDecoration.Parent = this.txtMediID;
            this.txtMediID.Size = new System.Drawing.Size(416, 45);
            this.txtMediID.TabIndex = 4;
            this.txtMediID.TextChanged += new System.EventHandler(this.txtMediID_TextChanged);
            // 
            // txtMediName
            // 
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.DefaultText = "";
            this.txtMediName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.DisabledState.Parent = this.txtMediName;
            this.txtMediName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.FocusedState.Parent = this.txtMediName;
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.ForeColor = System.Drawing.Color.Black;
            this.txtMediName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediName.HoverState.Parent = this.txtMediName;
            this.txtMediName.Location = new System.Drawing.Point(52, 368);
            this.txtMediName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.PlaceholderText = "";
            this.txtMediName.SelectedText = "";
            this.txtMediName.ShadowDecoration.Parent = this.txtMediName;
            this.txtMediName.Size = new System.Drawing.Size(416, 45);
            this.txtMediName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicine Name";
            // 
            // txtMediNumber
            // 
            this.txtMediNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediNumber.DefaultText = "";
            this.txtMediNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMediNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMediNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.DisabledState.Parent = this.txtMediNumber;
            this.txtMediNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMediNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.FocusedState.Parent = this.txtMediNumber;
            this.txtMediNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMediNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMediNumber.HoverState.Parent = this.txtMediNumber;
            this.txtMediNumber.Location = new System.Drawing.Point(52, 480);
            this.txtMediNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMediNumber.Name = "txtMediNumber";
            this.txtMediNumber.PasswordChar = '\0';
            this.txtMediNumber.PlaceholderText = "";
            this.txtMediNumber.SelectedText = "";
            this.txtMediNumber.ShadowDecoration.Parent = this.txtMediNumber;
            this.txtMediNumber.Size = new System.Drawing.Size(416, 45);
            this.txtMediNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medicine Number";
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvailableQuantity.DefaultText = "";
            this.txtAvailableQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAvailableQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAvailableQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.DisabledState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAvailableQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.FocusedState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAvailableQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAvailableQuantity.HoverState.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Location = new System.Drawing.Point(662, 340);
            this.txtAvailableQuantity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.PasswordChar = '\0';
            this.txtAvailableQuantity.PlaceholderText = "";
            this.txtAvailableQuantity.SelectedText = "";
            this.txtAvailableQuantity.ShadowDecoration.Parent = this.txtAvailableQuantity;
            this.txtAvailableQuantity.Size = new System.Drawing.Size(416, 45);
            this.txtAvailableQuantity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Available Quantity";
            // 
            // txtAddQuantity
            // 
            this.txtAddQuantity.BorderColor = System.Drawing.Color.Lime;
            this.txtAddQuantity.BorderThickness = 3;
            this.txtAddQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddQuantity.DefaultText = "0";
            this.txtAddQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuantity.DisabledState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuantity.FocusedState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtAddQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuantity.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddQuantity.HoverState.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Location = new System.Drawing.Point(917, 415);
            this.txtAddQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.PasswordChar = '\0';
            this.txtAddQuantity.PlaceholderText = "";
            this.txtAddQuantity.SelectedText = "";
            this.txtAddQuantity.SelectionStart = 1;
            this.txtAddQuantity.ShadowDecoration.Parent = this.txtAddQuantity;
            this.txtAddQuantity.Size = new System.Drawing.Size(161, 45);
            this.txtAddQuantity.TabIndex = 12;
            this.txtAddQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddQuantity.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(794, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.DefaultText = "";
            this.txtPricePerUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.DisabledState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.HoverState.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Location = new System.Drawing.Point(662, 505);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.PlaceholderText = "";
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.ShadowDecoration.Parent = this.txtPricePerUnit;
            this.txtPricePerUnit.Size = new System.Drawing.Size(416, 45);
            this.txtPricePerUnit.TabIndex = 14;
            // 
            // laere
            // 
            this.laere.AutoSize = true;
            this.laere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laere.Location = new System.Drawing.Point(658, 480);
            this.laere.Name = "laere";
            this.laere.Size = new System.Drawing.Size(121, 22);
            this.laere.TabIndex = 13;
            this.laere.Text = "Price Per Unit";
            // 
            // txtMDate
            // 
            this.txtMDate.BorderRadius = 1;
            this.txtMDate.BorderThickness = 1;
            this.txtMDate.CheckedState.Parent = this.txtMDate;
            this.txtMDate.FillColor = System.Drawing.Color.White;
            this.txtMDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtMDate.HoverState.Parent = this.txtMDate;
            this.txtMDate.Location = new System.Drawing.Point(52, 598);
            this.txtMDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtMDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtMDate.Name = "txtMDate";
            this.txtMDate.ShadowDecoration.Parent = this.txtMDate;
            this.txtMDate.Size = new System.Drawing.Size(416, 45);
            this.txtMDate.TabIndex = 15;
            this.txtMDate.Value = new System.DateTime(2022, 3, 11, 23, 10, 3, 991);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Manufacturing Date";
            // 
            // txtEDate
            // 
            this.txtEDate.BorderRadius = 1;
            this.txtEDate.BorderThickness = 1;
            this.txtEDate.CheckedState.Parent = this.txtEDate;
            this.txtEDate.FillColor = System.Drawing.Color.White;
            this.txtEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEDate.HoverState.Parent = this.txtEDate;
            this.txtEDate.Location = new System.Drawing.Point(662, 234);
            this.txtEDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtEDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.ShadowDecoration.Parent = this.txtEDate;
            this.txtEDate.Size = new System.Drawing.Size(416, 45);
            this.txtEDate.TabIndex = 17;
            this.txtEDate.Value = new System.DateTime(2022, 3, 11, 23, 10, 3, 991);
            // 
            // dsada
            // 
            this.dsada.AutoSize = true;
            this.dsada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsada.Location = new System.Drawing.Point(658, 209);
            this.dsada.Name = "dsada";
            this.dsada.Size = new System.Drawing.Size(104, 22);
            this.dsada.TabIndex = 18;
            this.dsada.Text = "Expire Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderRadius = 19;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(288, 289);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(180, 45);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 19;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(662, 598);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnreset
            // 
            this.btnreset.BorderRadius = 19;
            this.btnreset.BorderThickness = 1;
            this.btnreset.CheckedState.Parent = this.btnreset;
            this.btnreset.CustomImages.Parent = this.btnreset;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnreset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnreset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnreset.HoverState.Parent = this.btnreset;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnreset.Location = new System.Drawing.Point(898, 598);
            this.btnreset.Name = "btnreset";
            this.btnreset.ShadowDecoration.Parent = this.btnreset;
            this.btnreset.Size = new System.Drawing.Size(180, 45);
            this.btnreset.TabIndex = 21;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(568, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 602);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // UC_E_UpdateMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dsada);
            this.Controls.Add(this.txtEDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMDate);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.laere);
            this.Controls.Add(this.txtAddQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_E_UpdateMedicine";
            this.Size = new System.Drawing.Size(1180, 807);
            this.Load += new System.EventHandler(this.UC_E_UpdateMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtMediID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerUnit;
        private System.Windows.Forms.Label laere;
        private Guna.UI2.WinForms.Guna2TextBox txtAddQuantity;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAvailableQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMediNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMediName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dsada;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtEDate;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
