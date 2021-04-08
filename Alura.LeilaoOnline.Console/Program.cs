using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.Console
{
    class Program
    {
        static void Main()
        {
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);

            leilao.TerminaPregao();

        }
    }
}
