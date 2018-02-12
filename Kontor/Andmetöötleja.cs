using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontor
{
    class Andmetöötleja : AndmetöötlejaValimine
    {
        public override void Töötaja()
        {
            Name = "Andmetöötleja";
            Arendajaruum = false;
            Ülemuseruum = false;
            köök = true;
            Andmetöötlejaruum = true;
            base.Töötaja();
        }
    }
}
