using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class vTamrinRepository
    {
        private Connection conn;

        public vTamrinRepository()
        {
            conn = new Connection();
        }
    }
}
