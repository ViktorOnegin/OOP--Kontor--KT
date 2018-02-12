using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class SpetsiaalneKoristaja : SpetsiaalkoristajaValimine
    {
        public override void Töötaja()
        {
            base.Töötaja();

            Name = "SpetsiaalneKoristaja";
            Arendajaruum = true;
            Ülemuseruum = true;
            köök = true;
            Andmetöötlejaruum = true;
        }
    }
}
