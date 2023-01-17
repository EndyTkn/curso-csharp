namespace Exercicio4
{
    public class Circulo : FormaGeometrica
    {
        private double? raio;

        #region props
        public virtual double? Raio
        {
            get { return this.raio; }
            set { this.raio = value; }
        }
        #endregion

        public override double? Area()
        {
            return this.raio * this.raio * Math.PI;
        }

        public override double? Comprimento()
        {
            return 2 * this.raio * Math.PI;
        }

        public override string? ToString()
        {
            return $"CIRCULO\nRaio: {this.raio}\n" + base.ToString();
        }
    }
}