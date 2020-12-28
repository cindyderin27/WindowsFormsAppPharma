namespace WindowsFormsAppPharma
{
    partial class FrmListBill
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
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnModify = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BtnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBillBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.TxtSearch.Location = new System.Drawing.Point(35, 40);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.PlaceholderText = "";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.ShadowDecoration.Parent = this.TxtSearch;
            this.TxtSearch.Size = new System.Drawing.Size(594, 36);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(35, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Search";
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
            this.BtnPrint.Location = new System.Drawing.Point(673, 277);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnPrint.ShadowDecoration.Parent = this.BtnPrint;
            this.BtnPrint.Size = new System.Drawing.Size(103, 44);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
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
            this.BtnModify.Location = new System.Drawing.Point(663, 49);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnModify.ShadowDecoration.Parent = this.BtnModify;
            this.BtnModify.Size = new System.Drawing.Size(110, 47);
            this.BtnModify.TabIndex = 6;
            this.BtnModify.Text = "Modify";
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCancel.CheckedState.Parent = this.BtnCancel;
            this.BtnCancel.CustomImages.Parent = this.BtnCancel;
            this.BtnCancel.FillColor = System.Drawing.Color.White;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel.HoverState.Parent = this.BtnCancel;
            this.BtnCancel.Location = new System.Drawing.Point(883, 438);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnCancel.ShadowDecoration.Parent = this.BtnCancel;
            this.BtnCancel.Size = new System.Drawing.Size(103, 44);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.BtnDelete.Location = new System.Drawing.Point(666, 355);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnDelete.ShadowDecoration.Parent = this.BtnDelete;
            this.BtnDelete.Size = new System.Drawing.Size(110, 44);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(670, 194);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnRefresh.ShadowDecoration.Parent = this.BtnRefresh;
            this.BtnRefresh.Size = new System.Drawing.Size(110, 47);
            this.BtnRefresh.TabIndex = 9;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
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
            this.BtnAdd.Location = new System.Drawing.Point(666, 120);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnAdd.ShadowDecoration.Parent = this.BtnAdd;
            this.BtnAdd.Size = new System.Drawing.Size(103, 44);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(35, 438);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(37, 18);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Count";
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewBill.Location = new System.Drawing.Point(35, 82);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(594, 326);
            this.dataGridViewBill.TabIndex = 12;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MatBill";
            this.Column1.HeaderText = "N°Bill";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NameDrug";
            this.Column2.HeaderText = "Drug";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CategoryDrug";
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UnitPrice";
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date";
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Contacts";
            this.Column7.HeaderText = "Contact";
            this.Column7.Name = "Column7";
            // 
            // frmBillBindingSource
            // 
            this.frmBillBindingSource.DataSource = typeof(WindowsFormsAppPharma.FrmBill);
            // 
            // FrmListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1029, 490);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.TxtSearch);
            this.Name = "FrmListBill";
            this.Text = "FrmListBill";
            this.Load += new System.EventHandler(this.FrmListBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmBillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton BtnPrint;
        private Guna.UI2.WinForms.Guna2CircleButton BtnModify;
        private Guna.UI2.WinForms.Guna2CircleButton BtnCancel;
        private Guna.UI2.WinForms.Guna2CircleButton BtnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton BtnRefresh;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2CircleButton BtnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCount;
        private System.Windows.Forms.BindingSource frmBillBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}