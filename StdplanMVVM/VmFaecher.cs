using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StdplanModel;

namespace StdplanMVVM
{
    public class VmFaecher
    {
        Faecher faecher;

        public Faecher Faecher { get => faecher; set => faecher = value; }
        
        public VmFaecher()
        {
            Faecher = new Faecher();
            //foreach(Fach f in Faecher.ListFaecher)
            //{
            //    VMFach vf = new VMFach();
            //    vf.VFach.FachId = f.FachId;
            //    vf.VFach.FachBezeichnung = f.FachBezeichnung;
            //    Faecher.Add(f);
            //}
        }
        
        public void Add(VMFach neuesFach)
        {
            //Fach f = new Fach
            //{
            //    FachId = neuesFach.Fach.FachId,
            //    FachBezeichnung = neuesFach.Fach.FachBezeichnung
            //};
            //Faecher.Add(f);
        }
    }
}
