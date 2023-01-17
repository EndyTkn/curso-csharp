namespace Exercicio1 {
    class SavingAccounts : MainAccount
    {
        public SavingAccounts(string pwd): base(pwd) {}
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

        public double incomeRate()
        {
            return 0; 
        }
    }
}