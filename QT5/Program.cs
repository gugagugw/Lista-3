/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente.
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso,
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os
bônus se aplicável.
Observações:
• Sem considerar bônus (Input 4 = Não): Apenas soma das recompensas diárias.
• Considerando bônus (Input 4 = Sim): Além da soma das recompensas diárias,
adiciona o bônus a cada marco alcançado.

@Lista: 03 - Laços de Repetição
@Autor: Gustavo Pereira de Barros
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int diasLogados, recompensa, incremento, moedas = 0;

        Console.Write("Digite quantos dias você logou no jogo: ");
        int.TryParse(Console.ReadLine(), out diasLogados);

        Console.Write("Digite a recompensa do primeiro dia: ");
        int.TryParse(Console.ReadLine(), out recompensa);

        Console.Write("Digite o incremento de moedas por dia logado: ");
        int.TryParse(Console.ReadLine(), out incremento);

        for(int i = 0; i < diasLogados; i++) {
            moedas = moedas + (recompensa + (50 * i));
        }

        Console.WriteLine($"Você conseguiu: {moedas} moedas");

        Console.WriteLine("\nPressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}