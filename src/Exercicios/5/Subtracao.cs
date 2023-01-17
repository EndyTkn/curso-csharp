namespace Exercicio5
{
    public class Subtracao : OperacaoMatematica
    {
        public override double? calcula()
        {
            return base.X - base.Y;
        }
    }
}