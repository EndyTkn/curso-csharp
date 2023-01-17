namespace Exercicio5
{
    public class Divisao : OperacaoMatematica
    {
        public override double? calcula()
        {
            return base.X / base.Y;
        }
    }
}