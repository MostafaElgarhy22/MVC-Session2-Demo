using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Structure.Models;

namespace Project_Structure.Controllers
{
    public class MoviesController : Controller
    {



        //Action: Public Non-Static Object Member Method inside the Controller
        [HttpGet] // Get: baseUrl/Movies/Index
        public string Index()
        {
            return "All Movies";
        }

        [HttpGet] // Get: baseUrl/Movies/GetMovie/{id}
        [Authorize]
        public string GetMovie(int id, string name)
        {
            return $"Movie with Name : {name} and Id = {id}";
        }

        [HttpGet] 
        //[AcceptVerbs("GET", "POST")] 
        public ViewResult CreateMovie()
        {
            return new ViewResult();
        }

        [HttpPost] 
        public OkResult CreateMovie(Movie model)
        {
            return new OkResult();
        }
    }
}
