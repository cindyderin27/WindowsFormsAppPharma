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
            this.txtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnModify = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.frmBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlNumFact
            // 
            this.guna2HtmlNumFact.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlNumFact.Location = new System.Drawing.Point(8, 57);
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
            this.guna2HtmlDrugName.Location = new System.Drawing.Point(8, 113);
            this.guna2HtmlDrugName.Name = "guna2HtmlDrugName";
            this.guna2HtmlDrugName.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlDrugName.TabIndex = 2;
            this.guna2HtmlDrugName.Text = "Drug\'s Name";
            // 
            // guna2HtmlQuan
            // 
            this.guna2HtmlQuan.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlQuan.Location = new System.Drawing.Point(21, 243);
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
            this.guna2HtmlUnit.Location = new System.Drawing.Point(15, 150);
            this.guna2HtmlUnit.Name = "guna2HtmlUnit";
            this.guna2HtmlUnit.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlUnit.TabIndex = 4;
            this.guna2HtmlUnit.Text = "UnitPrice";
            // 
            // guna2HtmlCat
            // 
            this.guna2HtmlCat.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlCat.Location = new System.Drawing.Point(16, 202);
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
            this.guna2GroupBox1.Size = new System.Drawing.Size(313, 479);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Bill";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
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
            this.txtMontant.Location = new System.Drawing.Point(128, 294);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.PasswordChar = '\0';
            this.txtMontant.PlaceholderText = "";
            this.txtMontant.SelectedText = "";
            this.txtMontant.ShadowDecoration.Parent = this.txtMontant;
            this.txtMontant.Size = new System.Drawing.Size(137, 34);
            this.txtMontant.TabIndex = 9;
            this.txtMontant.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 285);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 22);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Amount paid";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(21, 384);
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
            this.DateTimePickerDate.Location = new System.Drawing.Point(25, 412);
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
            this.ComboBoxContact.Location = new System.Drawing.Point(128, 342);
            this.ComboBoxContact.Name = "ComboBoxContact";
            this.ComboBoxContact.ShadowDecoration.Parent = this.ComboBoxContact;
            this.ComboBoxContact.Size = new System.Drawing.Size(137, 36);
            this.ComboBoxContact.TabIndex = 8;
            // 
            // guna2HtmlCON
            // 
            this.guna2HtmlCON.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlCON.Location = new System.Drawing.Point(25, 342);
            this.guna2HtmlCON.Name = "guna2HtmlCON";
            this.guna2HtmlCON.Size = new System.Drawing.Size(66, 22);
            this.guna2HtmlCON.TabIndex = 9;
            this.guna2HtmlCON.Text = "Contact";
            this.guna2HtmlCON.Click += new System.EventHandler(this.guna2HtmlCON_Click);
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
            this.txtQuan.Location = new System.Drawing.Point(129, 243);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.PlaceholderText = "";
            this.txtQuan.SelectedText = "";
            this.txtQuan.ShadowDecoration.Parent = this.txtQuan;
            this.txtQuan.Size = new System.Drawing.Size(139, 36);
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
            this.ComboBoxUnit.Location = new System.Drawing.Point(126, 141);
            this.ComboBoxUnit.Name = "ComboBoxUnit";
            this.ComboBoxUnit.ShadowDecoration.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Size = new System.Drawing.Size(139, 36);
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
            this.ComboBoxCat.Location = new System.Drawing.Point(126, 192);
            this.ComboBoxCat.Name = "ComboBoxCat";
            this.ComboBoxCat.ShadowDecoration.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Size = new System.Drawing.Size(139, 36);
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
            this.txtNumFact.Location = new System.Drawing.Point(131, 56);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.PasswordChar = '\0';
            this.txtNumFact.PlaceholderText = "";
            this.txtNumFact.SelectedText = "";
            this.txtNumFact.ShadowDecoration.Parent = this.txtNumFact;
            this.txtNumFact.Size = new System.Drawing.Size(137, 36);
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
            this.txtNameDrug.Location = new System.Drawing.Point(129, 99);
            this.txtNameDrug.Name = "txtNameDrug";
            this.txtNameDrug.PasswordChar = '\0';
            this.txtNameDrug.PlaceholderText = "";
            this.txtNameDrug.SelectedText = "";
            this.txtNameDrug.ShadowDecoration.Parent = this.txtNameDrug;
            this.txtNameDrug.Size = new System.Drawing.Size(139, 36);
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
            this.guna2BtnCancel.Location = new System.Drawing.Point(409, 478);
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
            this.guna2BtnSave.Location = new System.Drawing.Point(860, 478);
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
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToOrderColumns = true;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewBill.Location = new System.Drawing.Point(378, 94);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(611, 354);
            this.dataGridViewBill.TabIndex = 20;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MatBill";
            this.Column1.HeaderText = "N°Bill";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NameDrug";
            this.Column2.HeaderText = "Drug";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CategoryDrug";
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UnitPrice";
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date";
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Contacts";
            this.Column7.HeaderText = "Contact";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.CheckedState.Parent = this.BtnAdd;
            this.BtnAdd.CustomImages.Parent = this.BtnAdd;
            this.BtnAdd.FillColor = System.Drawing.Color.White;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.HoverState.Parent = this.BtnAdd;
            this.BtnAdd.Location = new System.Drawing.Point(1054, 139);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(78, 44);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRefresh.BorderRadius = 5;
            this.BtnRefresh.CheckedState.Parent = this.BtnRefresh;
            this.BtnRefresh.CustomImages.Parent = this.BtnRefresh;
            this.BtnRefresh.FillColor = System.Drawing.Color.White;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnRefresh.HoverState.Parent = this.BtnRefresh;
            this.BtnRefresh.Location = new System.Drawing.Point(1058, 213);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnRefresh.ShadowDecoration.Parent = this.BtnRefresh;
            this.BtnRefresh.Size = new System.Drawing.Size(85, 47);
            this.BtnRefresh.TabIndex = 18;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnDelete.CheckedState.Parent = this.BtnDelete;
            this.BtnDelete.CustomImages.Parent = this.BtnDelete;
            this.BtnDelete.FillColor = System.Drawing.Color.White;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnDelete.HoverState.Parent = this.BtnDelete;
            this.BtnDelete.Location = new System.Drawing.Point(1054, 374);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnDelete.ShadowDecoration.Parent = this.BtnDelete;
            this.BtnDelete.Size = new System.Drawing.Size(85, 44);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnModify.CheckedState.Parent = this.BtnModify;
            this.BtnModify.CustomImages.Parent = this.BtnModify;
            this.BtnModify.FillColor = System.Drawing.Color.White;
            this.BtnModify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnModify.HoverState.Parent = this.BtnModify;
            this.BtnModify.Location = new System.Drawing.Point(1051, 68);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnModify.ShadowDecoration.Parent = this.BtnModify;
            this.BtnModify.Size = new System.Drawing.Size(85, 47);
            this.BtnModify.TabIndex = 16;
            this.BtnModify.Text = "Modify";
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnPrint.CheckedState.Parent = this.BtnPrint;
            this.BtnPrint.CustomImages.Parent = this.BtnPrint;
            this.BtnPrint.FillColor = System.Drawing.Color.White;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnPrint.HoverState.Parent = this.BtnPrint;
            this.BtnPrint.Location = new System.Drawing.Point(1061, 296);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnPrint.ShadowDecoration.Parent = this.BtnPrint;
            this.BtnPrint.Size = new System.Drawing.Size(78, 44);
            this.BtnPrint.TabIndex = 15;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(378, 24);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Search";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderRadius = 20;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.Parent = this.TxtSearch;
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.FocusedState.Parent = this.TxtSearch;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.HoverState.Parent = this.TxtSearch;
            this.TxtSearch.Location = new System.Drawing.Point(378, 52);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderText = "";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(611, 36);
            this.TxtSearch.TabIndex = 13;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(378, 454);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(40, 17);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "Count";
            // 
            // frmBillBindingSource
            // 
            this.frmBillBindingSource.DataSource = typeof(WindowsFormsAppPharma.FrmBill);
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1296, 535);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2BtnCancel);
            this.Controls.Add(this.guna2BtnSave);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2CircleButton BtnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton BtnRefresh;
        private Guna.UI2.WinForms.Guna2CircleButton BtnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton BtnModify;
        private Guna.UI2.WinForms.Guna2CircleButton BtnPrint;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCount;
        private System.Windows.Forms.BindingSource frmBillBindingSource;
    }
}