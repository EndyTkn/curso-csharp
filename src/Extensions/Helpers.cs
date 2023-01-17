public static class Helpers
{
    public static string Input(string text)
    {
        Console.WriteLine(text);
        return Console.ReadLine() ?? "";
    }
    public static void ImprimirOpcoes(string[] opcoes)
    {
        for (var i = 0; i < opcoes.Length; i++)
            Console.WriteLine($"[{i}] {opcoes[i]}");
    }

    public abstract class Exercise {
        public abstract void start();
    }
}