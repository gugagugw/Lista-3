/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 03 - Laços de Repetição
@Autor: Gustavo Pereira de Barros
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int tipoItem, maxInv, invAtual = 0;

        do {
            Console.Clear();
            Console.Write("Digite quantos tipos de itens quer armazenar: ");
            int.TryParse(Console.ReadLine(), out tipoItem);
        } while (tipoItem <= 0);

        String[] nomeItem = new string[tipoItem];
        int[] qntItem = new int[tipoItem];

        for(int i = 0; i < tipoItem; i++) {
            Console.Clear();

            Console.Write("Digite o nome do item: ");
            nomeItem[i] = Console.ReadLine();
            Console.Write("\nDigite a quantidade de itens: ");
            int.TryParse(Console.ReadLine(), out qntItem[i]);
            invAtual = invAtual + qntItem[i];
        }

        Console.Clear();
        Console.Write("Digite a capacidade máxima do inventário: ");
        int.TryParse(Console.ReadLine(), out maxInv);

        Console.Clear();
        
        if(invAtual > maxInv) {
            Console.WriteLine($"Total: {invAtual} itens. Excede da capacidade.");  
        } else {
            Console.WriteLine($"Total: {invAtual} itens. Dentro da capacidade.");
        }

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}