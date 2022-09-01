using System;
using System.Collections.Generic;

namespace JuegoDeCartas
{
	class Baraja
	{
		List<Carta> baraja = new List<Carta>();
		Carta naype;
		public Baraja()
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 12; j++)
				{
					naype = new Carta(j+1, i);
					baraja.Add(naype);
				}
			}
		}
		public void NumeoCartas()
		{
			Console.WriteLine(baraja.Count());
        }
		public Carta RobaCarta()
		{
			Carta carta = baraja[0];
            Console.WriteLine(baraja[0].ToString());
            baraja.RemoveAt(0);
			return carta;
		}
		public Carta CogeCarta(int PosicioDeLaCarta)
		{
			Console.WriteLine(baraja[PosicioDeLaCarta].ToString());
			Carta carta = baraja[PosicioDeLaCarta];
			return carta;
        }
		public Carta CogeCartaAlAzar()
		{
            Random rand = new Random();
            int cartaEsCojida = rand.Next(baraja.Count());
			Carta carta = baraja[cartaEsCojida];
            Console.WriteLine(baraja[cartaEsCojida].ToString());
			return carta;
        }
		public void Barajar()
		{
            List<Carta> barajaTemporal = new List<Carta>();
            for (int i = 0; i < 48; i++)
			{
                Random rand = new Random();
                int cartaEsCojida = rand.Next(baraja.Count());
				barajaTemporal.Add(baraja[cartaEsCojida]);
				baraja.RemoveAt(cartaEsCojida);
            }
			baraja = barajaTemporal;
		}
        public void ToString()
		{
			for (int i = 0; i < baraja.Count; i++)
			{
				Console.WriteLine(baraja[i].ToString());
			}
		}
    }
}
