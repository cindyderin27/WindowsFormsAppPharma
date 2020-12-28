using PharmaLog.BLL;
using PharmaLog.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPharma
{
    public partial class FrmBill : Form
    {
        private Action callBack;
        private Bill oldbill;
        private BillBLO billBLO;
        public FrmBill()
        {
            InitializeComponent();
            //dataGridViewBill.AutoGenerateColumns = false;
            billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);
           
        }

        public FrmBill(Action callback) : this()
        {
            this.callBack = callback;
        }
        public FrmBill(Bill bill, Action callback) : this(callback)
        {
            this.oldbill = bill;
            txtNumFact.Text = bill.MatBill;
            txtNameDrug.Text = bill.NameDrug;
            ComboBoxCat.Text = bill.CategoryDrug;
           ComboBoxUnit.Text=bill.UnitPrice.ToString();
           txtQuan.Text=bill.Quantity.ToString();
            ComboBoxContact.Text = bill.Contacts.ToString();
           // guna2ComboBoxEmail.Text = bill.Email.ToString();
            DateTimePickerDate.Text = bill.Date.ToString();
            txtMontant.Text = bill.AmountPaid.ToString();

        }
        private void loadData()
        {
            string value = TxtSearch.Text.ToLower();
            var bills = billBLO.GetBy
                (
                x =>
               x.MatBill.ToLower().Contains(value) ||
                x.NameDrug.ToLower().Contains(value)
                ).OrderBy(x => x.MatBill).ToArray();
            dataGridViewBill.DataSource = null;
            dataGridViewBill.DataSource = bills;
            lblCount.Text = $"{ dataGridViewBill.RowCount} rows";
            dataGridViewBill.ClearSelection();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            loadData();
          timer1.Start();
          timer1.Enabled = true;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                Bill newBill = new Bill(
                txtNumFact.Text.ToUpper(),
                txtNameDrug.Text.ToUpper(),
                ComboBoxCat.Text.ToUpper(),
                int.Parse(txtQuan.Text),
                double.Parse(ComboBoxUnit.Text),
               long.Parse(ComboBoxContact.Text),
              // guna2ComboBoxEmail.Text,
               DateTime.Parse(DateTimePickerDate.Text),
               double.Parse(txtMontant.Text)

            );
                BillBLO billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldbill == null)
                    billBLO.CreateBill(newBill);
                else
                    billBLO.EditBill(oldbill, newBill);
               
                MessageBox.Show
                    (
                        "Save done !",
                        "confirmation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                if (callBack != null)
                    callBack();

                if (oldbill != null)
                    Close();
                txtNumFact.Clear();
               
                txtNameDrug.Clear();
                txtQuan.Clear();
                ComboBoxCat.SelectedValue = null;
                ComboBoxUnit.SelectedValue =null;
                ComboBoxContact.SelectedValue = null;
               // guna2ComboBoxEmail.SelectedValue = null;
                DateTimePickerDate.Refresh();
                txtNumFact.Focus();
                txtMontant.Clear();
                
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                     ex.Message,
                   "Duplicate error",

                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                     ex.Message,
                   "Typing Error",

                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                     ex.Message,
                   " Not found error",

                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );

            }
            catch (Exception ex)
            {
                ex.WriteToFile();

                MessageBox.Show
               (
                   "An error occurred! please try again later .",
                   " Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            loadData();


        }
        private void checkForm()
        {
            string text = string.Empty;
            txtNumFact.BackColor = Color.White;
            txtNameDrug.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNumFact.Text))
            {
                text += "- Please enter the Reference Bill! \n";
                txtNumFact.BackColor = Color.Red;

            }
            if (string.IsNullOrWhiteSpace(txtNameDrug.Text))
            {
                text += "- please enter the Drug's Name! \n";
                txtNameDrug.BackColor = Color.Red;
            }
            if (!string.IsNullOrEmpty(text))
            {
                throw new TypingException(text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int col1 = ran.Next(0, 255);
            int col2 = ran.Next(0, 255);
            int col3 = ran.Next(0, 255);
            int col4 = ran.Next(0, 255);

            //.ForeColor = Color.FromArgb(col1, col2, col3, col4);
        }

        private void ComboBoxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumFact_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlNumFact_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlCat_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlCON_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            List<BillPrint> items = new List<BillPrint>();
            // Pharmacy pharmacy = pharmacyBLO.GetPharmacy();
            for (int i = 0; i < dataGridViewBill.Rows.Count; i++)
            {
                Bill d = dataGridViewBill.Rows[i].DataBoundItem as Bill;
                items.Add(
                    new BillPrint(
                        d.MatBill,
                        d.NameDrug,
                        d.CategoryDrug,
                        d.Quantity,
                        d.UnitPrice,
                        d.Contacts,
                        // d.Email,
                        d.Date,
                        d.AmountPaid
                      //   !string.IsNullOrEmpty(pharmacy?.Logo) ? File.ReadAllBytes(pharmacy?.Logo) : null
                      )
                    );
            }
            Form f = new FrmPreview("BillReport.rdlc", items);
            f.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBill.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show(
                        "Do you really want to delete this Bill",
                        "warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes
                    )
                {
                    for (int i = 0; i < dataGridViewBill.SelectedRows.Count; i++)
                    {
                        billBLO.DeleteBill(dataGridViewBill.SelectedRows[i].DataBoundItem as Bill);
                    }
                    loadData();
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewBill.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridViewBill.SelectedRows.Count; i++)
                {
                    Form f = new FrmBill
                        (
                         dataGridViewBill.SelectedRows[i].DataBoundItem as Bill,
                        loadData
                        );
                    f.ShowDialog();
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
                loadData();
            else
                TxtSearch.Clear();
        }
    }
}
