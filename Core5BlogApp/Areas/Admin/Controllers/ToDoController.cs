using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5BlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    [AllowAnonymous]
    public class ToDoController : Controller
    {
        ToDoManager toDoManager = new ToDoManager(new EfToDoRepository());

        [HttpPost]
        public JsonResult ToDoDelete(int id)
        {
            var toDo = toDoManager.TGetByID(id);

            if (toDo != null)
            {
                toDoManager.TDelete(toDo);
            }

            return Json(toDo);
        }

        [HttpPost]
        public JsonResult ToDoAdd(ToDo toDo)
        {
            if (toDo != null)
            {
                var email = HttpContext.Session.GetString("Mail");
                toDo.Mail = email;
                toDo.status = true;
                toDoManager.TAdd(toDo);
            }

            return Json(toDo);
        }

        [HttpPost]
        public JsonResult ToDoGetItem(int id)
        {
            var toDo = JsonConvert.SerializeObject(toDoManager.TGetByID(id));
            return Json(toDo);
        }

        [HttpPost]
        public JsonResult ToDoUpdate(ToDo toDo)
        {
            if (toDo != null)
            {
                var status = toDoManager.TGetByID(toDo.Id);
                var email = HttpContext.Session.GetString("Mail");
                toDo.Mail = email;
                if (status.status == true)
                {
                    toDo.status = true;
                    toDoManager.TUpdate(toDo);
                }
                else if (status.status == false)
                {
                    toDo.status = false;
                    toDoManager.TUpdate(toDo);
                }
                else
                {
                }
            }

            return Json(toDo);
        }

        [HttpPost]
        public JsonResult ToDoUpdateT(int id)
        {
            var toDo = toDoManager.TGetByID(id);

            if (toDo != null)
            {
                var email = HttpContext.Session.GetString("Mail");
                toDo.Mail = email;
                toDo.status = true;
                toDoManager.TUpdate(toDo);
            }

            return Json(toDo);
        }

        [HttpPost]
        public JsonResult ToDoUpdateF(int id)
        {
            var toDo = toDoManager.TGetByID(id);

            if (toDo != null)
            {
                var email = HttpContext.Session.GetString("Mail");
                toDo.Mail = email;
                toDo.status = false;
                toDoManager.TUpdate(toDo);
            }

            return Json(toDo);
        }
    }
}
