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
            this.guna2HtmlLNumProd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlDrugName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlQuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlUnit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlCat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlPict = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLogo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2CirclePictureDrug = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtNameDrug = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumDrug = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumFact = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CircleLogo)).BeginInit();
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
            // 
            // guna2HtmlLNumProd
            // 
            this.guna2HtmlLNumProd.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLNumProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLNumProd.Location = new System.Drawing.Point(308, 180);
            this.guna2HtmlLNumProd.Name = "guna2HtmlLNumProd";
            this.guna2HtmlLNumProd.Size = new System.Drawing.Size(83, 22);
            this.guna2HtmlLNumProd.TabIndex = 1;
            this.guna2HtmlLNumProd.Text = "N° Produit";
            // 
            // guna2HtmlDrugName
            // 
            this.guna2HtmlDrugName.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlDrugName.Location = new System.Drawing.Point(308, 261);
            this.guna2HtmlDrugName.Name = "guna2HtmlDrugName";
            this.guna2HtmlDrugName.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlDrugName.TabIndex = 2;
            this.guna2HtmlDrugName.Text = "Drug\'s Name";
            // 
            // guna2HtmlQuan
            // 
            this.guna2HtmlQuan.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlQuan.Location = new System.Drawing.Point(308, 396);
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
            this.guna2HtmlUnit.Location = new System.Drawing.Point(667, 386);
            this.guna2HtmlUnit.Name = "guna2HtmlUnit";
            this.guna2HtmlUnit.Size = new System.Drawing.Size(76, 22);
            this.guna2HtmlUnit.TabIndex = 4;
            this.guna2HtmlUnit.Text = "UnitPrice";
            // 
            // guna2HtmlCat
            // 
            this.guna2HtmlCat.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlCat.Location = new System.Drawing.Point(308, 321);
            this.guna2HtmlCat.Name = "guna2HtmlCat";
            this.guna2HtmlCat.Size = new System.Drawing.Size(75, 22);
            this.guna2HtmlCat.TabIndex = 5;
            this.guna2HtmlCat.Text = "Category";
            // 
            // guna2HtmlPict
            // 
            this.guna2HtmlPict.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlPict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlPict.Location = new System.Drawing.Point(777, 63);
            this.guna2HtmlPict.Name = "guna2HtmlPict";
            this.guna2HtmlPict.Size = new System.Drawing.Size(59, 22);
            this.guna2HtmlPict.TabIndex = 6;
            this.guna2HtmlPict.Text = "Picture";
            // 
            // guna2HtmlLogo
            // 
            this.guna2HtmlLogo.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLogo.Location = new System.Drawing.Point(14, 63);
            this.guna2HtmlLogo.Name = "guna2HtmlLogo";
            this.guna2HtmlLogo.Size = new System.Drawing.Size(43, 22);
            this.guna2HtmlLogo.TabIndex = 7;
            this.guna2HtmlLogo.Text = "Logo";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 50;
            this.guna2GroupBox1.CausesValidation = false;
            this.guna2GroupBox1.Controls.Add(this.txtQuan);
            this.guna2GroupBox1.Controls.Add(this.ComboBoxUnit);
            this.guna2GroupBox1.Controls.Add(this.ComboBoxCat);
            this.guna2GroupBox1.Controls.Add(this.txtNumFact);
            this.guna2GroupBox1.Controls.Add(this.txtNumDrug);
            this.guna2GroupBox1.Controls.Add(this.txtNameDrug);
            this.guna2GroupBox1.Controls.Add(this.linkLabel2);
            this.guna2GroupBox1.Controls.Add(this.linkLabel1);
            this.guna2GroupBox1.Controls.Add(this.guna2CircleLogo);
            this.guna2GroupBox1.Controls.Add(this.guna2BtnCancel);
            this.guna2GroupBox1.Controls.Add(this.guna2BtnSave);
            this.guna2GroupBox1.Controls.Add(this.guna2CirclePictureDrug);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlNumFact);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlUnit);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlCat);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlQuan);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLogo);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlDrugName);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLNumProd);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlPict);
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
            // guna2CirclePictureDrug
            // 
            this.guna2CirclePictureDrug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2CirclePictureDrug.ImageRotate = 10F;
            this.guna2CirclePictureDrug.Location = new System.Drawing.Point(777, 92);
            this.guna2CirclePictureDrug.Name = "guna2CirclePictureDrug";
            this.guna2CirclePictureDrug.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureDrug.ShadowDecoration.Parent = this.guna2CirclePictureDrug;
            this.guna2CirclePictureDrug.Size = new System.Drawing.Size(137, 141);
            this.guna2CirclePictureDrug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureDrug.TabIndex = 8;
            this.guna2CirclePictureDrug.TabStop = false;
            // 
            // guna2BtnSave
            // 
            this.guna2BtnSave.BorderRadius = 10;
            this.guna2BtnSave.BorderThickness = 20;
            this.guna2BtnSave.CheckedState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.CustomImages.Parent = this.guna2BtnSave;
            this.guna2BtnSave.FillColor = System.Drawing.Color.Green;
            this.guna2BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2BtnSave.ForeColor = System.Drawing.Color.White;
            this.guna2BtnSave.HoverState.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Location = new System.Drawing.Point(20, 284);
            this.guna2BtnSave.Name = "guna2BtnSave";
            this.guna2BtnSave.ShadowDecoration.Parent = this.guna2BtnSave;
            this.guna2BtnSave.Size = new System.Drawing.Size(112, 45);
            this.guna2BtnSave.TabIndex = 9;
            this.guna2BtnSave.Text = "Save";
            this.guna2BtnSave.Click += new System.EventHandler(this.guna2BtnSave_Click);
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
            this.guna2BtnCancel.Location = new System.Drawing.Point(20, 373);
            this.guna2BtnCancel.Name = "guna2BtnCancel";
            this.guna2BtnCancel.ShadowDecoration.Parent = this.guna2BtnCancel;
            this.guna2BtnCancel.Size = new System.Drawing.Size(112, 45);
            this.guna2BtnCancel.TabIndex = 10;
            this.guna2BtnCancel.Text = "Cancel";
            this.guna2BtnCancel.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2CircleLogo
            // 
            this.guna2CircleLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2CircleLogo.ImageRotate = 10F;
            this.guna2CircleLogo.Location = new System.Drawing.Point(14, 91);
            this.guna2CircleLogo.Name = "guna2CircleLogo";
            this.guna2CircleLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleLogo.ShadowDecoration.Parent = this.guna2CircleLogo;
            this.guna2CircleLogo.Size = new System.Drawing.Size(160, 143);
            this.guna2CircleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CircleLogo.TabIndex = 11;
            this.guna2CircleLogo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(154, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(20, 21);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(894, 64);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(20, 21);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
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
            this.txtNameDrug.Location = new System.Drawing.Point(434, 247);
            this.txtNameDrug.Name = "txtNameDrug";
            this.txtNameDrug.PasswordChar = '\0';
            this.txtNameDrug.PlaceholderText = "";
            this.txtNameDrug.SelectedText = "";
            this.txtNameDrug.ShadowDecoration.Parent = this.txtNameDrug;
            this.txtNameDrug.Size = new System.Drawing.Size(200, 36);
            this.txtNameDrug.TabIndex = 15;
            // 
            // txtNumDrug
            // 
            this.txtNumDrug.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumDrug.DefaultText = "";
            this.txtNumDrug.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumDrug.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumDrug.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumDrug.DisabledState.Parent = this.txtNumDrug;
            this.txtNumDrug.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumDrug.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumDrug.FocusedState.Parent = this.txtNumDrug;
            this.txtNumDrug.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumDrug.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumDrug.HoverState.Parent = this.txtNumDrug;
            this.txtNumDrug.Location = new System.Drawing.Point(434, 166);
            this.txtNumDrug.Name = "txtNumDrug";
            this.txtNumDrug.PasswordChar = '\0';
            this.txtNumDrug.PlaceholderText = "";
            this.txtNumDrug.SelectedText = "";
            this.txtNumDrug.ShadowDecoration.Parent = this.txtNumDrug;
            this.txtNumDrug.Size = new System.Drawing.Size(200, 36);
            this.txtNumDrug.TabIndex = 16;
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
            this.txtNumFact.TabIndex = 17;
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
            this.ComboBoxCat.ItemsAppearance.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Location = new System.Drawing.Point(434, 307);
            this.ComboBoxCat.Name = "ComboBoxCat";
            this.ComboBoxCat.ShadowDecoration.Parent = this.ComboBoxCat;
            this.ComboBoxCat.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxCat.TabIndex = 18;
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
            this.ComboBoxUnit.ItemsAppearance.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Location = new System.Drawing.Point(781, 386);
            this.ComboBoxUnit.Name = "ComboBoxUnit";
            this.ComboBoxUnit.ShadowDecoration.Parent = this.ComboBoxUnit;
            this.ComboBoxUnit.Size = new System.Drawing.Size(140, 36);
            this.ComboBoxUnit.TabIndex = 19;
            this.ComboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUnit_SelectedIndexChanged);
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
            this.txtQuan.Location = new System.Drawing.Point(415, 396);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.PlaceholderText = "";
            this.txtQuan.SelectedText = "";
            this.txtQuan.ShadowDecoration.Parent = this.txtQuan;
            this.txtQuan.Size = new System.Drawing.Size(219, 36);
            this.txtQuan.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 514);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CircleLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlNumFact;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLNumProd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlDrugName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlQuan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlUnit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlCat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlPict;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLogo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureDrug;
        private Guna.UI2.WinForms.Guna2Button guna2BtnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2BtnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtQuan;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxUnit;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCat;
        private Guna.UI2.WinForms.Guna2TextBox txtNumFact;
        private Guna.UI2.WinForms.Guna2TextBox txtNumDrug;
        private Guna.UI2.WinForms.Guna2TextBox txtNameDrug;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CircleLogo;
        private System.Windows.Forms.Timer timer1;
    }
}