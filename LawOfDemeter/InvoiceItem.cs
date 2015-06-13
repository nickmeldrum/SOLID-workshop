using System;
using System.Collections.Generic;
using System.Text;

namespace LawOfDemeter
{
    public class InvoiceItem
    {


        private string itemName;
        private int quantity;
        private double unitPrice;

        public InvoiceItem(string itemName, int quantity, double unitPrice)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public double Subtotal
        {
            get { return unitPrice * quantity; }
        }

    }
}
