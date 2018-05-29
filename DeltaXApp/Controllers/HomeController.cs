using DeltaX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeltaXApp.Controllers
{
    public class HomeController : Controller
    {
        

        
        public ActionResult Details()
        {
            Repository rep = new Repository();
            List<Movy> list = rep.getAllList();
            List<Models.Movie> listx = new List<Models.Movie>();
            AutoMapper.Mapper.Map(list, listx);
            return View(listx);
        }
        public ActionResult getActors(int id ) {
            Repository rep = new Repository();
            Session["Movieid"] = id;
            List<Actor> list = rep.getActorsBasedOnId(id);
            List<Models.Actor> listx = new List<Models.Actor>();
            AutoMapper.Mapper.Map(list, listx);
            return View(listx);
        }
        public ActionResult getProducers(int id)
        {
            Repository rep = new Repository();
            List<Producer> list = rep.getProducerBasedOnId(id);
            Session["Movieid"] = id;
            List<Models.Producer> listx = new List<Models.Producer>();
            AutoMapper.Mapper.Map(list, listx);
            return View(listx);
        }
        public ActionResult AddMovie()
        {
            
            return View();
        }
        public ActionResult SaveMovie(Models.Movie obj) {
            Repository rep = new Repository();
            Movy mov = new Movy();
            var list1 = AutoMapper.Mapper.Map(obj, mov);
            var status = rep.AddMovie(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }

        public ActionResult EditMovie(Models.Movie obj)
        {
            return View(obj);
        }
        public ActionResult SaveEditMovie(Models.Movie obj)
        {
            Repository rep = new Repository();
            Movy list = new Movy();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.EditMovie(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }
        public ActionResult DeleteMovie(Models.Movie obj)
        {
            return View(obj);
        }

        public ActionResult SaveDeleteMovie(Models.Movie obj)
        {
            Repository rep = new Repository();
            Movy list = new Movy();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.DeleteMovie(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }



        public ActionResult AddActor() {
            ViewBag.MovieId = Session["Movieid"];
            return View();
        }
        public ActionResult SaveActor(Models.Actor obj)
        {
            Repository rep = new Repository();
            Actor list = new  Actor();
            var list1=AutoMapper.Mapper.Map(obj, list);
            var status = rep.AddActor(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else {

                return View("Error");
            }

        }

        public ActionResult AddProducer()
        {
            ViewBag.MovieId = Session["Movieid"];
            return View();
        }
        public ActionResult SaveProducer(Models.Producer obj)
        {
            Repository rep = new Repository();
            Producer list = new Producer();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.AddProducer(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }

        }

        public ActionResult EditProducer(Models.Producer obj) {
            return View(obj);
        }
        public ActionResult SaveEditProducer(Models.Producer obj)
        {
            Repository rep = new Repository();
            Producer list = new Producer();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.EditProducer(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }
        public ActionResult DeleteProducer(Models.Producer obj) {
            return View(obj);
        }

        public ActionResult SaveDeleteProducer(Models.Producer obj)
        {
            Repository rep = new Repository();
            Producer list = new Producer();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.DeleteProducer(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }

        public ActionResult EditActor(Models.Actor obj)
        {
            return View(obj);
        }
        public ActionResult SaveEditActor(Models.Actor obj)
        {
            Repository rep = new Repository();
            Actor list = new Actor();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.EditActor(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }
        public ActionResult DeleteActor(Models.Actor obj)
        {
            return View(obj);
        }

        public ActionResult SaveDeleteActor(Models.Actor obj)
        {
            Repository rep = new Repository();
            Actor list = new Actor();
            var list1 = AutoMapper.Mapper.Map(obj, list);
            var status = rep.DeleteActor(list1);
            if (status == true)
            {
                return RedirectToAction("Details");
            }
            else
            {

                return View("Error");
            }
        }

    }

}


