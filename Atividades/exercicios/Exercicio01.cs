// Exercício 01
// Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.
class Exercicio01 {
    public static void Executar() {
        // Solicita a entrada da altura e largura do retângulo
        Console.WriteLine("Digite a altura do retângulo:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a largura do retângulo:");
        double largura = Convert.ToDouble(Console.ReadLine());

        // Calcula a área do retângulo
        double area = altura * largura;

        // Exibe o resultado
        Console.WriteLine("A área do retângulo é: " + area);
    }
}
