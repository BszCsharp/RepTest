using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdplanModel
{
    public class Fach
    {
        private Int32 fachid;
        private String fachBezeichnung;

        public int FachId { get => fachid; set => fachid = value; }
        public string FachBezeichnung { get => fachBezeichnung; set => fachBezeichnung = value; }
        public Fach()
        {
            this.FachId = 0;
            this.FachBezeichnung = String.Empty;
        }
        public override string ToString()
        {
            return this.FachBezeichnung;
        }
    }
}
