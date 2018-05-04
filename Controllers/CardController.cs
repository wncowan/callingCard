using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace callingCard.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World!";
        }
        // A GET method
        [HttpGet]
        // [Route("/{first_name}/{last_name}/{age}/{fav_color}")]
        [Route("{first_name}/{last_name}/{age}/{fav_color}")]
        public JsonResult DisplayCard(string first_name, string last_name, string age, string fav_color)
        {
            var AnonObject = new {
                firstName = first_name,
                lastName = last_name,
                Age = age,
                favColor = fav_color
            };
            Console.WriteLine("Hello");
            return Json(AnonObject);
        }
    }
}