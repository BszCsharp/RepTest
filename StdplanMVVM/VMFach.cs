using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdplanModel;
namespace StdplanMVVM
{
    public class VMFach
    {
        Fach vFach;

        public Fach VFach { get => vFach; set => vFach = value; }
        public int Id {
            get => VFach.FachId ; set => VFach.FachId = value; }
        public string Bezeichnung { get =>  VFach.FachBezeichnung; set => VFach.FachBezeichnung = value; }

        public override string ToString()
        {
            return this.VFach.FachBezeichnung;
        }
        public VMFach()
        {
            VFach = new Fach
            {
                FachId = -1,
                FachBezeichnung = "Bezeichnung eingeben"
            };
        }
        
        
    }
}
