using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class vJavabeTamrinRepository
    {
        private Connection conn;
        SchoolDBEntities sd;

        public vJavabeTamrinRepository()
        {
            conn = new Connection();
            sd = conn.GetContext();
        }

        public double TedadejavabeTamrin(int id)
        {
            int query =
                (from r in sd.vJavabeTamrins
                 where r.LGID == id
                 select r).Count();

            return query;
        }
    }
}
