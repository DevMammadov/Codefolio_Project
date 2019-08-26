using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MainProjectFull.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.number = "404";
                    ViewBag.error = "Bu səhifə taplmadı";
                    break;
                case 500:
                    ViewBag.number = "500";
                    ViewBag.error = "Serverdə xəta baş verdi";
                    break;
                case 400:
                    ViewBag.number = "400";
                    ViewBag.error = "Göndərdiyiniz sorğuda problem var lütfən yenidən dənəyin";
                    break;
                case 405:
                    ViewBag.number = "405";
                    ViewBag.error = "Göndərdiyiniz sorğu server tərəfindən qəbul edilmədi";
                    break;
                case 408:
                    ViewBag.number = "408";
                    ViewBag.error = "Sorğunuzun server tərəfindən cavablanması gecikir";
                    break;
                case 429:
                    ViewBag.number = "429";
                    ViewBag.error = "Siz bir dəfəyə çox sorğu göndərdiniz. Lütfən biraz dincəlin :)";
                    break;
                default:
                    ViewBag.number = statusCode;
                    ViewBag.error = "";
                    break;
            }


            return View();
        }
    }
}