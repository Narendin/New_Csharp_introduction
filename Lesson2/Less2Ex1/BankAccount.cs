namespace Less2Ex1
{
    public class BankAccount
    {
        private int _id;
        private decimal _balance;
        private AccountType _accountType;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public AccountType AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = AccountType;
            }
        }

        public override string ToString()
        {
            return $"Номер счета: {_id}; Тип счета: {_accountType}; Остаток на текущий момент, руб.: {_balance}.";
        }
    }
}