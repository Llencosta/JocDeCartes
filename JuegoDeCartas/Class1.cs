using System;
using System.CodeDom;

namespace JuegoDeCartas
{
    public class Carta
    {
        private int numero;
        private int forma;
        private string[] PosiblesFormas = { "palos", "monedas", "copas", "espadas" };

        public Carta()
        {
            numero = 0;
            forma = 0;
        }

        public Carta(int num, int form)
        {
            numero = num;
            forma = form;
        }

        public int Numero { get; set; }
        public int Forma { get; set; }

        public override string ToString()
        {
            return numero + " de " + PosiblesFormas[forma];
        }
    }
}
