using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace meeting_app.Controllers
{
    public class MeetingController : Controller
    {   
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if(ModelState.IsValid)
            {
                Repository.CreaetUser(model);
                ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend==true).Count();
                return View("Thanks",model);
            }else
            {
                return View(model);
            }
            
        }
         public IActionResult List()
        {
            
            return View(Repository.Users);
        }
        public IActionResult Details (int id)
        {
            return View(Repository.GetById(id));
        }
    }
}