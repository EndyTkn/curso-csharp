namespace Exercicio3 {
    sealed class Gerente : Funcionario {
        public Gerente() {
            this.Nome = "Miguel Sampaio Gerente";
            this.Salario = 1000;
        }
        public override double? AumentaSalario() {
            var aumento = base.Salario * 0.1;
            base.Salario = base.Salario + aumento;
            return base.Salario;
        }
    }
}