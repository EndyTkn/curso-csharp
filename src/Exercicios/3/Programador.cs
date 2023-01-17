namespace Exercicio3 {
    sealed class Programador : Funcionario {
        public Programador() {
            this.Nome = "Vanderlei Carvalho Programador";
            this.Salario = 1000;
        }

        public override double? AumentaSalario() {
            var aumento = base.Salario * 0.2;
            base.Salario = base.Salario + aumento;
            return base.Salario;
        }
    }
}