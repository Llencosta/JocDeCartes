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
		public void RobaCarta()
		{
            Console.WriteLine(baraja[0].ToString());
            baraja.RemoveAt(0);
		}
		public void CogeCarta(int PosicioDeLaCarta)
		{
			Console.WriteLine(baraja[PosicioDeLaCarta].ToString());
        }
		public void CogeCartaAlAzar()
		{
            Random rand = new Random();
            int cartaEsCojida = rand.Next(baraja.Count());
            Console.WriteLine(baraja[cartaEsCojida].ToString());
        }
		public void Barajar()
		{
            List<Carta> barajaTemporal = new List<Carta>();
            for (int i = 0; i < 48; i++)
			{
                Random rand = new Random();
                int cartaEsCojida = rand.Next(baraja.Count());
				barajaTemporal.Add(baraja[cartaEsCojida]);
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
