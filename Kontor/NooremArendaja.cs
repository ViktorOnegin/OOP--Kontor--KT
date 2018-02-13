using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class NooremArendaja : NooremArendajaValimine
    {
        public override void KontoriTöötaja()
        {
            base.KontoriTöötaja();

            Name = "NooremArendaja";
            Arendajaruum = true;
            Ülemuseruum = false;
            köök = true;
            Andmetöötlejaruum = true;
        }
    }
}
