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
    public class KarmandRepository
    {
        private Connection conn;

        public KarmandRepository()
        {
            conn = new Connection();
        }

        public DataTable GetAllEmployees()
        {
            List<Karmand> result = new List<Karmand>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Karmand> pl =
                    from r in sd.Karmands

                    orderby r.LastName
                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public List<Karmand> GetListOfAllEmployees()
        {
            List<Karmand> result = new List<Karmand>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Karmand> pl =
                    from r in sd.Karmands

                    orderby r.LastName
                    select r;

                result = pl.ToList();
                return result;
            }
        }

        public void SaveEmployees(Karmand kramand)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                if (kramand.EID > 0)
                {
                    //==== UPDATE ====
                    pb.Karmands.Attach(kramand);
                    pb.Entry(kramand).State = EntityState.Modified;
                }
                else
                {
                    //==== INSERT ====
                    pb.Karmands.Add(kramand);
                }

                pb.SaveChanges();
            }
        }

        public Karmand FindByEmployeeID(string id)
        {
            SchoolDBEntities db = new SchoolDBEntities();

            return db.Karmands.Where(p => p.PersonalCode == id).Single();
        }

        public DataTable FindByName(string Name)
        {
            List<Karmand> result = new List<Karmand>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Karmand> pl =
                    from r in sd.Karmands
                    where r.FirstName.Contains(Name)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public DataTable FindByFullName(string firstName, string lastName)
        {
            List<Karmand> result = new List<Karmand>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Karmand> pl =
                    from r in sd.Karmands
                    where r.FirstName.Contains(firstName) && r.LastName.Contains(lastName)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public void DeleteEmployee(string EID)
        {
            SchoolDBEntities pb = conn.GetContext();

            Karmand selectedEmployee = pb.Karmands.Where(p => p.PersonalCode == EID).Single();

            if (selectedEmployee != null)
            {
                pb.Karmands.Remove(selectedEmployee);
                pb.SaveChanges();
            }
        }

        public void DeleteCities(List<int> EIDs)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                var selectedEmployee =
                    from r in pb.Karmands
                    join at in EIDs
                    on r.EID equals at
                    select r;

                foreach (var karmand in selectedEmployee)
                {
                    pb.Karmands.Remove(karmand as Karmand);
                }

                pb.SaveChanges();
            }
        }

        public void DeleteAll()
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                System.Configuration.ConnectionStringSettingsCollection connectionStrings =
                    WebConfigurationManager.ConnectionStrings as ConnectionStringSettingsCollection;

                if (connectionStrings.Count > 0)
                {
                    System.Data.Linq.DataContext db = new System.Data.Linq.DataContext(connectionStrings["ConnectionString"].ConnectionString);

                    db.ExecuteCommand("TRUNCATE TABLE CityInfo");
                }
            }
        }
    }
}