// Exercício 04
// Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso.
class Exercicio04 {
    public static void Executar() {
        // Solicita a entrada da idade
        Console.WriteLine("Digite a idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Verifica em qual faixa etária a idade se encaixa e imprime a mensagem correspondente
        if (idade <= 13)
        {
            Console.WriteLine("Criança");
        }
        else if (idade > 13 && idade <= 18)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade > 18 && idade <= 60)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Idoso");
        } 
    }
}