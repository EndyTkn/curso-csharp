namespace Exercicio4 {
    public class Quadrado : FormaGeometrica
    {
        private double? lado;

        public virtual double? Lado { get => lado; set => lado = value; }

        public override double? Area()
        {
            return this.lado * this.lado;
        }

        public override double? Comprimento()
        {
            return this.lado;
        }

        public override string? ToString() {
            return $"QUADRADO\nLado: {this.lado}\n" + base.ToString();
        }
    }
}