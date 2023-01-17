namespace Exercicio4
{
    public abstract class FormaGeometrica
    {
        #region abstract methods
        public abstract double? Area();
        public abstract double? Comprimento();
        #endregion

        public override string? ToString()
        {
            return $"Area: {this.Area()}\n" + $"Comprimento: {this.Comprimento()}";
        }
    }
}