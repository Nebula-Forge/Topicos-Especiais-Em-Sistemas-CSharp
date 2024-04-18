// Exercício 03
// Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.
class Exercicio03 {
    public static void Executar() {
        // Solicita a entrada dos números
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Verifica qual é o menor e qual é o maior
        int menor, maior;

        if (numero1 < numero2)
        {
            menor = numero1;
            maior = numero2;
        }
        else
        {
            menor = numero2;
            maior = numero1;
        }

        // Exibe os resultados
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"O maior número é: {maior}");
    }
}