using Ardalis.SmartEnum;

namespace Invoice.Service.Models
{
    public abstract class InvoiceType : SmartEnum<InvoiceType>
    {
        private InvoiceType(string name, int value) : base(name, value)
        {
        }

        public static readonly InvoiceType AccountsPayable = new AccountsPayableType();
        public static readonly InvoiceType AccountsReceivable = new AccountsReceivableType();

        private class AccountsPayableType : InvoiceType
        {
            public AccountsPayableType() : base(nameof(AccountsPayable), 1)
            {
            }
        }

        private class AccountsReceivableType : InvoiceType
        {
            public AccountsReceivableType() : base(nameof(AccountsReceivable), 2)
            {
            }
        }
    }
}