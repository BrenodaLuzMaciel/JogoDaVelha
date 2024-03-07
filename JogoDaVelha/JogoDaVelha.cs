namespace JogoDaVelha
{
    class JogoDaVelha
    {
        private bool FimDeJogo;
        private char[] PecaDoJogo;
        private char Vez;
        private int Contador;

        public JogoDaVelha()
        {
            FimDeJogo = false;
            PecaDoJogo = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
            Vez = 'x';
            Contador = 0;
        }

        public void Iniciar()
        {
            while (!FimDeJogo)
            {
                RenderizarJogo();
                LerJogada();
                RenderizarJogo();
                VerificarFimJogo();
                MudarVez();
            }
        }

        private void VerificarFimJogo()
        {
            if (Contador < 5)
                return;

            if (vitoriaHorizontal() || VitoriaVertical() || VitoriaDiagonal())
            {
                FimDeJogo = true;
                Console.WriteLine($"Vitoria de {Vez}");
                return;
            }

            if (Contador == 9)
            {
                FimDeJogo = true;
                Console.WriteLine("Empate!!!");
                return;
            }
        }

        private bool vitoriaHorizontal()
        {
            bool vitoria1 = PecaDoJogo[0] == PecaDoJogo[1] && PecaDoJogo[0] == PecaDoJogo[2];
            bool vitoria2 = PecaDoJogo[3] == PecaDoJogo[4] && PecaDoJogo[3] == PecaDoJogo[5];
            bool vitoria3 = PecaDoJogo[6] == PecaDoJogo[7] && PecaDoJogo[6] == PecaDoJogo[8];
            return vitoria1 || vitoria2 || vitoria3;
        }

        private bool VitoriaVertical()
        {
            bool vitoria1 = PecaDoJogo[0] == PecaDoJogo[3] && PecaDoJogo[0] == PecaDoJogo[6];
            bool vitoria2 = PecaDoJogo[1] == PecaDoJogo[4] && PecaDoJogo[1] == PecaDoJogo[7];
            bool vitoria3 = PecaDoJogo[2] == PecaDoJogo[5] && PecaDoJogo[2] == PecaDoJogo[8];
            return vitoria1 || vitoria2 || vitoria3;
        }

        private bool VitoriaDiagonal()
        {
            bool vitoria1 = PecaDoJogo[0] == PecaDoJogo[4] && PecaDoJogo[0] == PecaDoJogo[8];
            bool vitoria2 = PecaDoJogo[2] == PecaDoJogo[4] && PecaDoJogo[2] == PecaDoJogo[6];
            return vitoria1 || vitoria2;
        }

        private void MudarVez()
        {
            Vez = Vez == 'x' ? 'o' : 'x';
        }

        private void LerJogada()
        {
            Console.Write($"{Vez} digite um número de 1 a 9 que esteja disponível: ");
            bool eUmNumero = int.TryParse(Console.ReadLine(), out int posicaoPeca);

            while (!eUmNumero || !posicaoVazia(posicaoPeca))
            {
                Console.Write($"{Vez} digite um número de 1 a 9 que esteja disponível: ");
                eUmNumero = int.TryParse(Console.ReadLine(), out posicaoPeca);
            }

            PreencherEscolha(posicaoPeca);
        }

        private void PreencherEscolha(int posicaoPeca)
        {
            int indice = posicaoPeca -1;
            PecaDoJogo[indice] = Vez;
            Contador++;
        }

        private bool posicaoVazia(int posicaoPeca)
        {
            int indice = posicaoPeca - 1;

            if (PecaDoJogo[indice] == 'x' || PecaDoJogo[indice] == 'o')
                return false;
            return true;
        }

        private void RenderizarJogo()
        {
            Console.Clear();
            Console.WriteLine(CarregarJogo());
        }

        private string CarregarJogo()
        {
            return $"__{PecaDoJogo[0]}__|__{PecaDoJogo[1]}__|__{PecaDoJogo[2]}__\n" +
                   $"__{PecaDoJogo[3]}__|__{PecaDoJogo[4]}__|__{PecaDoJogo[5]}__\n" +
                   $"  {PecaDoJogo[6]}  |  {PecaDoJogo[7]}  |  {PecaDoJogo[8]}  \n\n";
        }
    }
}
