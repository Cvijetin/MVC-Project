using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{

    public class VehicleMakeController : Controller
    {
      
        
        
        public VehicleMakeController()
        {
           
        }
              
        public ActionResult Index()
        {
            return View();

        }
        

        // GET: VehicleMake/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehicleMake/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleMake/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleMake/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehicleMake/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VehicleMake/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehicleMake/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
