using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPharma
{
   public  class BillPrint
    {
        public string MatBill { get; private set; }
        public string MatDrug { get; set; }
        public string NameDrug { get; set; }
        public string CategoryDrug { get; set; }
        public string DrugPicture { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string PharmacyLogo { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public BillPrint()
        {
        }

        public BillPrint(string matBill, string matDrug, string nameDrug, 
                        string categoryDrug, string drugPicture, int quantity, 
                        double unitPrice, string pharmacyLogo, 
                         long contact, string email, DateTime date)
        {
            MatBill = matBill;
            MatDrug = matDrug;
            NameDrug = nameDrug;
            CategoryDrug = categoryDrug;
            DrugPicture = drugPicture;
            Quantity = quantity;
            UnitPrice = unitPrice;
            PharmacyLogo = pharmacyLogo;
            Contact = contact;
            Email = email;
            Date = date;
        }

        public override bool Equals(object obj)
        {
            return obj is BillPrint print &&
                   MatBill == print.MatBill;
        }

        public override int GetHashCode()
        {
            int hashCode = 1347097117;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MatBill);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }
    }
}
