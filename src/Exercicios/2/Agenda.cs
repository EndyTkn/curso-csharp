using  Extensions;
namespace Exercicio2
{
    class Agenda
    {
        private List<Person>? people;
        private int? contFriends;
        private int? contFamiliars;

        #region constructor
        public Agenda()
        {
            this.people = InitPeople(2, 4);
        }
        #endregion

        #region props
        public virtual List<Person>? People
        {
            get { return this.people; }
            set { this.people = value; }
        }
        public virtual int? ContFriends
        {
            get { return this.contFriends; }
            set { this.contFriends = value; }
        }

        public virtual int? ContFamiliars
        {
            get { return this.contFamiliars; }
            set { this.contFamiliars = value; }
        }
        #endregion

        private List<Person>? InitPeople(int min, int max)
        {
            Random rnd = new Random();
            Person getRndPerson()
            {
                var rndChoice = rnd.Next(0, 2) == 1;
                if (rndChoice)
                    return new Friend();
                return new Familiar();
            }
            int lenPeople = rnd.Next(min, max);
            List<Person>? people = new List<Person>();

            for (var i = 0; i < lenPeople; i++)
            {
                people.Add(getRndPerson());
            }
            return people;
        }

        public string[]? GetPeopleType()
        {
            return this.people?.Select(person => person.GetType().ToString()).ToArray();
        }

        public void GetFriendsBirthday()
        {
            if (this.people == null) return;
            var people = this.people.Where(person => person is Friend);
            foreach (var person in people) {
                var friend = (Friend) person;
                Console.WriteLine(friend.BirthdayDate);
            }
        }

        public void getFamiliarEmails()
        {
            if (this.people == null) return;
            var people = this.people.Where(person => person is Familiar);
            foreach (var person in people) {
                var familiar = (Familiar) person;
                Console.WriteLine(familiar.Email);
            }
        }

        public void addData()
        {
            if (this.people == null) return;

            void onFriend(in Friend person) {
                var validDate = false;
                DateTime date = new DateTime();
                while(!validDate) {
                    var dateStr = Helpers.Input("Digite uma Data de Nascimento válida:");
                    validDate = DateTime.TryParse(dateStr, out date);
                }
                person.BirthdayDate = date;
            }

            void onFamiliar(in Familiar person) {
                person.Email = Helpers.Input("Digite um email:");
            }

            void onPersonType(in Person person) {
                if (person is Friend)
                    onFriend((Friend) person);
                else
                    onFamiliar((Familiar) person);
            }
            
            foreach (var person in this.people) {
                Console.WriteLine("\nPróxima Pessoa");
                person.Name = Helpers.Input("Digite o Nome:");
                person.Age = Helpers.Input("Digite a Idade:").ToInt();
                onPersonType(person);
            }
        }
    }
}