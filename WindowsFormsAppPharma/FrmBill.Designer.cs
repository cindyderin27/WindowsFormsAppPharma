namespace WindowsFormsAppPharma
{
    partial class FrmBill
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
            this.guna2HtmlNumFact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlDrugName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlUnit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlCat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateTimePickerDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ComboBoxContact = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlCON = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNumFact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameDrug = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlNumFact
            // 
            this.guna2HtmlNumFact.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlNumFact.Location = new System.Drawing.Point(308, 92);
            this.guna2HtmlNumFact.Name = "guna2HtmlNumFact";
            this.guna2HtmlNumFact.Size = new System.Drawing.Size(88, 22);
            this.guna2HtmlNumFact.TabIndex = 0;
            this.guna2HtmlNumFact.Text = "N° Facture";
            this.guna2HtmlNumFact.Click += new System.EventHandler(this.guna2HtmlNumFact_Click);
            // 
            // guna2HtmlDrugName
            // 
            this.guna2HtmlDrugName.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlDrugName.Location = new System.Drawing.Point(319, 180);
            this.guna2HtmlDrugName.Name = "guna2HtmlDrugName";
            this.guna2HtmlDrugName.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlDrugName.TabIndex = 2;
            this.guna2HtmlDrugName.Text = "Drug\'s Name";
            // 
            // guna2HtmlQuan
            // 
            this.guna2HtmlQuan.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlQuan.Location = new System.Drawing.Point(21, 339);
            this.guna2HtmlQuan.Name = "guna2HtmlQuan";
            this.guna2HtmlQuan.Size = new System.Drawing.Size(70, 22);
            this.guna2HtmlQuan.TabIndex = 3;
            this.guna2HtmlQuan.Text = "Quantity";
            this.guna2HtmlQuan.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2HtmlUnit
            // 
            this.guna2HtmlUnit.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlUnit.Location = new System.Drawing.Point(334, 246);
            this.guna2HtmlUnit.Name = "guna2HtmlUnit";
            this.guna2HtmlUnit.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlUnit.TabIndex = 4;
            this.guna2HtmlUnit.Text = "UnitPrice";
            // 
            // guna2HtmlCat
            // 
            this.guna2HtmlCat.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlCat.Location = new System.Drawing.Point(13, 269);
            this.guna2HtmlCat.Name = "guna2HtmlCat";
            this.guna2HtmlCat.Size = new System.Drawing.Size(75, 22);
            this.guna2HtmlCat.TabIndex = 5;
            this.guna2HtmlCat.Text = "Category";
            this.guna2HtmlCat.Click += new System.EventHandler(this.guna2HtmlCat_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 50;
            this.guna2GroupBox1.CausesValidation = false;
            this.guna2GroupBox1.Controls.Add(this.txtMontant);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.lblDate);
            this.guna2GroupBox1.Controls.Add(this.DateTimePickerDate);
            this.guna2GroupBox1.Controls.Add(this.ComboBoxContact);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlCON);
            this.guna2GroupBox1.Controls.Add(this.txtQuan);
            this.guna2GroupBox1.Controls.Add(this.ComboBoxUnit);
            this.guna2GroupBox1.Controls.Add(this.ComboBoxCat);
            this.guna2GroupBox1.Controls.Add(this.txtNumFact);
            this.guna2GroupBox1.Controls.Add(this.txtNameDrug);
            this.guna2GroupBox1.Controls.Add(this.guna2BtnCancel);
            this.guna2GroupBox1.Controls.Add(this.guna2BtnSave);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlNumFact);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlUnit);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlCat);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlQuan);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlDrugName);
            this.guna2GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(951, 479);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Bill";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(368, 320);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 22);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // DateTimePickerDate
            // 
            this.DateTimePickerDate.CheckedState.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.FillColor = System.Drawing.Color.ForestGreen;
            this.DateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerDate.ForeColor = System.Drawing.Color.White;
            this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerDate.HoverState.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.Location = new System.Drawing.Point(368, 357);
            this.DateTimePickerDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.ShadowDecoration.Parent = this.DateTimePickerDate;
            this.DateTimePickerDate.Size = new System.Drawing.Size(210, 36);
            this.DateTimePickerDate.TabIndex = 7;
            this.DateTimePickerDate.Value = new System.DateTime(2020, 12, 24, 13, 42, 38, 49);
            // 
            // ComboBoxContact
            // 
            this.ComboBoxContact.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxContact.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxContact.FocusedState.Parent = this.ComboBoxContact;
            this.ComboBoxContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxContact.HoverState.Parent = this.ComboBoxContact;
            this.ComboBoxContact.ItemHeight = 30;
            this.ComboBoxContact.Items.AddRange(new object[] {
            "699999999",
            "677231425",
            "690123628"});
            this.ComboBoxContact.ItemsAppearance.Parent = this.ComboBoxContact;
            this.ComboBoxContact.Location = new System.Drawing.Point(128, 92);
            this.ComboBoxContact.Name = "ComboBoxContact";
            this.ComboBoxContact.ShadowDecoration.Parent = this.ComboBoxContact;
            this.ComboBoxContact.Size = new System.Drawing.Size(172, 36);
            this.ComboBoxContact.TabIndex = 8;
            // 
            // guna2HtmlCON
            // 
            this.guna2HtmlCON.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlCON.Location = new System.Drawing.Point(13, 91);
            this.guna2HtmlCON.Name = "guna2HtmlCON";
            this.guna2HtmlCON.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlCON.TabIndex = 9;
            this.guna2HtmlCON.Text = "Contact";
            // 
            // txtQuan
            // 
            this.txtQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuan.DefaultText = "";
            this.txtQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.DisabledState.Parent = this.txtQuan;
            this.txtQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.FocusedState.Parent = this.txtQuan;
            this.txtQuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuan.HoverState.Parent = this.txtQuan;
            this.txtQuan.Location = new System.Drawing.Point(128, 339);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.PlaceholderText = "";
            this.txtQuan.SelectedText = "";
            this.txtQuan.ShadowDecoration.Parent = this.txtQuan;
            this.txtQuan.Size = new System.Drawing.Size(172, 36);
            this.txtQuan.TabIndex = 4;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // ComboBoxUnit
            // 
            this.ComboBoxUnit.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUnit.FocusedState.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxUnit.HoverState.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.ItemHeight = 30;
            this.ComboBoxUnit.Items.AddRange(new object[] {
            "1000",
            "2000"});
            this.ComboBoxUnit.ItemsAppearance.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Location = new System.Drawing.Point(448, 246);
            this.ComboBoxUnit.Name = "ComboBoxUnit";
            this.ComboBoxUnit.ShadowDecoration.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Size = new System.Drawing.Size(197, 36);
            this.ComboBoxUnit.TabIndex = 5;
            this.ComboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUnit_SelectedIndexChanged);
            // 
            // ComboBoxCat
            // 
            this.ComboBoxCat.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCat.FocusedState.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxCat.HoverState.Parent = this.ComboBoxCat;
            this.ComboBoxCat.ItemHeight = 30;
            this.ComboBoxCat.Items.AddRange(new object[] {
            "Oral Drug\'s",
            "Solutions"});
            this.ComboBoxCat.ItemsAppearance.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Location = new System.Drawing.Point(128, 255);
            this.ComboBoxCat.Name = "ComboBoxCat";
            this.ComboBoxCat.ShadowDecoration.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Size = new System.Drawing.Size(172, 36);
            this.ComboBoxCat.TabIndex = 3;
            this.ComboBoxCat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCat_SelectedIndexChanged);
            // 
            // txtNumFact
            // 
            this.txtNumFact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumFact.DefaultText = "";
            this.txtNumFact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumFact.DisabledState.Parent = this.txtNumFact;
            this.txtNumFact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumFact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumFact.FocusedState.Parent = this.txtNumFact;
            this.txtNumFact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumFact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumFact.HoverState.Parent = this.txtNumFact;
            this.txtNumFact.Location = new System.Drawing.Point(434, 91);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.PasswordChar = '\0';
            this.txtNumFact.PlaceholderText = "";
            this.txtNumFact.SelectedText = "";
            this.txtNumFact.ShadowDecoration.Parent = this.txtNumFact;
            this.txtNumFact.Size = new System.Drawing.Size(200, 36);
            this.txtNumFact.TabIndex = 0;
            this.txtNumFact.TextChanged += new System.EventHandler(this.txtNumFact_TextChanged);
            // 
            // txtNameDrug
            // 
            this.txtNameDrug.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameDrug.DefaultText = "";
            this.txtNameDrug.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameDrug.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameDrug.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameDrug.DisabledState.Parent = this.txtNameDrug;
            this.txtNameDrug.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameDrug.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameDrug.FocusedState.Parent = this.txtNameDrug;
            this.txtNameDrug.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameDrug.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameDrug.HoverState.Parent = this.txtNameDrug;
            this.txtNameDrug.Location = new System.Drawing.Point(445, 166);
            this.txtNameDrug.Name = "txtNameDrug";
            this.txtNameDrug.PasswordChar = '\0';
            this.txtNameDrug.PlaceholderText = "";
            this.txtNameDrug.SelectedText = "";
            this.txtNameDrug.ShadowDecoration.Parent = this.txtNameDrug;
            this.txtNameDrug.Size = new System.Drawing.Size(200, 36);
            this.txtNameDrug.TabIndex = 2;
            // 
            // guna2BtnCancel
            // 
            this.guna2BtnCancel.BorderRadius = 10;
            this.guna2BtnCancel.BorderThickness = 20;
            this.guna2BtnCancel.CheckedState.Parent = this.guna2BtnCancel;
            this.guna2BtnCancel.CustomImages.Parent = this.guna2BtnCancel;
            this.guna2BtnCancel.FillColor = System.Drawing.Color.DarkRed;
            this.guna2BtnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2BtnCancel.ForeColor = System.Drawing.Color.White;
            this.guna2BtnCancel.HoverState.Parent = this.guna2BtnCancel;
            this.guna2BtnCancel.Location = new System.Drawing.Point(785, 214);
            this.guna2BtnCancel.Name = "guna2BtnCancel";
            this.guna2BtnCancel.ShadowDecoration.Parent = this.guna2BtnCancel;
            this.guna2BtnCancel.Size = new System.Drawing.Size(112, 45);
            this.guna2BtnCancel.TabIndex = 11;
            this.guna2BtnCancel.Text = "Cancel";
            this.guna2BtnCancel.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2BtnSave
            // 
            this.guna2BtnSave.BorderRadius = 10;
            this.guna2BtnSave.BorderThickness = 20;
            this.guna2BtnSave.CheckedState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.CustomImages.Parent = this.guna2BtnSave;
            this.guna2BtnSave.FillColor = System.Drawing.Color.Green;
            this.guna2BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2BtnSave.ForeColor = System.Drawing.Color.White;
            this.guna2BtnSave.HoverState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Location = new System.Drawing.Point(785, 112);
            this.guna2BtnSave.Name = "guna2BtnSave";
            this.guna2BtnSave.ShadowDecoration.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Size = new System.Drawing.Size(112, 45);
            this.guna2BtnSave.TabIndex = 10;
            this.guna2BtnSave.Text = "Save";
            this.guna2BtnSave.Click += new System.EventHandler(this.guna2BtnSave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMontant
            // 
            this.txtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontant.DefaultText = "";
            this.txtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.DisabledState.Parent = this.txtMontant;
            this.txtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.FocusedState.Parent = this.txtMontant;
            this.txtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMontant.HoverState.Parent = this.txtMontant;
            this.txtMontant.Location = new System.Drawing.Point(128, 180);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "";
            this.txtMontant.SelectedText = "";
            this.txtMontant.ShadowDecoration.Parent = this.txtMontant;
            this.txtMontant.Size = new System.Drawing.Size(172, 34);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 180);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 22);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Amount paid";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(988, 514);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlNumFact;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlDrugName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlQuan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlUnit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlCat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button guna2BtnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2BtnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtQuan;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxUnit;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCat;
        private Guna.UI2.WinForms.Guna2TextBox txtNumFact;
        private Guna.UI2.WinForms.Guna2TextBox txtNameDrug;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerDate;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxContact;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlCON;
        private Guna.UI2.WinForms.Guna2TextBox txtMontant;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}