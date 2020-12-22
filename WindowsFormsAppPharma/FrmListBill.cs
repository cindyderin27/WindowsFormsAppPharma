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
            DataGridViewList.AutoGenerateColumns = false;
            billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = TxtSearch.Text.ToLower();
            var bills = billBLO.GetBy
                (
                x =>
                x.MatBill.ToLower().Contains(value) ||
                x.MatDrug.ToLower().Contains(value)
                ).OrderBy(x => x.MatBill).ToArray();
            DataGridViewList.DataSource = null;
            DataGridViewList.DataSource = bills;
            DataGridViewList.ClearSelection();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
             List<BillPrint> items = new List<BillPrint>();
            // Pharmacy pharmacy = pharmacyBLO.GetPharmacy();
            for (int i = 0; i < DataGridViewList.Rows.Count; i++)
            {
                BillPrint d = DataGridViewList.Rows[i].DataBoundItem as BillPrint;
                items.Add(
                    new BillPrint(
                        d.MatBill,
                        d.MatDrug,
                        d.NameDrug,
                        d.CategoryDrug,
                        d.Quantity,
                        d.UnitPrice,
                        d.Contact,
                        d.Email,
                        d.Date
                      //   !string.IsNullOrEmpty(pharmacy?.Logo) ? File.ReadAllBytes(pharmacy?.Logo) : null
                      )
                    ) ;
            }
            Form f = new FrmPreview("BillReport.rdlc", items);
            f.Show();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (DataGridViewList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < DataGridViewList.SelectedRows.Count; i++)
                {
                    Form f = new FrmBill
                        (
                        DataGridViewList.SelectedRows[i].DataBoundItem as Bill,
                        loadData
                        );
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form f = new FrmBill();
            f.Show();
        }

        private void FrmListBill_Load(object sender, EventArgs e)
        {
            loadData();
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
            if (DataGridViewList.SelectedRows.Count > 0)
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
                    for (int i = 0; i < DataGridViewList.SelectedRows.Count; i++)
                    {
                        billBLO.DeleteBill(DataGridViewList.SelectedRows[i].DataBoundItem as Bill);
                    }
                    loadData();
                }
            }
        }

        private void DataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnModify_Click(sender, e);
        }
    }
}
