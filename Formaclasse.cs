/* namespace Projeto
{
    abstract class formaClasse
    {
        private int? x, y;

        public formaClasse()
        {
            this.x = 10;
            this.y = 20;
        }

        #region 
        public abstract int? X
        {
            get;
            set;
        }

        public int? Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        #endregion
        abstract public int? Area();


    }

    class Quadrado : formaClasse
    {
        public override int? Area()
        {
            return this.X + this.Y;
        }

        public override int? X
        {
            get { return this.X; }
            set { this.X = value * 2; }
        }
    }
}

 */