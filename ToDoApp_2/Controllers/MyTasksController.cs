using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp_2.Models;
using ToDoApp_2.Models.Managers;
using ToDoApp_2.ViewModels.MyTasks;

namespace ToDoApp_2.Controllers
{
    public class MyTasksController : Controller
    {
        public ActionResult DB()
        {
            DatabaseContext db = new DatabaseContext();
            List<Tasks> tasks = db.Gorevler.ToList();
            return View();

        }

        // GET: MyTasks
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();

            IndexViewModel model = new IndexViewModel();
            model.Gorevler= db.Gorevler.ToList();
            model.Kisiler= db.Kisiler.ToList();

            return View(model);
        }

        public ActionResult NewTask()
        {

            return View();
        }


    }
}