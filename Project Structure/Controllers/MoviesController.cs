using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_Structure.Models;

namespace Project_Structure.Controllers
{
    public class MoviesController : Controller
    {

        // Model value Provider poriority
        /// 2- Route Data    Segment
        /// 3- Query String  Query Parameter
        /// 1- Form-Data     Input
        // 4- Request Header    Header
        // 5- Request Body    Body      used with data Json or XML.

        [HttpGet] // Get: baseUrl/Movies/GetMovie/{id}
        public IActionResult GetMovie([FromBody]int id, Movie movie)
        {
            if(id == 0)
           
              //return new BadRequestResult();
            return BadRequest();

            if (id == 100)

                // return new NotFoundResult();
                return NotFound();

            //ContentResult result = new ContentResult();
            //result.Content = $"<h1> Movie with Id: {id} <h1>";

            //result.ContentType = "text/html";
            ////result.StatusCode = 200;

            //return result;

            return Content ( $"<h1> Movie with Id: {id} <h1>","text/html");
            
        }

        [HttpPost] 
        public IActionResult CreateMovie(Movie movie)
        {
            return View(movie);
        }







        //[HttpGet] 
        //public IActionResult Hamada()
        //{
        //    //RedirectResult result = new RedirectResult("https://www.google.com");
        //    //RedirectToActionResult result = new RedirectToActionResult("GetMovie","Movies", new { id = 10 });


        //    //return Redirect(_configuration["MySettings:RedirectUrl"]?? string.Empty);

        //    //RedirectToRouteResult result = new RedirectToRouteResult("default", new { controller = "Movies", action = "GetMovie", id = 10 });
        //    //return result;
        //   // return RedirectToRoute("default",null);
        //}

    }
}
