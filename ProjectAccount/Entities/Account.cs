namespace ProjectAccount.Entities
{
    class Account
    {
        public int Number  { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amont)
        {
            Balance -= amont;
        }
        public void Deposit(double amont)
        {
            Balance += amont;
        }
    }
}
