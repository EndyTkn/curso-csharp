namespace Exercicio5
{
    public class Soma : OperacaoMatematica
    {
        public override double? calcula()
        {
            return base.X + base.Y;
        }
    }
}