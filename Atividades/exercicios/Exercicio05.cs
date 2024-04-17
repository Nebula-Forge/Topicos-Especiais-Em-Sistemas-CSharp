// Exercício 05
// Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número **15**, o programa deve imprimir na tela os números **0, 1, 1, 2, 3, 5, 8, 13**.
class Exercicio05
{
    public static void Executar()
    {
        Console.WriteLine("Digite um valor positivo inteiro:");
        int valor = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        // Imprime os números da sequência de Fibonacci até atingir ou ultrapassar o valor inserido
        Console.Write("Sequência de Fibonacci até " + valor + ": ");
        Console.Write(a + ", " + b + ", ");
        while (a + b <= valor)
        {
            int temp = a + b;
            Console.Write(temp + ", ");
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}
