using Extensions;

namespace Exercicio5 {
    public class ExercicioMain5 : Helpers.Exercise
    {
        private OperacaoMatematica operacao;
        
        public ExercicioMain5() {
            this.operacao = new Soma();
        }

        private int? Menu() {
            var opcoes = new string[]{"Soma", "Subtracao", "Multiplicacao", "Divisao"};
            Helpers.ImprimirOpcoes(opcoes);
            return Helpers.Input("Digite a opção desejada:").ToInt();
        }

        private void GetNumeros() {
            var x = Helpers.Input("Digite o primeiro numero:").ToDouble();
            var y = Helpers.Input("Digite o segundo numero:").ToDouble();
            this.operacao.X = x;
            this.operacao.Y = y;
        }

        private void onInputOpcao(int? opcao) {
            this.operacao = new Soma();
            switch(opcao) {
                case 1: this.operacao = new Subtracao();break;
                case 2: this.operacao = new Multiplicacao();break;
                case 3: this.operacao = new Divisao();break;
            }
        }

        private void ImprimeResultado() {
            Console.WriteLine($"Resultado da Operacao: {this.operacao.calcula()}");
        }

        public override void start()
        {
            var opcao = Menu();
            onInputOpcao(opcao);
            GetNumeros();
            ImprimeResultado();
            Helpers.Input("Aperte Enter para continuar");
            Console.Clear();
        }
    }
}