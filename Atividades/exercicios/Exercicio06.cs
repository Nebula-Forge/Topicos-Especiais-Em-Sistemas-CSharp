// Exercício 06
// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.

// 1. Desenvolver o algoritmo de ordenação (Bubble Sort);
// 2. Utilizar uma função em C# para ordenação;
class Exercicio06
{
    public static void Executar()
    {
        // Gera um vetor de 1000 valores automaticamente
        int[] vetor = GerarVetor(1000);

        // Ordena o vetor usando o algoritmo Bubble Sort
        OrdenarVetor(vetor);

        // Exibe o vetor ordenado
        Console.WriteLine("Vetor ordenado:");
        ImprimirVetor(vetor);
    }
    static int[] GerarVetor(int tamanho)
    {
        Random random = new Random();
        int[] vetor = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = random.Next(10000); // Valores aleatórios até 10000
        }
        return vetor;
    }
    static void OrdenarVetor(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho - 1; i++)
        {
            for (int j = 0; j < tamanho - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    int temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
    static void ImprimirVetor(int[] vetor)
    {
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}