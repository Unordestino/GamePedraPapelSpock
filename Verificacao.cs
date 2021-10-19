using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapel
{
    class Verificacao
    {
        public string rajesh;
        public string sheldon;

        public int PlacarR { get; set; }
        public int PlacarS { get; set; }
        public Boolean JogadorAtual { get; set; }

        public void Tela()
        {
            Invert();
            MJogadorAtual();
            Console.Clear();
            Console.SetCursorPosition(70, 5);
            Console.WriteLine("Placar Atual - Sheldon: " + PlacarS + " Rajesh: " + PlacarR);
            Console.SetCursorPosition(70, 8);
            Console.WriteLine("Jogador atual: " + MJogadorAtual());
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Vamos Jogar de Pedra, Papel, Tesoura, Lagarto, Spock!!!");

        }

        public void Invert()
        {
            if (JogadorAtual == true) JogadorAtual = false;
            else JogadorAtual = true;
        }

        public Verificacao()
        {
            rajesh  = "Rajesh";
            sheldon = "Sheldon";
            PlacarR = 0;
            PlacarS = 0;
            JogadorAtual = false;
           
        }

        public void verifica(string op, string op2)
        {
            if (op == Itens.Tesoura.ToString() && op2 == Itens.Papel.ToString() || op2 == Itens.Tesoura.ToString() && op == Itens.Papel.ToString()) 
            {
                Invert();
                if (op2 == Itens.Tesoura.ToString())  JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Papel.ToString() && op2 == Itens.Pedra.ToString() || op2 == Itens.Papel.ToString() && op == Itens.Pedra.ToString())
            {
                Invert();
                if (op2 == Itens.Papel.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Pedra.ToString() && op2 == Itens.Lagarto.ToString() || op2 == Itens.Pedra.ToString() && op == Itens.Lagarto.ToString())
            {
                Invert();
                if (op2 == Itens.Pedra.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Lagarto.ToString() && op2 == Itens.Spock.ToString() || op2 == Itens.Lagarto.ToString() && op == Itens.Spock.ToString())
            {
                Invert();
                if (op2 == Itens.Lagarto.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Spock.ToString() && op2 == Itens.Tesoura.ToString() || op2 == Itens.Spock.ToString() && op == Itens.Tesoura.ToString())
            {
                Invert();
                if (op2 == Itens.Spock.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Tesoura.ToString() && op2 == Itens.Lagarto.ToString() || op2 == Itens.Tesoura.ToString() && op == Itens.Lagarto.ToString())
            {
                Invert();
                if (op2 == Itens.Tesoura.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Lagarto.ToString() && op2 == Itens.Papel.ToString() || op2 == Itens.Lagarto.ToString() && op == Itens.Papel.ToString())
            {
                Invert();
                if (op2 == Itens.Lagarto.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Papel.ToString() && op2 == Itens.Spock.ToString() || op2 == Itens.Papel.ToString() && op == Itens.Spock.ToString())
            {
                Invert();
                if (op2 == Itens.Papel.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Spock.ToString() && op2 == Itens.Pedra.ToString() || op2 == Itens.Spock.ToString() && op == Itens.Pedra.ToString())
            {
                Invert();
                if (op2 == Itens.Spock.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }
            else if (op == Itens.Pedra.ToString() && op2 == Itens.Tesoura.ToString() || op2 == Itens.Pedra.ToString() && op == Itens.Tesoura.ToString())
            {
                Invert();
                if (op2 == Itens.Pedra.ToString()) JogadorAtual = false;
                Console.WriteLine("Parabéns " + MJogadorAtual() + " Você Ganhou!");
                PlacarAtual();
            }



        }



        public int PlacarAtual()
        {
            if (JogadorAtual == true) return PlacarR++;
            return PlacarS++;
        }

        public string MJogadorAtual()
        {
            if (JogadorAtual == true) return "Rajesh";
            return "Sheldon";
        }

        
    }
}
