using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using DataAccess;
using System.Data;

namespace StdplanModel
{
    public class Faecher
    {
        DTO dto = new DTO();
        ObservableCollection<Fach> listFaecher;
        public Faecher()
        {
            ListFaecher = new ObservableCollection<Fach>();
            //dto.OpenConnection();
            DataSet ds = dto.GetAlleFaecher();
            DataTable dt = ds.Tables[0];
            DataTableReader reader = dt.CreateDataReader();
            while(reader.Read())
            {
                Fach f = MkFach(reader);
                ListFaecher.Add(f);
            }

        }

        private Fach MkFach(DataTableReader reader)
        {
            Fach f = new Fach
            {
                FachId = reader.GetInt32(0),
                FachBezeichnung = reader.GetString(1)
            };
            return f;
        }
       
        public ObservableCollection<Fach> ListFaecher { get => listFaecher; set => listFaecher = value; }

        public void Add(Fach neuesFach)
        {
            ListFaecher.Add(neuesFach);
        }

    }
}
