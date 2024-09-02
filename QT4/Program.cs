/*-------------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso,
em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas fases ele deseja jogar.
2. Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores
positivos indicam ganho e negativos indicam perda).
3. Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte
quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que
ele começa com 100 pontos de vida.

@Lista: 03 - Laços de Repetição
@Autor: Gustavo Pereira de Barros
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int fases, vida = 100, vidaAlt, cura, escolha;

        Console.Write("Digite quantas fases quer jogar: ");
        int.TryParse(Console.ReadLine(), out fases);

        for(int i = 0; i < fases; i++) {
            Console.Clear();

            Console.Write($"Fase: {i+1}\n\nDigite a alteração de vida (positivo se ganhou e negativo se perdeu): ");
            int.TryParse(Console.ReadLine(), out vidaAlt);
            vida = vida + vidaAlt;

            Console.Write("Usou cura?\n\n1-Sim  2-Não\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out escolha);
            if(escolha == 1) {
                Console.WriteLine("Digite quanto curou: ");
                int.TryParse(Console.ReadLine(), out cura);
                vida = vida + cura;
            }    
        }

        Console.WriteLine(vida);

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}