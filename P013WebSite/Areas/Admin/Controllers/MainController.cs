using Microsoft.AspNetCore.Authorization; // Oturum açmayı gerekli kılan kütüphane Authorize
using Microsoft.AspNetCore.Mvc;

namespace P013WebSite.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize] // Bir controller a Authorize ü uygukarsak controller içerisindeki bütün actionlara erişimi engellemiş oluruz. Sadece oturum açan kullanıcılar ekranları görebilir.
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
