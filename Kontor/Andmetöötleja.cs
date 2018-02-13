using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class Andmetöötleja : AndmetöötlejaValimine
    {
        public override void KontoriTöötaja()
        {
            base.KontoriTöötaja();

            Name = "Andmetöötleja";
            Arendajaruum = false;
            Ülemuseruum = false;
            köök = true;
            Andmetöötlejaruum = true;
        }
    }
}
