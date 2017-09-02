using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class vNomratRepository
    {
        private Connection conn;

        public vNomratRepository()
        {
            conn = new Connection();
        }
        public void SaveNomre(Nomarat nomre)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                if (nomre.NomreID > 0)
                {
                    //==== UPDATE ====
                    pb.Nomarats.Attach(nomre);
                    pb.Entry(nomre).State = EntityState.Modified;
                }
                else
                {
                    //==== INSERT ====
                    pb.Nomarats.Add(nomre);
                }

                pb.SaveChanges();
            }
        }
    }
}
