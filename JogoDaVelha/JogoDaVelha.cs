
namespace JogoDaVelha
{
    class JogoDaVelha
    {
        private char[] PosicaoDasPecas;
        private bool FimDeJogo;
        private char vez;

        public JogoDaVelha()
        {
            FimDeJogo = false;
            PosicaoDasPecas = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
            vez = 'x';
        }

        public void Iniciar()
        {
            RenderizarJogo();
            //LerJogada();
            //RenderizarJogo();
            //HouveGanhador();
            MudarVez();


        }

        private void MudarVez()
        {
            vez = vez == 'x' ? 'o' : 'x';
        }

        private void NovaJogada()
        {
            throw new NotImplementedException();
        }

        private void HouveGanhador()
        {
            throw new NotImplementedException();
        }

        private void LerJogada()
        {
            throw new NotImplementedException();
        }

        private void RenderizarJogo()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());
        }

        private string ObterTabela()
        {
            return $"__{PosicaoDasPecas[0]}__|__{PosicaoDasPecas[1]}__|__{PosicaoDasPecas[2]}__ \n" +
                   $"__{PosicaoDasPecas[3]}__|__{PosicaoDasPecas[4]}__|__{PosicaoDasPecas[5]}__ \n" +
                   $"  {PosicaoDasPecas[6]}  |  {PosicaoDasPecas[7]}  |  {PosicaoDasPecas[8]}  \n\n";
        }
    }
}
