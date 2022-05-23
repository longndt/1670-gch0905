using Microsoft.AspNetCore.Mvc;

namespace web2.Controllers
{
    public class HelloController : Controller
    {
        [Route("/")]
        //Để set 1 page làm trang chủ thì dùng Route "/"
        [Route("/HelloWorld")]
        //Có thể set 1 route hoặc nhiều route để chạy 1 action
        //1 action chỉ render ra 1 view (1 web page) duy nhất
        public IActionResult Greenwich()
        {
            //mặc định action này sẽ render ra file index.cshtml 
            //trong thư mục Views => Hello
            //return View();

            //muốn render ra view khác thì set đường dẫn mới trong
            //phần return View()
            return View("~/Views/Demo/Greenwich.cshtml");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Math()
        {
            return View("~/Views/Demo/Math.cshtml");
        }
    }
}
