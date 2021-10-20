namespace Less3Ex1
{
    public class BankAccount
    {
        private readonly int _id;
        private decimal _balance;
        private AccountType _accountType;
        private static int _lastId;

        public BankAccount()
        {
            _id = GetNextId();
            _balance = 0;
            _accountType = AccountType.Deposit;
        }

        public BankAccount(decimal balance)
        {
            _id = GetNextId();
            _balance = balance;
            _accountType = AccountType.Deposit;
        }

        public BankAccount(AccountType accountType)
        {
            _id = GetNextId();
            _balance = 0;
            _accountType = accountType;
        }

        public BankAccount(decimal balance, AccountType accountType)
        {
            _id = GetNextId();
            _balance = balance;
            _accountType = accountType;
        }

        public int Id => _id;

        public decimal Balance => _balance;

        public AccountType AccountType => _accountType;

        private int GetNextId()
        {
            return ++_lastId;
        }

        public decimal GetMoney(decimal money)
        {
            if (_balance < money) return 0;
            _balance -= money;
            return money;
        }

        public void PutMoney(decimal money)
        {
            _balance += money;
        }

        public bool TransferFrom(ref BankAccount bankAccount, decimal money)
        {
            bankAccount.GetMoney(money);
            this.PutMoney(money);
            return true;
        }

        public override string ToString()
        {
            return $"Номер счета: {_id}; Тип счета: {_accountType}; Остаток на текущий момент, руб.: {_balance}.";
        }
    }
}