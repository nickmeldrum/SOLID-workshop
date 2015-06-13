namespace SingleResponsibility
{
    public class Reporter
    {
        public string ToXml(int payerAccountNumber, int payeeAccountNumber, double amount)
        {
            return "<BankTransfer amount='" + amount + "'>" +
                    "<Payer>" + payerAccountNumber + "</Payer>" +
                    "<Payee>" + payeeAccountNumber + "</Payee>" +
                    "</BankTransfer>";
        }
    }
}
