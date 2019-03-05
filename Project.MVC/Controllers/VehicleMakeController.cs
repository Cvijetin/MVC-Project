using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Services;
using Repository.Helpers;
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

        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var vehicleMake = await _vehicleMakeService.GetByIdAsync(id);
                if (vehicleMake == null)
                {
                    return HttpNotFound();
                }
                return View(vehicleMake);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public async Task<ActionResult> Create(VehicleMakeDTO collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _vehicleMakeService.InsertAsync(collection);

                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    return Content(e.Message.ToString());
                }
            }
            else
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var vehicleMake = await _vehicleMakeService.GetByIdAsync(id);
                if (vehicleMake == null)
                {
                    return HttpNotFound();
                }
                return View(vehicleMake);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, VehicleMakeDTO collection)
        {
            try
            {
                await _vehicleMakeService.Update(collection);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var vehicleMake = await _vehicleMakeService.GetByIdAsync(id);
                return View(vehicleMake);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id, VehicleMakeDTO collection)
        {
            try
            {
                await _vehicleMakeService.DeleteAsync(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}