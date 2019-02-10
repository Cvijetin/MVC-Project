using Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Project.Service.Implementation;
using Project.Service.Interfaces;
using System.Threading.Tasks;

namespace Project.MVC.Controllers
{

    public class VehicleMakeController : Controller
    {
      
        private IVehicleMakeService _vehicleMakeService;
        private IArrange _arrange;
        
        public VehicleMakeController(IVehicleMakeService vehicleMakeService, IArrange arrange)
        {
            _vehicleMakeService = vehicleMakeService;
            _arrange = arrange;
        }
              
        public async Task<ActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            try
            {
                ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewBag.AbrvParm = sortOrder == "Abrv" ? "abrv_desc" : "Abrv";
                ViewBag.CurrentSort = sortOrder;

                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                ViewBag.CurrentFilter = searchString;

                _arrange.PageSize = 4;
                _arrange.Page = page;
                _arrange.SearchString = searchString;
                _arrange.SortOrder = sortOrder;

                var pagedList = await _vehicleMakeService.GetPagedListAsync(_arrange);

                return View(pagedList);
            }
            catch (Exception e)
            {
                throw e;
            }

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
