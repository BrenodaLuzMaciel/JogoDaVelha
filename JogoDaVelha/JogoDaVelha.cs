


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
                //LerJogada();
                RenderizarJogo();
                //VerificarFimJogo();
                MudarVez();
            }
        }

        private void MudarVez()
        {
            Vez = Vez == 'x' ? 'o' : 'x';
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
