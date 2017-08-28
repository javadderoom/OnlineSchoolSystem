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
    public class LessonsRepository
    {
        private Connection conn;

        public LessonsRepository()
        {
            conn = new Connection();
        }

        public DataTable GetAllLessons()
        {
            List<Lesson> result = new List<Lesson>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Lesson> pl =
                    from r in sd.Lessons

                    orderby r.LessonID
                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public List<Lesson> GetListOfAllLessons()
        {
            List<Lesson> result = new List<Lesson>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Lesson> pl =
                    from r in sd.Lessons

                    orderby r.LessonID
                    select r;

                result = pl.ToList();
                return result;
            }
        }

        public void SaveLesson(Lesson lesson)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                if (lesson.LessonID > 0)
                {
                    //==== UPDATE ====
                    pb.Lessons.Attach(lesson);
                    pb.Entry(lesson).State = EntityState.Modified;
                }
                else
                {
                    //==== INSERT ====
                    pb.Lessons.Add(lesson);
                }

                pb.SaveChanges();
            }
        }

        public DataTable FindByTitle(string Name)
        {
            List<Lesson> result = new List<Lesson>();

            using (SchoolDBEntities sd = conn.GetContext())
            {
                IEnumerable<Lesson> pl =
                    from r in sd.Lessons
                    where r.LessonTitle.Contains(Name)

                    select r;

                result = pl.ToList();
                return OnlineTools.ToDataTable(result);
            }
        }

        public Lesson FindByLessonID(int id)
        {
            SchoolDBEntities db = new SchoolDBEntities();

            return db.Lessons.Where(p => p.LessonID == id).Single();
        }

        public void DeleteLesson(int EID)

        {
            SchoolDBEntities pb = conn.GetContext();

            Lesson selectedLesson = new Lesson();
            selectedLesson = pb.Lessons.Where(p => p.LessonID == EID).Single();

            if (selectedLesson != null)
            {
                pb.Lessons.Remove(selectedLesson);
                pb.SaveChanges();
            }
        }

        public void DeleteLessons(List<int> EIDs)
        {
            using (SchoolDBEntities pb = conn.GetContext())
            {
                var selectedLessons =
                    from r in pb.Lessons
                    join at in EIDs
                    on r.LessonID equals at
                    select r;

                foreach (var lesson in selectedLessons)
                {
                    pb.Lessons.Remove(lesson as Lesson);
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

                    db.ExecuteCommand("TRUNCATE TABLE Lesson");
                }
            }
        }
    }
}