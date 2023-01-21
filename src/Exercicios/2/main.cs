namespace Exercicio2
{
    class ExercicioMain2 : Helpers.Exercise
    {
        public override void start()
        {
            var agenda = new Agenda();
            //agenda.addData();
            agenda.getFamiliarEmails();
            agenda.GetFriendsBirthday();
        }
    }
}