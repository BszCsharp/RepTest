using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DataAccess
{
    public class DTO
    {
        OleDbConnection con;
        public DTO()
        {
            con = new OleDbConnection(Properties.Settings.Default.ConString);
            //con.Open();
        }
        public bool OpenConnection()
        {

            Boolean result = true;
             try
            {
                con.Open();
            }
            catch (Exception)
            {

                result = false; ;
            }
            return result;
        }
        public DataSet GetAlleFaecher()
        {
            DataSet dsFaecher = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter("Select * from tFach", con);
            adp.Fill(dsFaecher, "Faecher");
            return dsFaecher;
        }


    }
}
