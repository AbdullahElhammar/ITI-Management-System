using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_Lecture3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public async  Task<IActionResult> add(int id, string name, int age,IFormFile stdimg)
        {
            string FileExt = stdimg.FileName.Split('.').Last();
            //var fs = new FileStream($"wwwroot/images/file1.{FileExt}", FileMode.Create);
            //await stdimg.CopyToAsync(fs);
            //fs file is created by OS and to release this file to be able to used by other users:
            //fs.Dispose();

            //another and the model use to use Dispose();
            using (var fs = new FileStream($"wwwroot/images/file1.{FileExt}", FileMode.Create))
            {
                stdimg.CopyToAsync(fs);   //used only used with dispoible objects
            }

            return Content("added");
        }


    }
}
