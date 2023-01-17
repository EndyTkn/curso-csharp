using Exercicio1;
using Exercicio2;
using Exercicio3;
using Exercicio4;
using Exercicio5;
using Extensions;

void MenuExercicios()
{
    var opcoes = new string[] {"Exercicio1", "Exercicio2", "Exercicio3", "Exercicio4", "Exercicio5"};
    Helpers.ImprimirOpcoes(opcoes);
}

void HandleExercicios(int? opcao) {
    Helpers.Exercise exercicio = new ExercicioMain1();
    switch(opcao) {
        case 1: exercicio = new ExercicioMain2();break;
        case 2: exercicio = new ExercicioMain3();break;
        case 3: exercicio = new ExercicioMain4();break;
        case 4: exercicio = new ExercicioMain5();break;
    }
    exercicio.start();
}


while (true)
{
    MenuExercicios();
    var input = Helpers.Input("Digite sua Opção:").ToInt();
    Console.Clear();
    HandleExercicios(input);

}
