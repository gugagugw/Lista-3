/*-------------------------------------------------------------------
Questão 1: Coleção de Itens Raros com Variações de Baús
Contextualização:
Em um jogo de exploração, o jogador pode abrir diferentes tipos de baús em uma masmorra.
Cada tipo de baú possui uma variação na quantidade de itens raros que pode conter.
Comando:
Crie um programa em C# que simule a coleta de itens raros a partir de diferentes tipos de baús.
O programa deve:
1. Perguntar ao jogador quantos baús ele deseja abrir.
2. Perguntar ao jogador quantos tipos diferentes de baús existem no jogo.
3. Para cada tipo de baú, perguntar quantos baús desse tipo o jogador deseja abrir.
Para cada baú aberto, dependendo do tipo, gerar aleatoriamente a quantidade de itens raros
obtidos:
• Tipo A: 0 a 3 itens
• Tipo B: 1 a 5 itens
• Tipo C: 2 a 6 itens
• (Adapte conforme o número de tipos definidos pelo jogador)
O programa deve calcular e exibir a quantidade total de itens raros obtidos após abrir todos os
baús.
@Lista: 03 - Laços de Repetição
@Autor: Gustavo Pereira de Barros
@Data: 27/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        Random random = new Random();

        int qntTotal, qntTipos, qntAbrir;

        Console.Write("Digite a quantidade total de baús:");
        int.TryParse(Console.ReadLine(), out qntTotal);
        
        Console.WriteLine("Digite a quantidade de tipos de baús:");
        int.TryParse(Console.ReadLine(), out qntTipos);

        for(int i = 1; i <= qntTipos; i++) {
            Console.Write($"No {i}° tipo, digite quantos serão abertos: ");
            int.TryParse(Console.ReadLine(), out qntAbrir);

            while(qntTotal - qntAbrir < 0) {
                Console.Write("Quantidade Insuficiente");
                int.TryParse(Console.ReadLine(), out qntAbrir);
            }
            qntTotal -= qntAbrir;

            for(int j = 1; j <= qntAbrir; j++) {
                Console.Write($"O {j}° baú do {i}° tipo é: {random.Next(0, 11)}");
            }
        }

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}