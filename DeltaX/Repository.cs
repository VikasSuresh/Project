using DeltaX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaX
{
    public class Repository
    {
        private DeltaXDBContext Context { get; set; }
        public Repository()
        {
            Context = new DeltaXDBContext();
        }
        public List<Movy> getAllList() {
            List<Movy> list = new List<Movy>();
            list = (from m in Context.Movies                    
                        select m).ToList<Movy>();
            if (list != null)
            {
                return list;
            }
            else {
                return null;
            }

        }
        public List<Actor> getActorsBasedOnId(int id)
        {
            List<Actor> list = new List<Actor>();
            list = (from a in Context.Actors
                    where a.Movieid == id
                    select a
                  ).ToList<Actor>();

            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
        public List<Producer> getProducerBasedOnId(int id)
        {
            List<Producer> list = new List<Producer>();
            list = (from a in Context.Producers
                    where a.Movieid == id
                    select a
                  ).ToList<Producer>();

            if (list != null)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
        public bool AddActor(Actor obj) {
            bool status = false;
            try
            {
                Actor act = new Actor();
                act.Bio = obj.Bio;
                act.DOB = obj.DOB;
                act.Name = obj.Name;
                act.Movieid = obj.Movieid;
                act.Sex = obj.Sex;
                Context.Actors.Add(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }

        public bool AddProducer(Producer obj)
        {
            bool status = false;
            try
            {
                Producer act = new Producer();
                act.Bio = obj.Bio;
                act.DOB = obj.DOB;
                act.Name = obj.Name;
                act.Movieid = obj.Movieid;
                act.Sex = obj.Sex;
                Context.Producers.Add(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }

        public bool AddMovie(Movy obj)
        {
            byte[] byteImageArray;
            byteImageArray = new byte[Convert.ToInt32(0)];
            bool status = false;
            try
            {
                Movy act = new Movy();        
                act.Name = obj.Name;
                act.Plot = obj.Plot;
                act.YearOfRelease = obj.YearOfRelease;
                act.Poster = byteImageArray;

                Context.Movies.Add(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
        public bool EditMovie(Movy obj)
        {
            byte[] byteImageArray;
            byteImageArray = new byte[Convert.ToInt32(0)];
            bool status = false;
            try
            {
                Movy act = Context.Movies.Find(obj.Movie_id);
                act.Name = obj.Name;
                act.Plot = obj.Plot;
                act.YearOfRelease = obj.YearOfRelease;
                act.Poster = byteImageArray;                
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
        public bool DeleteMovie(Movy obj)
        {
             bool status = false;
            try
            {
                Movy act = Context.Movies.Find(obj.Movie_id);
                Context.Movies.Remove(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
        public bool EditProducer(Producer obj)
        {
            bool status = false;
            try
            {
                Producer act = Context.Producers.Find(obj.Producer_id);
                
                act.Bio = obj.Bio;
                act.DOB = obj.DOB;
                act.Name = obj.Name;
                act.Movieid = obj.Movieid;
                act.Sex = obj.Sex;              
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
        public bool DeleteProducer(Producer obj)
        {
            bool status = false;
            try
            {
                Producer act = Context.Producers.Find(obj.Producer_id);

                Context.Producers.Remove(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }

        public bool EditActor(Actor obj)
        {
            bool status = false;
            try
            {
                Actor act = Context.Actors.Find(obj.Actor_id);

                act.Bio = obj.Bio;
                act.DOB = obj.DOB;
                act.Name = obj.Name;
                act.Movieid = obj.Movieid;
                act.Sex = obj.Sex;
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
        public bool DeleteActor(Actor obj)
        {
            bool status = false;
            try
            {
                Actor act = Context.Actors.Find(obj.Actor_id);

                Context.Actors.Remove(act);
                Context.SaveChanges();
                status = true;
            }
            catch { status = false; }
            return status;
        }
    }
}
