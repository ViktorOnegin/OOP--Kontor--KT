using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class Ülemus : ÜlemuseValimine
    {
        public override void KontoriTöötaja()
        {
            base.KontoriTöötaja();

            Name = "Ülemus";
            Arendajaruum = false;
            Ülemuseruum = true;
            köök = true;
            Andmetöötlejaruum = false;
        }
    }
}
