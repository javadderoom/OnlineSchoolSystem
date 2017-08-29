using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
using System.Web.Configuration;
using System.Configuration;

namespace DataAccess.Repository
{
    public class vPaymentHistoryRepository
    {
        int? remainedSalary = 0;
        private SchoolDBEntities db = new SchoolDBEntities();
        private Connection conn;

        public vPaymentHistoryRepository()
        {
            conn = new Connection();
        }


        public void SavePaymentHistory(PaymentHistory payhis)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                if (payhis.HID > 0)
                {
                    //==== UPDATE ====
                    pb.PaymentHistories.Attach(payhis);
                    pb.Entry(payhis).State = EntityState.Modified;
                }
                else
                {
                    //==== INSERT ====
                    pb.PaymentHistories.Add(payhis);
                }

                pb.SaveChanges();
            }
        }
        public DataTable getPaymentHistoryByStuCode(string stuCode)
        {
            SchoolDBEntities pb = conn.GetContext();
            var query =
                from r in pb.vPaymentHistories
                where r.StuCode == stuCode
                orderby r.HID descending
                select r;

            List<vPaymentHistory> lp = new List<vPaymentHistory>();
            lp = query.ToList();

            remainedSalary = lp.Sum(p => p.Mablagh);

            return OnlineTools.ToDataTable(lp);

        }
        public int? calculateRemainedSalary()
        {
            return remainedSalary;
        }

    }
}