namespace Exercicio5
{
    public abstract class OperacaoMatematica
    {
        private double? x, y;

        public double? X { get => x; set => x = value; }
        public double? Y { get => y; set => y = value; }

        public abstract double? calcula();
    }
}