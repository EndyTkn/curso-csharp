namespace Exercicio5
{
    public class Multiplicacao : OperacaoMatematica
    {
        public override double? calcula()
        {
            return base.X * base.Y;
        }
    }
}