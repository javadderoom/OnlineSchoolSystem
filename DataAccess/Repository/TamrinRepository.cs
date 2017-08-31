using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class TamrinRepository
    {
        private Connection conn;
        SchoolDBEntities sd;

        public TamrinRepository()
        {
            conn = new Connection();
            sd = conn.GetContext();
        }

        public int countTamrinByid(int id)
        {
            int query =
               (from r in sd.Tamarins
                where r.GroupID == id
                select r).Count();

            return query;
        }
    }
}
