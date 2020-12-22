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
            billBLO = new BillBLO(ConfigurationManager.AppSettings["DbFolder"]);
            //  pharmacyBLO = new PharmacyBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        public FrmBill(Action callback) : this()
        {
            this.callBack = callBack;
        }
        public FrmBill(Bill bill, Action callback) : this(callback)
        {
            this.oldbill = bill;
            txtNumFact.Text = bill.MatBill;
            txtNumDrug.Text = bill.MatDrug;
            txtNameDrug.Text = bill.NameDrug;
            ComboBoxCat.Text = bill.CategoryDrug;
            double.Parse(ComboBoxUnit.Text);
            int.Parse(ComboBoxUnit.Text);





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

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
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

                txtNumDrug.Text.ToUpper(),
                txtNameDrug.Text.ToUpper(),
                ComboBoxCat.Text.ToUpper(),
                int.Parse(txtQuan.Text),
                double.Parse(ComboBoxUnit.Text)

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
                txtNumDrug.Clear();
                txtNameDrug.Clear();
                txtQuan.Clear();
                ComboBoxCat.SelectedValue = null;
                ComboBoxUnit.SelectedValue = 0;
                txtNumFact.Focus();
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
    }
}
