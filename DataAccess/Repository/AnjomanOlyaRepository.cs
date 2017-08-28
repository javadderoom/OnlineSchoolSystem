using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class AnjomanOlyaRepository
    {
        private Connection conn;

        public AnjomanOlyaRepository()
        {
            conn = new Connection();
        }
    }
}
