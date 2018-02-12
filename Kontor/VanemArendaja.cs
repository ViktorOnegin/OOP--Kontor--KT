using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class VanemArendaja : VanemArendajaValimine
    {
        public override void Töötaja()
        {
            Name = "VanemArendaja";
            Arendajaruum = true;
            Ülemuseruum = false;
            köök = true;
            Andmetöötlejaruum = false;
            base.Töötaja();
        }
    }
}
