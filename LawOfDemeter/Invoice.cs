using System.Collections.Generic;

namespace LawOfDemeter
{
     public class Invoice {
    	
	    public const double SHIPPING_COST_OUTSIDE_EU = 10;
	    private IList<InvoiceItem> invoiceItems = new List<InvoiceItem>();
        private Country country;

        public Invoice(Country country)
        {
            this.country = country;
        }

         public void AddItem(InvoiceItem invoiceItem) {
		    invoiceItems.Add(invoiceItem);
	    }

	    public double TotalPrice {

            get {
		        double invoiceTotal = 0;
        		
		        foreach (InvoiceItem invoiceItem in invoiceItems) {

			        invoiceTotal += invoiceItem.Subtotal;
		        }
        		
		        if(!country.IsInEurope){
			        invoiceTotal += SHIPPING_COST_OUTSIDE_EU;
		        }
		        return invoiceTotal;
            }
	    }
     }
}
