using Extensions;

namespace Exercicio3
{
    class ExercicioMain3 : Helpers.Exercise
    {
        Programador programador = new Programador();
        Gerente gerente = new Gerente();
        private void Menu()
        {
            var opcoes = new string[] { "Imprimir Dados", "Aumentar Salário", "Exit" };
            Helpers.ImprimirOpcoes(opcoes);
        }
        private void onOption(int? inputOption)
        {
            switch (inputOption)
            {
                case 0: MenuFuncionario(ImprimirDados); break;
                case 1: MenuFuncionario(AumentarSalario); break;
                case 2: System.Environment.Exit(0); break;
            }
        }

        private void MenuFuncionario(Func<Funcionario, string> callback)
        {
            var resul = "";
            var opcoes = new string[] { "Gerente", "Programador" };
            Helpers.ImprimirOpcoes(opcoes);

            var inputOption = Helpers.Input("Digite sua opção:").ToInt();

            switch (inputOption)
            {
                case 0: resul = callback(this.gerente); break;
                case 1: resul = callback(this.programador); break;
            }
            Console.WriteLine(resul);
        }

        private string ImprimirDados(Funcionario funcionario)
        {
            return $"Nome: {funcionario.Nome}\nSalario: {funcionario.Salario}";
        }

        private string AumentarSalario(Funcionario funcionario)
        {
            return $"Novo Salario: {funcionario.AumentaSalario()}";
        }

        public override void start()
        {
            while (true)
            {
                Menu();
                var input = Helpers.Input("Digite a sua Opção:").ToInt();
                Console.Clear();
                onOption(input);
                Helpers.Input("Aperte Enter para continuar");
                Console.Clear();
            }
        }
    }
}