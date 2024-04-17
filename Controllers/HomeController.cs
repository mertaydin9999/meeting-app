using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "Iyi Gunler":"Gunaydin";
            int userCount = Repository.Users.Where(i => i.WillAttend).Count();

            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location="Istanbul",
                Date= new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=userCount

            };

            return View(meetingInfo);
        }
    }
}