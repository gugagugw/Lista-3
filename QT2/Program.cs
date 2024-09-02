/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo
• Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Laços de Repetição
@Autor: Gustavo Pereira de Barros
@Data: 27/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int qntMissao, inimigoMorto, pontos = 0, dificuldade;
        Console.Write("Digite o número de missões feitas: ");
        int.TryParse(Console.ReadLine(), out qntMissao);

        for (int i = 1; i <= qntMissao; i++) {
            Console.Clear();

            Console.Write("Digite o nível de dificuldade da missão\n1- Fácil 2- Médio 3- Difícil\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out dificuldade);

            Console.Write("Digite a quantidade de inimigos mortos: ");
            int.TryParse(Console.ReadLine(), out inimigoMorto);
            
            if (dificuldade == 1) {
                pontos = pontos + (inimigoMorto * 50);
            } else if (dificuldade == 2) {
                pontos = pontos + (inimigoMorto * 100);
            } else {
                pontos = pontos + (inimigoMorto * 150);
            }
        }

        System.Console.WriteLine($"{pontos} Pontos");

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}