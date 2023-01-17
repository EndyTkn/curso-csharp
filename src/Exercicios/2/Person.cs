namespace Exercicio2 {
    class Person {
        private string? name;
        private int? age;

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public Person(){
            this.name = "undefined";
            this.age = 5;
        }

        #region props
        public virtual string? Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual int? Age {
            get { return this.age; }
            set { this.age = value; }
        }
        #endregion
    }
}