namespace Exercicio4 {
    public class ExercicioMain4 : Helpers.Exercise
    {
        public override void start()
        {
            var circulo = new Circulo() {
                Raio = 2
            };
            var quadrado = new Quadrado() {
                Lado = 5
            };
            Console.WriteLine(circulo.ToString());
            Console.WriteLine(quadrado.ToString());
        }
    }
}