using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class NooremArendajaValimine : Töötajad
    {
        public virtual void KontoriTöötaja()
        {
            Console.WriteLine(Name);

            Console.WriteLine("");
            Console.WriteLine("Te võite töötada järgmistes ruumides: ");
            Console.WriteLine("");

            if (Arendajaruum == true)
            {
                Console.WriteLine("Arendaja ruumi");
            }
            if (Ülemuseruum == true)
            {
                Console.WriteLine("Ülemuse ruumi");
            }
            if (köök == true)
            {
                Console.WriteLine("kööki");
            }
            if (Andmetöötlejaruum == true)
            {
                Console.WriteLine("Andmetöötleja ruumi");
            }

            Console.WriteLine("");
            Console.WriteLine("Teil ei ole lubatud kasutada järgmisi ruume: ");
            Console.WriteLine("");

            if (Arendajaruum == false)
            {
                Console.WriteLine("Arendaja ruumi");
            }
            if (Ülemuseruum == false)
            {
                Console.WriteLine("Ülemuse ruumi");
            }
            if (köök == false)
            {
                Console.WriteLine("kööki");
            }
            if (Andmetöötlejaruum == false)
            {
                Console.WriteLine("Andmetöötleja ruumi");
            }
            Console.ReadLine();
        }
    }
}
