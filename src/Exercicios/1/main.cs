namespace Exercicio1
{
    class ExercicioMain1 : Helpers.Exercise
    {
        public override void start()
        {
            const string pwd = "123";
            Console.WriteLine($"Senha Atual: {pwd}");
            var actualPwd = Helpers.Input("Digite a senha atual:");
            var newPwd = Helpers.Input("Digite a senha nova:");
            var confirmPwd = Helpers.Input("Digite novamente a senha nova:");

            var currentAccount = new CurrentAccount(pwd);
            currentAccount.changePWD(actualPwd, newPwd, confirmPwd);
            Helpers.Input("Senha alterada com sucesso! Aperte Enter para continuar");
            Console.Clear();
        }
    }
}