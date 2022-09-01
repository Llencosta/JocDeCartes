using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            baraja.Barajar();
            baraja.NumeoCartas();
            baraja.RobaCarta();
            baraja.CogeCarta(20);
            Console.WriteLine(" ");
            baraja.ToString();
            Console.ReadLine();
        }
    }
}