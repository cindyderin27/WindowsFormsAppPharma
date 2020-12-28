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
            billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);
            dataGridViewBill.AutoGenerateColumns = false;
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
            
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form f = new FrmBill();
            f.Show();
            //f.FormClosed += new FormClosedEventHandler(RefreshGridOnFormChildClose);
        }
        private void FrmListBill_Load(object sender, EventArgs e)
        {
            loadData();
            timer2.Start();
            timer2.Enabled = true;
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
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
