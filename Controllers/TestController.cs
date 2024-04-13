using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_Lecture3.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            int id = 10;
            string name = "abdullah";
            Response.Cookies.Append("id",id.ToString());
            Response.Cookies.Append("name",name);
            return Content("data added in cooky");
        }
        public IActionResult Show()
        {
            string name = Request.Cookies["name"];
            int id=int.Parse (Request.Cookies["id"]);
            return Content($"{name}, {id}");

        }
    }
}
