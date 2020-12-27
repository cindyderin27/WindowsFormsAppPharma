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
    public partial class FrmListBill : Form
    {
        private BillBLO billBLO;
        public FrmListBill()
        {
            InitializeComponent();


            dataGridViewBill.AutoGenerateColumns = false;
            billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);
            
        }
        private void loadData()
        {
            string value = TxtSearch.Text.ToLower();
            var bills = billBLO.GetBy
                (
                x =>
               x.MatBill.ToLower().Contains(value)||
                x.NameDrug.ToLower().Contains(value)
                ).OrderBy(x => x.MatBill).ToArray();
           
            dataGridViewBill.DataSource = null;
            dataGridViewBill.DataSource = bills;
            lblCount.Text = $"{ dataGridViewBill.RowCount} rows";
            dataGridViewBill.ClearSelection();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         private void RefreshGridOnFormChildClose(object sender, FormClosedEventArgs e)
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
                    ) ;
            }
            Form f = new FrmPreview("BillReport.rdlc", items);
            f.Show();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form f = new FrmBill(loadData);
            f.Show();
            f.FormClosed += new FormClosedEventHandler(RefreshGridOnFormChildClose);
        }

        private void FrmListBill_Load(object sender, EventArgs e)
        {
            loadData();
            ////timer2.Start();
            ////timer2.Enabled = true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtSearch.Text))
                loadData();
            else
               TxtSearch.Clear();
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

        private void DataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnModify_Click(sender, e);
        }

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
