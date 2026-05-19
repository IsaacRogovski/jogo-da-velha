using System;

namespace jogo_da_velha
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[,] tabuleiro = {
                {"   ","   ","   "},
                {"   ","   ","   "},
                {"   ","   ","   "}
                };
            bool turno = false;
            int jogadas = 0;
            while (true)
            {
                int linha, coluna;
                string jogador;
                Console.Clear();
                Console.WriteLine("┌───┬───┬───┐");
                Console.WriteLine($"│{tabuleiro[0, 0]}│{tabuleiro[0, 1]}│{tabuleiro[0, 2]}│");
                Console.WriteLine("├───┼───┼───┤");
                Console.WriteLine($"│{tabuleiro[1, 0]}│{tabuleiro[1, 1]}│{tabuleiro[1, 2]}│");
                Console.WriteLine("├───┼───┼───┤");
                Console.WriteLine($"│{tabuleiro[2, 0]}│{tabuleiro[2, 1]}│{tabuleiro[2, 2]}│");
                Console.WriteLine("└───┴───┴───┘");

                // ------------ X na horizontal

                if (tabuleiro[0, 0] == " X " && tabuleiro[0, 1] == " X " && tabuleiro[0, 2] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }
                else if (tabuleiro[1, 0] == " X " && tabuleiro[1, 1] == " X " && tabuleiro[1, 2] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }
                else if (tabuleiro[2, 0] == " X " && tabuleiro[2, 1] == " X " && tabuleiro[2, 2] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }

                // ------------ X na vertical

                else if (tabuleiro[0, 0] == " X " && tabuleiro[1, 0] == " X " && tabuleiro[2, 0] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }
                else if (tabuleiro[0, 1] == " X " && tabuleiro[1, 1] == " X " && tabuleiro[2, 1] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == " X " && tabuleiro[1, 2] == " X " && tabuleiro[2, 2] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }

                // ------------- X na diagonal

                else if (tabuleiro[0, 0] == " X " && tabuleiro[1, 1] == " X " && tabuleiro[2, 2] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == " X " && tabuleiro[1, 1] == " X " && tabuleiro[2, 0] == " X ")
                {
                    Console.WriteLine("\nO jogador X venceu!");
                    break;
                }

                // ------------ O na horizontal

                if (tabuleiro[0, 0] == " O " && tabuleiro[0, 1] == " O " && tabuleiro[0, 2] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }
                else if (tabuleiro[1, 0] == " O " && tabuleiro[1, 1] == " O " && tabuleiro[1, 2] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }
                else if (tabuleiro[2, 0] == " O " && tabuleiro[2, 1] == " O " && tabuleiro[2, 2] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }

                // ------------ O na vertical

                else if (tabuleiro[0, 0] == " O " && tabuleiro[1, 0] == " O " && tabuleiro[2, 0] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }
                else if (tabuleiro[0, 1] == " O " && tabuleiro[1, 1] == " O " && tabuleiro[2, 1] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == " O " && tabuleiro[1, 2] == " O " && tabuleiro[2, 2] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }

                // ------------- O na diagonal

                else if (tabuleiro[0, 0] == " O " && tabuleiro[1, 1] == " O " && tabuleiro[2, 2] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }
                else if (tabuleiro[0, 2] == " O " && tabuleiro[1, 1] == " O " && tabuleiro[2, 0] == " O ")
                {
                    Console.WriteLine("\nO jogador O venceu!");
                    break;
                }

                // ver se ta com velha

                if (jogadas >= 9)
                {
                    Console.WriteLine("\nDeu velha!");
                    break;
                }


                if (!turno)
                {
                    jogador = "X";
                    turno = true;
                }
                else
                {
                    jogador = "O";
                    turno = false;
                }
                Console.WriteLine($"\nVez do {jogador}\n");
                while (true)
                {

                    linha = lerNumeroInteiro("Insira a linha que dejesa jogar (1,2 ou 3): ", 1, 3) - 1;
                    coluna = lerNumeroInteiro("Insira a coluna que dejesa jogar (1,2 ou 3):", 1, 3) - 1;
                    if (tabuleiro[linha, coluna] == "   ")
                    {
                        jogadas++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nA cordenada escolhida já esta preenchida!\n");
                    }
                }
                tabuleiro[linha, coluna] = $" {jogador} ";

            }


        }
        public static int lerNumeroInteiro(string enunciado, int valorMinimo, int valorMaximo)
        {
            int valor;
            Console.Write(enunciado);
            while (!int.TryParse(Console.ReadLine(), out valor) || valorMinimo > valor || valor > valorMaximo)
            {

                Console.WriteLine("Insira um valor valido!");
                Console.Write(enunciado);
            }

            return valor;
        }
    }
}