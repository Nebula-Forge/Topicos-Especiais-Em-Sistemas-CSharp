// Exercício 02
// Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
// 1. Dólar (1 dólar = 5,17 reais)
// 2. Euro (1 euro = 6,14 reais)
// 3. Peso argentino (1 peso argentino = 0,05 reais)
class Exercicio02 {
    public static void Executar() {
        // Solicita a entrada do valor em reais
        Console.WriteLine("Digite o valor em reais (R$):");
        double valorEmReais = Convert.ToDouble(Console.ReadLine());

        // Realiza as conversões
        double valorEmDolar = valorEmReais / 5.17;
        double valorEmEuro = valorEmReais / 6.14;
        double valorEmPesoArgentino = valorEmReais / 0.05;

        // Exibe os resultados
        Console.WriteLine($"Valor em dólar: {valorEmDolar:F2}");
        Console.WriteLine($"Valor em euro: {valorEmEuro:F2}");
        Console.WriteLine($"Valor em peso argentino: {valorEmPesoArgentino:F2}");
    }
}