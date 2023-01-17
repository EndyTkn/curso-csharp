namespace Exercicio2
{
    class Friend : Person
    {
        private DateTime birthdayDate;

        #region constructor
        public Friend() : base()
        {
            this.birthdayDate = new DateTime();
        }
        #endregion

        #region props
        public virtual DateTime BirthdayDate
        {
            get { return this.birthdayDate; }
            set { this.birthdayDate = value; }
        }
        #endregion
    }
}