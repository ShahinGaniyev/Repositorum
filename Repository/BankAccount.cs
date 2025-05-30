namespace Repository
{
    internal class BankAccount
    {
        private string accountHolder;
        private decimal balance;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            // Only allow deposit if amount > 0
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void Withdraw(decimal amount)
        {
            // Only allow withdraw if balance is enough
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
