namespace Exercicio1
{
    abstract class MainAccount
    {
        #region attrs
        string? pwd;
        int? accountNumber;
        double? balance;
        #endregion

        #region constructor
        public MainAccount(string pwd) {
            this.pwd = pwd;
        }
        #endregion

        #region props 
        public virtual string? Pwd
        {
            get { return this.pwd; }
            set { this.pwd = value; }
        }
        public virtual int? AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public virtual double? Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        #endregion

        #region methods
        public MainAccount changePWD(string actualPwd, string newPwd, string confirmPwd) {
            if (actualPwd != this.pwd)
                throw new Exception("You must have to enter the corrent actual password");
            if (newPwd != confirmPwd)
                throw new Exception("The new password need to be the same of confirm pwd");
            this.pwd = newPwd;
            return this;
        }
        #endregion

        #region abs
        public abstract MainAccount Withdraw(double value);
        public abstract MainAccount Deposit(double value);
        public abstract string Statement();
        #endregion
    }
}