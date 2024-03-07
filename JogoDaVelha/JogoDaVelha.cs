



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
                //VerificarFimJogo();
                MudarVez();
            }
        }

        private void MudarVez()
        {
            Vez = Vez == 'x' ? 'o' : 'x';
        }

        private void LerJogada()
        {
            Console.Write($"{Vez} digite um número de 1 a 9 que esteja disponível: ");
            bool eUmNumero = int.TryParse(Console.ReadLine(), out int posicaoPeca);

            while (!eUmNumero && !posicaoVazia(posicaoPeca))
            {
                Console.Write($"{Vez} digite um número de 1 a 9 que esteja disponível: ");
                eUmNumero = int.TryParse(Console.ReadLine(), out posicaoPeca);
            }

            PreencherEscolha(posicaoPeca);
        }

        private void PreencherEscolha(int posicaoPeca)
        {
            int indice = -1;
            PecaDoJogo[indice] = Vez;
        }

        private bool posicaoVazia(int posicaoPeca)
        {
            if (PecaDoJogo[posicaoPeca] == 'x' || PecaDoJogo[posicaoPeca] == 'o')
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
