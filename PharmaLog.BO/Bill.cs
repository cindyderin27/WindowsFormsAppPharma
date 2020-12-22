﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaLog.BO
{
    [Serializable]
    public class Bill
    {
        public static int count = 0;
        public string MatBill { get; private set; }
        public string MatDrug  { get; set; }
        public string NameDrug { get; set; }
        public string CategoryDrug { get; set; }
        public string DrugPicture { get; set; }
        public int Quantity { get;set; }
        public double UnitPrice { get; set; }
        public string PharmacyLogo { get; set; }

        public Bill()
        {
            count++;
        }

        public Bill(string matDrug, string nameDrug, string categoryDrug,
            string drugPicture, int quantity, double unitPrice, string pharmacyLogo)
        {
            MatBill = "B"+count;
            MatDrug = matDrug;
            NameDrug = nameDrug;
            CategoryDrug = categoryDrug;
            DrugPicture = drugPicture;
            Quantity = quantity;
            UnitPrice = unitPrice;
            PharmacyLogo = pharmacyLogo;
        }

        public override bool Equals(object obj)
        {
            return obj is Bill bill &&
                   MatBill == bill.MatBill;
        }

        public override int GetHashCode()
        {
            return 351837860 + EqualityComparer<string>.Default.GetHashCode(MatBill);
        }
    }
}
