namespace Exercicio1
{
    class CurrentAccount : MainAccount
    {
        public CurrentAccount(string pwd): base(pwd)
        {

        }
        public override MainAccount Deposit(double value)
        {
            throw new NotImplementedException();
        }

        public override string Statement()
        {
            throw new NotImplementedException();
        }

        public override MainAccount Withdraw(double value)
        {
            throw new NotImplementedException();
        }

        public double transactionsAmount()
        {
            return 0;
        }
    }
}