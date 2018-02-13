using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olete oma kontorisse jõudnud");
            Console.WriteLine("Aeg on nüüd töötada");
            Console.WriteLine("Kellega te töötada tahate?");
            Console.WriteLine("");
            Console.WriteLine("1 - Nooremarendaja");
            Console.WriteLine("2 - Vanemarendaja");
            Console.WriteLine("3 - Tavakoristaja");
            Console.WriteLine("4 - Spetsiaalkoristaja");
            Console.WriteLine("5 - Ülemus");
            Console.WriteLine("6 - Andmetöötleja");

            int KasutajaValik = Convert.ToInt32(Console.ReadLine());
            switch (KasutajaValik)
            {
                case 1:
                    NooremArendajaValimine noorarendaja = new NooremArendaja();
                    noorarendaja.KontoriTöötaja();
                    break;

                case 2:
                    VanemArendajaValimine vanemarendaja = new VanemArendaja();
                    vanemarendaja.KontoriTöötaja();
                    break;

                case 3:
                    TavaKoristajaValimine tavaKoristaja = new TavaKoristaja();
                    tavaKoristaja.KontoriTöötaja();
                    break;

                case 4:
                    SpetsiaalkoristajaValimine spetsiaalneKoristaja = new SpetsiaalneKoristaja();
                    spetsiaalneKoristaja.KontoriTöötaja();
                    break;

                case 5:
                    ÜlemuseValimine ülemus = new Ülemus();
                    ülemus.KontoriTöötaja();
                    break;

                case 6:
                    Andmetöötleja andmetöötleja = new Andmetöötleja();
                    andmetöötleja.KontoriTöötaja();
                    break;
            }
            
        }
    }
}
