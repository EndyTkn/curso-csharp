namespace Exercicio2
{
    class Familiar : Person
    {
        private string? email;

        #region constructor
        public Familiar() : base()
        {
            this.email = "undefined@email.com";
        }
        #endregion

        #region props
        public virtual string? Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        #endregion
    }
}