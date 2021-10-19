using System;

namespace PedraPapel
{
    class Program
    {
        static void Main(string[] args)
        {
            Verificacao v1 = new Verificacao();
            int op = 0;

            while (op != 2)
            {
                try
                {
                    v1.JogadorAtual = false;
                    v1.Tela();
                    Console.Write("\nRajesh, Digite Sua opção: ");
                    string opcao1 = Console.ReadLine();
                    if (opcao1 != "Tesoura" && opcao1 != "Papel" && opcao1 != "Lagarto" && opcao1 != "Pedra" && opcao1 != "Spock")
                    {
                        throw new GameExeption("\nOpção inválida! Digite Pedra, Papel, Tesoura, Lagarto, Spock!!!");
                    }
                    v1.Tela();
                    Console.Write("\nSheldon, Digite Sua opção: ");
                    string opcao2 = Console.ReadLine();
                    if (opcao2 != "Tesoura" && opcao2 != "Papel" && opcao2 != "Lagarto" && opcao2 != "Pedra" && opcao2 != "Spock")
                    {
                        throw new GameExeption("\nOpção inválida! Digite Pedra, Papel, Tesoura, Lagarto, Spock!!!");
                    }

                    if(opcao1 == opcao2)
                    {
                        Console.WriteLine("\nBazinnga!!! Deu empate...");
                    }

                    v1.verifica(opcao1, opcao2);

                        Console.Write("\n\nDeseja Continuar?  1-Sim 2-Não: ");
                        int.TryParse(Console.ReadLine(), out op);
                        if (op == 2) return;
                        if (op != 1 && op != 2)
                        {
                            throw new GameExeption("\nDigite uma opção válida!!!");

                        }
                
                }
                catch (GameExeption e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }

        }
    }
}
