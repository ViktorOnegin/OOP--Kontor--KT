﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class TavaKoristaja : TavaKoristajaValimine
    {
        public override void KontoriTöötaja()
        {
            base.KontoriTöötaja();

            Name = "Tavakoristaja";
            Arendajaruum = true;
            Ülemuseruum = false;
            köök = true;
            Andmetöötlejaruum = true;
        }
    }
}
