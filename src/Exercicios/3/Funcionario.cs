namespace Exercicio3 {
    abstract class Funcionario {
        private string? nome;
        private double? salario;

        #region props
        public virtual string? Nome {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public virtual double? Salario {
            get { return this.salario; }
            set { this.salario = value; }
        }

        #endregion
        #region Abstract Methods
        public abstract double? AumentaSalario();
        #endregion
    }
}