internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha um dos exercícios de 1 a 6:");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Exercicio01.Executar();
                break;
            case 2:
                Exercicio02.Executar();
                break;
            case 3:
                Exercicio03.Executar();
                break;
            case 4:
                Exercicio04.Executar();
                break;
            case 5:
                Exercicio05.Executar();
                break;
            case 6:
                Exercicio06.Executar();
                break;
            default:
                Console.WriteLine("Exercício inválido escolhido.");
                break;
        }
    }
}