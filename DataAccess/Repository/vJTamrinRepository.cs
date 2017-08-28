using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace DataAccess.Repository
{
    public class vJTamrinRepository
    {
        private Connection conn;

        public vJTamrinRepository()
        {
            conn = new Connection();
        }
    }
}